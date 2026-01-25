// Defense/EnemySpawner.cs

using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private WavePattern wavePattern;
    [SerializeField] private Enemy enemyPrefab;
    
    private float gameTimer = 0f;
    private int currentWaveIndex = 0;
    private int scalingIteration = 0;
    
    void Update()
    {
        gameTimer += Time.deltaTime;
        
        if (currentWaveIndex < wavePattern.waves.Count)
        {
            // TODO: wavePattern.waves[currentWaveIndex].spawnTime 체크
            // TODO: 시간 도달 시 SpawnWave() 호출
            if (gameTimer >= wavePattern.waves[currentWaveIndex].spawnTime)
            {
                SpawnWave(wavePattern.waves[currentWaveIndex]);
                currentWaveIndex++;
            }
        }
        else if (wavePattern.infiniteScaling)
        {
            // TODO: SpawnScaledWave() 주기적 호출
            SpawnScaledWave(scalingIteration);
        }
    }
    
    private void SpawnWave(WavePattern.Wave wave)
    {
        // TODO: wave.enemyCount만큼 반복
        for (int i = 0; i < wave.enemyCount; i++)
        {
            Vector3 spawnPosition = GridSystem.Instance.GetRandomBorderPosition();
            Enemy enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        // TODO: GridSystem.GetRandomBorderPosition() 에서 스폰
        // TODO: Enemy.Initialize(wave 데이터, path)
            enemy.Initialize(
                wave.enemyHealth * Mathf.Pow(wavePattern.healthScalingMultiplier, scalingIteration),
                wave.enemyDamage * Mathf.Pow(wavePattern.damageScalingMultiplier, scalingIteration),
                wave.moveSpeed,
                Mathf.RoundToInt(wave.goldReward * Mathf.Pow(wavePattern.goldScalingMultiplier, scalingIteration)),
                null // 如果没有路径数据，传入 null 或按需设置
            );
        }
    }
    
    private void SpawnScaledWave(int iteration)
    {
        // TODO: 공식 2.8에 따라 스케일링된 값 계산
        float hp = wavePattern.waves[0].enemyHealth * Mathf.Pow(wavePattern.healthScalingMultiplier, iteration);
        float damage = wavePattern.waves[0].enemyDamage * Mathf.Pow(wavePattern.damageScalingMultiplier, iteration);
        int gold = Mathf.RoundToInt(wavePattern.waves[0].goldReward * Mathf.Pow(wavePattern.goldScalingMultiplier, iteration));
        int count = wavePattern.waves[0].enemyCount + (wavePattern.enemyCountIncrement * iteration);

        // TODO: SpawnWave()와 동일하게 생성
        WavePattern.Wave scaledWave = new WavePattern.Wave
        {
            spawnTime = Time.time + 5f,
            enemyCount = count,
            enemyHealth = hp,
            enemyDamage = damage,
            moveSpeed = wavePattern.waves[0].moveSpeed,
            goldReward = gold
        };

        SpawnWave(scaledWave);
        scalingIteration++;
    }
}
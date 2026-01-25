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
        }
        else if (wavePattern.infiniteScaling)
        {
            // TODO: SpawnScaledWave() 주기적 호출
        }
    }
    
    private void SpawnWave(WavePattern.Wave wave)
    {
        // TODO: wave.enemyCount만큼 반복
        // TODO: GridSystem.GetRandomBorderPosition() 에서 스폰
        // TODO: Enemy.Initialize(wave 데이터, path)
    }
    
    private void SpawnScaledWave(int iteration)
    {
        // TODO: 공식 2.8에 따라 스케일링된 값 계산
        // TODO: SpawnWave()와 동일하게 생성
    }
}
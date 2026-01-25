// Defense/DangerSystem.cs

using UnityEngine;

public class DangerSystem : MonoBehaviour
{
    private GameConfig config;
    private bool isDanger = false;
    
    public void Initialize(GameConfig gameConfig)
    {
        config = gameConfig;
    }
    
    void Update()
    {
        CheckDanger();
    }
    
    private void CheckDanger()
    {
        var enemies = GameManager.Instance.defenseManager.GetAllEnemies();
        float highestProgress = -1;
        // TODO: DefenseManager.GetAllEnemies() 순회
        // TODO: 최대 progress 찾기
        foreach (Enemy enemy in enemies)
        {
            float progress = enemy.GetProgress();
            
            if (progress > highestProgress)
            {
                highestProgress = progress;
            }
        }
        // TODO: progress >= config.dangerThreshold 체크
        bool dangerStatus = highestProgress >= config.dangerThreshold;
        // TODO: 상태 변경 시 GameManager.OnDangerChanged() 호출
        if (dangerStatus != isDanger)
        {
            isDanger = dangerStatus;
            GameManager.Instance.OnDangerChanged(isDanger);
        }
    }
}
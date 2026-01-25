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
        // TODO: DefenseManager.GetAllEnemies() 순회
        // TODO: 최대 progress 찾기
        // TODO: progress >= config.dangerThreshold 체크
        // TODO: 상태 변경 시 GameManager.OnDangerChanged() 호출
    }
}
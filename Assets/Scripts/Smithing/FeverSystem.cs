// Smithing/FeverSystem.cs

using UnityEngine;

public class FeverSystem : MonoBehaviour
{
    private GameConfig config;
    private int consecutiveGreatSuccess = 0;
    private bool isFeverActive = false;
    private float feverTimer = 0f;
    
    public void Initialize(GameConfig gameConfig)
    {
        config = gameConfig;
    }
    
    public bool IsFeverActive() => isFeverActive;
    
    public void OnSmithingResult(SmithingResultType type)
    {
        // TODO: GREAT_SUCCESS → count 증가, feverTriggerCount 도달 시 발동
        // TODO: DESTROY → count 리셋
    }
    
    private void ActivateFever()
    {
        // TODO: isFeverActive = true, feverTimer 설정
        // TODO: SmithingManager.OnFeverActivated() 호출
    }
    
    void Update()
    {
        if (!isFeverActive) return;
        
        // TODO: feverTimer 감소, 0 도달 시 DeactivateFever() 호출
    }
    
    private void DeactivateFever()
    {
        // TODO: isFeverActive = false
        // TODO: SmithingManager.OnFeverDeactivated() 호출
    }
}
// Smithing/GaugeController.cs

using UnityEngine;

public class GaugeController : MonoBehaviour
{
    private GameConfig config;
    private float currentValue = 0f;
    private int direction = 1;
    private float speed;
    private bool isMoving = false;
    
    [SerializeField] private SmithingUI smithingUI;
    
    public void Initialize(GameConfig gameConfig)
    {
        config = gameConfig;
    }
    
    public void StartGauge(int level, bool isFever)
    {
        // TODO: 공식에 따라 speed 계산
        //       baseSpeed = config.baseGaugeSpeed + (level × config.speedIncreasePerLevel)
        //       if (isFever) speed = baseSpeed × config.feverSpeedMultiplier
        // TODO: isMoving = true
    }
    
    void Update()
    {
        if (!isMoving) return;
        
        // TODO: currentValue += direction × speed × Time.deltaTime
        // TODO: if (currentValue >= 1.0f || currentValue <= 0.0f) direction *= -1
        
        smithingUI.UpdateGauge(currentValue);
    }
    
    public float StopGauge()
    {
        // TODO: isMoving = false
        // TODO: return currentValue
        return 0f;
    }
}
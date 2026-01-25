// Defense/CoreHealth.cs

using UnityEngine;

public class CoreHealth : MonoBehaviour
{
    public static CoreHealth Instance { get; private set; }
    
    private GameConfig config;
    private float currentHealth;
    private float maxHealth;
    
    void Awake()
    {
        Instance = this;
    }
    
    public void Initialize(GameConfig gameConfig)
    {
        config = gameConfig;
        maxHealth = config.coreMaxHealth;
        currentHealth = maxHealth;
    }
    
    void Update()
    {
        // TODO: 자동 회복 (config.coreRegenPerSecond)
    }
    
    public void TakeDamage(float damage)
    {
        // TODO: currentHealth 감소
        // TODO: UI 업데이트
        // TODO: 0 이하 시 GameManager.GameOver() 호출
    }
    
    public float GetHealthPercent()
    {
        return currentHealth / maxHealth;
    }
}
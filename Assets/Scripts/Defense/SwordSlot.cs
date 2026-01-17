// Defense/SwordSlot.cs

using UnityEngine;

public class SwordSlot : MonoBehaviour
{
    private Sword sword;
    private GameConfig config;
    private float attackRange;
    private float attackCooldown;
    private float cooldownTimer = 0f;
    
    [SerializeField] private SwordVisualController visualController;
    
    public void Initialize(GameConfig gameConfig)
    {
        config = gameConfig;
        attackRange = config.swordAttackRange;
        attackCooldown = config.swordAttackCooldown;
    }
    
    public void SetSword(Sword s)
    {
        sword = s;
        // TODO: visualController.Show(sword.level)
    }
    
    void Update()
    {
        if (sword == null) return;
        
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            TryAttack();
            cooldownTimer = attackCooldown;
        }
    }
    
    private void TryAttack()
    {
        // TODO: DefenseManager.GetAllEnemies() 가져오기
        // TODO: attackRange 내 적 필터링
        // TODO: 진행도 가장 높은 적 선택
        // TODO: target.TakeDamage(sword.power)
    }
}
// Defense/SwordSlot.cs

using UnityEngine;

public class SwordSlot : MonoBehaviour
{
    public Sword sword;
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
        visualController.Show(sword.level);
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
        var enemies = GameManager.Instance.defenseManager.GetAllEnemies();
        Enemy target = null;
        float highestProgress = -1;
        // TODO: attackRange 내 적 필터링
        foreach (Enemy enemy in enemies)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            
            if (distance <= attackRange)
            {
        // TODO: 진행도 가장 높은 적 선택
                float progress = enemy.GetProgress();

                if (progress > highestProgress)
                {
                    highestProgress = progress;
                    target = enemy; // 选择当前敌人作为目标
                }
            }
        }
        // TODO: target.TakeDamage(sword.power)
        if (target != null)
        {
            target.TakeDamage(sword.power);
        }
    }
}
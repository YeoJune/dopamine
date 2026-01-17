// Defense/Enemy.cs

using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3[] pathPoints;
    private int currentPointIndex = 0;
    private float health;
    private float damage;
    private float moveSpeed;
    private int goldReward;
    
    public void Initialize(float hp, float dmg, float speed, int gold, Vector3[] path)
    {
        health = hp;
        damage = dmg;
        moveSpeed = speed;
        goldReward = gold;
        pathPoints = path;
        
        transform.position = pathPoints[0];
        GameManager.Instance.defenseManager.RegisterEnemy(this);
    }
    
    public float GetProgress()
    {
        // TODO: currentPointIndex / (pathPoints.Length - 1) 계산
        return 0f;
    }
    
    void Update()
    {
        if (pathPoints == null || currentPointIndex >= pathPoints.Length) return;
        
        // TODO: pathPoints[currentPointIndex] 향해 이동
        // TODO: 도착 시 currentPointIndex++
        // TODO: 마지막 도달 시 AttackCore()
    }
    
    private void AttackCore()
    {
        CoreHealth.Instance.TakeDamage(damage);
        Die();
    }
    
    public void TakeDamage(float dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            Die();
        }
    }
    
    private void Die()
    {
        CurrencyManager.Instance.AddGold(goldReward);
        
        // TODO: 선물상자 드랍 체크 (MVP 제외)
        
        GameManager.Instance.defenseManager.UnregisterEnemy(this);
        Destroy(gameObject);
    }
}
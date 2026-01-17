// Defense/DefenseManager.cs

using UnityEngine;
using System.Collections.Generic;

public class DefenseManager : MonoBehaviour
{
    private GameConfig config;
    private List<SwordSlot> slots = new List<SwordSlot>();
    private List<Enemy> enemies = new List<Enemy>();
    
    [SerializeField] private SwordSlot slotPrefab;
    [SerializeField] private Transform slotsParent;
    [SerializeField] private Vector3[] slotPositions;
    
    public void Initialize(GameConfig gameConfig)
    {
        config = gameConfig;
    }
    
    public void PlaceSword(Sword sword)
    {
        // TODO: SwordSlot 생성 및 SetSword
        // TODO: slots 리스트에 추가
        // TODO: 전투력 내림차순 정렬
        // TODO: 위치 재배치
        // TODO: maxSwordSlots 초과 시 최하위 삭제
    }
    
    public List<Enemy> GetAllEnemies()
    {
        return enemies;
    }
    
    public void RegisterEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
    }
    
    public void UnregisterEnemy(Enemy enemy)
    {
        enemies.Remove(enemy);
    }
}
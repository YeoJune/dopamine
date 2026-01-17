// Core/GameConfig.cs

using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Config/Game")]
public class GameConfig : ScriptableObject
{
    [Header("Sword Power: base × multiplier^level")]
    public float basePower = 100f;
    public float powerMultiplier = 1.25f;
    
    [Header("Gauge Speed: base + (level × increase) [× feverMult]")]
    public float baseGaugeSpeed = 1f;
    public float speedIncreasePerLevel = 0.1f;
    public float feverSpeedMultiplier = 2f;
    
    [Header("Gauge Zones")]
    [Range(0, 1)] public float yellowZoneStart = 0.3f;
    [Range(0, 1)] public float yellowZoneEnd = 0.5f;
    [Range(0, 1)] public float redZoneStart = 0.7f;
    [Range(0, 1)] public float redZoneEnd = 0.9f;
    
    [Header("Hammer Sequence")]
    public int baseHammerCount = 3;
    public int longHammerCount = 7;
    public float hammerSoundInterval = 0.3f;
    [Range(0, 1)] public float baseLongChance = 0.3f;
    [Range(0, 1)] public float redZoneLongBonus = 0.2f;
    public int highLevelThreshold = 5;
    [Range(0, 1)] public float highLevelLongBonus = 0.1f;
    
    [Header("Result Probability")]
    [Range(0, 1)] public float baseGreatSuccessChance = 0.5f;
    [Range(0, 1)] public float basePlusTwoChance = 0.2f;
    [Range(0, 1)] public float basePlusThreeChance = 0.05f;
    
    [Header("Fever")]
    public int feverTriggerCount = 3;
    public float feverDuration = 30f;
    [Range(0, 1)] public float feverDestroyReduction = 0.5f;
    
    [Header("Core")]
    public float coreMaxHealth = 100f;
    public float coreRegenPerSecond = 1f;
    
    [Header("Grid & Sword")]
    public int gridSize = 10;
    public int maxSwordSlots = 10;
    public float swordAttackRange = 999f;
    public float swordAttackCooldown = 1f;
    
    [Header("Danger")]
    [Range(0, 1)] public float dangerThreshold = 0.75f;
    [Range(0, 1)] public float dangerSuccessBonus = 0.2f;
    [Range(0, 1)] public float dangerDestroyBonus = 0.2f;
}
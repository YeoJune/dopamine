// Upgrade/UpgradeData.cs

using UnityEngine;

public enum UpgradeType
{
    ZoneExpansion,
    GreatSuccessBonus,
    StartLevel
}

[CreateAssetMenu(fileName = "Upgrade", menuName = "Config/Upgrade")]
public class UpgradeData : ScriptableObject
{
    public string upgradeName;
    [TextArea] public string description;
    public UpgradeType type;
    
    [Header("Cost: baseCost × costMultiplier^currentLevel")]
    public int baseCost = 100;
    public float costMultiplier = 1.5f;
    public int maxLevel = 10;
    
    [Header("Effect Per Level")]
    public float yellowZoneIncreasePerLevel = 0.05f;
    public float redZoneIncreasePerLevel = 0.03f;
    [Range(0, 1)] public float greatSuccessChancePerLevel = 0.05f;
    [Range(0, 1)] public float plusTwoChancePerLevel = 0.02f;
    [Range(0, 1)] public float plusThreeChancePerLevel = 0.01f;
    public int startLevelBonusPerLevel = 1;
    
    public int GetCost(int currentLevel)
    {
        return Mathf.RoundToInt(baseCost * Mathf.Pow(costMultiplier, currentLevel));
    }
    
    public bool CanUpgrade(int currentLevel)
    {
        return currentLevel < maxLevel;
    }
}
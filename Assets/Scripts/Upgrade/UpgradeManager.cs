// Upgrade/UpgradeManager.cs

using UnityEngine;
using System.Collections.Generic;

public class UpgradeManager : MonoBehaviour
{
    [SerializeField] private List<UpgradeData> availableUpgrades;
    private Dictionary<UpgradeData, int> upgradeLevels = new Dictionary<UpgradeData, int>();
    
    public void Initialize()
    {
        foreach (var upgrade in availableUpgrades)
        {
            upgradeLevels[upgrade] = 0;
        }
    }
    
    public void PurchaseUpgrade(UpgradeData upgrade)
    {
        // TODO: GetCost() 계산
        // TODO: CurrencyManager.SpendGold() 호출
        // TODO: upgradeLevels[upgrade]++
    }
    
    public float GetYellowZoneBonus()
    {
        // TODO: type == ZoneExpansion인 업그레이드들의 yellowZoneIncreasePerLevel × level 합산
        return 0f;
    }
    
    public float GetRedZoneBonus()
    {
        // TODO: redZoneIncreasePerLevel × level 합산
        return 0f;
    }
    
    public float GetGreatSuccessBonus()
    {
        // TODO: type == GreatSuccessBonus인 업그레이드들의 greatSuccessChancePerLevel × level 합산
        return 0f;
    }
    
    public float GetPlusTwoBonus()
    {
        // TODO: plusTwoChancePerLevel × level 합산
        return 0f;
    }
    
    public float GetPlusThreeBonus()
    {
        // TODO: plusThreeChancePerLevel × level 합산
        return 0f;
    }
    
    public int GetStartLevelBonus()
    {
        // TODO: type == StartLevel인 업그레이드들의 startLevelBonusPerLevel × level 합산
        return 0;
    }
}
// Upgrade/UpgradeUI.cs

using UnityEngine;
using UnityEngine.UI;

public class UpgradeUI : MonoBehaviour
{
    private UpgradeManager upgradeManager;
    
    [SerializeField] private Transform upgradeListParent;
    [SerializeField] private GameObject upgradeItemPrefab;
    
    void Start()
    {
        upgradeManager = GameManager.Instance.upgradeManager;
        // TODO: upgradeManager.availableUpgrades 순회하며 UI 생성
    }
    
    public void OnBuyButtonClick(UpgradeData upgrade)
    {
        upgradeManager.PurchaseUpgrade(upgrade);
        // TODO: UI 업데이트 (비용, 레벨)
    }
}
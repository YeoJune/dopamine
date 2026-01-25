// Defense/DefenseUI.cs

using UnityEngine;
using UnityEngine.UI;

public class DefenseUI : MonoBehaviour
{
    private DefenseManager defenseManager;
    
    [SerializeField] private Image coreHealthBar;
    [SerializeField] private Transform swordListParent;
    
    void Start()
    {
        defenseManager = GameManager.Instance.defenseManager;
    }
    
    void Update()
    {
        // TODO: coreHealthBar.fillAmount = CoreHealth.Instance.GetHealthPercent()
        if (CoreHealth.Instance != null)
        {
            coreHealthBar.fillAmount = CoreHealth.Instance.GetHealthPercent();
        }
    }
    
    public void AddSwordToList(Sword sword)
    {
        // TODO: swordListParent에 UI 아이템 추가
      
    }
}
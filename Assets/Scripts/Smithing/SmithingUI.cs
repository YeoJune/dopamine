// Smithing/SmithingUI.cs

using UnityEngine;
using UnityEngine.UI;

public class SmithingUI : MonoBehaviour
{
    private SmithingManager smithingManager;
    
    [SerializeField] private Image gaugeBar;
    [SerializeField] private Text levelText;
    [SerializeField] private Button smithingButton;
    [SerializeField] private Button placeButton;
    [SerializeField] private Image dangerWarning;
    
    void Start()
    {
        smithingManager = GameManager.Instance.smithingManager;
        smithingButton.onClick.AddListener(() => smithingManager.StartSmithing()); // 추가
        placeButton.onClick.AddListener(() => smithingManager.PlaceCurrentSword()); // 추가
    }
    
    public void UpdateGauge(float value)
    {
        // TODO: gaugeBar.fillAmount = value
    }
    
    public void UpdateLevelText(int level)
    {
        // TODO: levelText.text = level + "강"
    }
    
    public void ShowDangerWarning(bool show)
    {
        // TODO: dangerWarning 점멸 애니메이션
        // (Coroutine):
        // if (show) StartCoroutine(BlinkCoroutine());
        // else StopAllCoroutines();
    }
    
    public void ShowFeverEffect()
    {
        // TODO: 게이지 전체 빨간색 이펙트
    }
    
    public void HideFeverEffect()
    {
        // TODO: 이펙트 제거
    }
    
    public void ShowResult(SmithingResultType type, int levelIncrease)
    {
        // TODO: 결과 팝업 표시
    }
}
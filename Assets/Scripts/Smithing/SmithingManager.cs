// Smithing/SmithingManager.cs

using UnityEngine;

public class SmithingManager : MonoBehaviour
{
    private GameConfig config;
    private UpgradeManager upgradeManager;
    private Sword currentSword;
    private bool isDanger = false;
    
    [SerializeField] private GaugeController gaugeController;
    [SerializeField] private HammerSequence hammerSequence;
    [SerializeField] private FeverSystem feverSystem;
    
    public void Initialize(GameConfig gameConfig)
    {
        config = gameConfig;
        upgradeManager = GameManager.Instance.upgradeManager;
        CreateNewSword();
    }
    
    public void CreateNewSword()
    {
        int startLevel = upgradeManager.GetStartLevelBonus();
        currentSword = new Sword(startLevel, config);
    }
    
    public void SetDanger(bool danger)
    {
        isDanger = danger;
    }
    
    public void StartSmithing()
    {
        // TODO: gaugeController.StartGauge(currentSword.level, feverSystem.IsFeverActive())
    }
    
    public void OnGaugeStop(float value)
    {
        var result = SmithingResult.Evaluate(value, currentSword.level, isDanger, 
                                              feverSystem.IsFeverActive(), config, upgradeManager);
        // TODO: hammerSequence.Play() 호출
    }
    
    private void ApplyResult(SmithingResult.Result result)
    {
        // TODO: result.type에 따라 레벨 증가 또는 파괴 처리
        // TODO: FeverSystem에 결과 전달
        // TODO: UI 업데이트
    }
    
    public void PlaceCurrentSword()
    {
        // TODO: DefenseManager.PlaceSword() 호출
        // TODO: CreateNewSword() 호출
    }
    
    public void OnFeverActivated()
    {
        // TODO: UI 피버 이펙트 표시
    }
    
    public void OnFeverDeactivated()
    {
        // TODO: UI 피버 이펙트 숨김
    }
}
// Core/GameManager.cs

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    [SerializeField] private GameConfig config;
    
    public SmithingManager smithingManager;
    public DefenseManager defenseManager;
    public UpgradeManager upgradeManager;
    public CurrencyManager currencyManager;
    public DangerSystem dangerSystem;
    public FeverSystem feverSystem;
    
    private bool isDanger = false;
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        InitializeManagers();
    }
    
    private void InitializeManagers()
    {
        if (config == null)
        {
            Debug.LogError("GameConfig is not assigned!");
            return;
        }
        
        // Initialize all managers in proper order
        if (currencyManager != null) currencyManager.Initialize();
        if (upgradeManager != null) upgradeManager.Initialize(config);
        if (smithingManager != null) smithingManager.Initialize(config);
        if (defenseManager != null) defenseManager.Initialize(config);
        if (dangerSystem != null) dangerSystem.Initialize(config);
        if (feverSystem != null) feverSystem.Initialize(config);
        
        Debug.Log("Game initialized successfully!");
    }
    
    public GameConfig GetConfig()
    {
        return config;
    }
    
    public void OnDangerChanged(bool danger)
    {
        isDanger = danger;
        smithingManager.SetDanger(danger);
        // TODO: SmithingUI 경고 표시
    }
    
    public void GameOver()
    {
        // TODO: 게임오버 UI 표시
        // TODO: 랭킹 저장 (MVP 제외)
    }
}
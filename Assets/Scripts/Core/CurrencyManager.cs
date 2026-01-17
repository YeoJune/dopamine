// Core/CurrencyManager.cs

using UnityEngine;
using System;

public class CurrencyManager : MonoBehaviour
{
    public static CurrencyManager Instance { get; private set; }
    
    private int currentGold = 0;
    public event Action<int> OnGoldChanged;
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void Initialize()
    {
        currentGold = 0;
        Debug.Log("CurrencyManager initialized with 0 gold");
    }
    
    public int GetGold() => currentGold;
    
    public void AddGold(int amount)
    {
        if (amount < 0)
        {
            Debug.LogWarning($"Attempted to add negative gold: {amount}");
            return;
        }
        
        currentGold += amount;
        OnGoldChanged?.Invoke(currentGold);
        Debug.Log($"Gold added: +{amount} (Total: {currentGold})");
    }
    
    public bool SpendGold(int amount)
    {
        if (amount < 0)
        {
            Debug.LogWarning($"Attempted to spend negative gold: {amount}");
            return false;
        }
        
        if (currentGold < amount)
        {
            Debug.Log($"Not enough gold! Required: {amount}, Current: {currentGold}");
            return false;
        }
        
        currentGold -= amount;
        OnGoldChanged?.Invoke(currentGold);
        Debug.Log($"Gold spent: -{amount} (Remaining: {currentGold})");
        return true;
    }
}
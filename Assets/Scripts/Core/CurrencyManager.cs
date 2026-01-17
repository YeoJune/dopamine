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
        Instance = this;
    }
    
    public int GetGold() => currentGold;
    
    public void AddGold(int amount)
    {
        // TODO: 골드 증가 및 이벤트 발생
    }
    
    public bool SpendGold(int amount)
    {
        // TODO: 골드 충분한지 체크 후 차감
        return false;
    }
}
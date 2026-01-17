// Smithing/HammerSequence.cs

using UnityEngine;
using System;
using System.Collections;

public class HammerSequence : MonoBehaviour
{
    private GameConfig config;
    
    public void Initialize(GameConfig gameConfig)
    {
        config = gameConfig;
    }
    
    public void Play(int hammerCount, Action onComplete)
    {
        StartCoroutine(PlaySequence(hammerCount, onComplete));
    }
    
    private IEnumerator PlaySequence(int count, Action callback)
    {
        // TODO: count번 반복하며 AudioManager.Play("Hammer") 호출
        // TODO: config.hammerSoundInterval만큼 대기
        // TODO: 완료 후 callback 호출
        yield return null;
    }
}
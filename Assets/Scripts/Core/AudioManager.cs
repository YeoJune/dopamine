// Core/AudioManager.cs

using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    
    void Awake()
    {
        Instance = this;
    }
    
    public void Play(string soundName)
    {
        // TODO: 사운드 재생 (레거시)
    }
}
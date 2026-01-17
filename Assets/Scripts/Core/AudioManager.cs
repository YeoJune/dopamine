// Core/AudioManager.cs

using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    
    [SerializeField] private AudioSource audioSource;
    
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
        
        // Get or add AudioSource component
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
        }
    }
    
    public void Play(string soundName)
    {
        // Legacy: Simple sound playback
        // For MVP, just log the sound name
        // Can be extended with AudioClip dictionary later
        Debug.Log($"[Audio] Playing sound: {soundName}");
        
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
    }
}
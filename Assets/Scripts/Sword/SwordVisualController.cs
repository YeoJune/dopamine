// Sword/SwordVisualController.cs

using UnityEngine;

public class SwordVisualController : MonoBehaviour
{
    [SerializeField] private ParticleSystem levelUpEffect;
    
    public void Show(int level)
    {
        // TODO: 레벨에 따른 이펙트 변경
    }
    
    public void PlayLevelUpEffect()
    {
        // TODO: levelUpEffect.Play()
    }
}
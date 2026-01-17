// Defense/WavePattern.cs

using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "WavePattern", menuName = "Config/WavePattern")]
public class WavePattern : ScriptableObject
{
    [System.Serializable]
    public class Wave
    {
        public float spawnTime;
        public int enemyCount;
        public float enemyHealth;
        public float enemyDamage;
        public float moveSpeed;
        public int goldReward;
    }
    
    public List<Wave> waves;
    
    [Header("Infinite Scaling: base × multiplier^iteration")]
    public bool infiniteScaling = true;
    public float healthScalingMultiplier = 1.2f;
    public float damageScalingMultiplier = 1.15f;
    public float goldScalingMultiplier = 1.1f;
    public int enemyCountIncrement = 1;
}
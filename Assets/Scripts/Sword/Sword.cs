// Sword/Sword.cs

using UnityEngine;

public class Sword
{
    public int level;
    public float power;
    
    public Sword(int level, GameConfig config)
    {
        this.level = level;
        power = config.basePower * Mathf.Pow(config.powerMultiplier, level);
    }
}
using System;

///<summary>
/// Player class
/// </summary>
public class Player
{
    string name { get; set; }
    float maxHp { get; set; }
    float hp { get; set; }

    /// <summary>
    /// player constructor
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp < 1)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
            this.hp = maxHp;
        }
        else
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
    }

    /// <summary>
    /// print health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// take damage
    /// </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// heal damage
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// validate hp
    /// </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            newHp = 0;
        }
        if (newHp > maxHp)
        {
            newHp = maxHp;
        }
        hp = newHp;
    }

    /// <summary>
    /// apply modifier
    /// </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if ((int) modifier == 0)
        {
            baseValue = baseValue / 2;
        }
        if ((int) modifier == 2)
        {
            baseValue = baseValue + (baseValue / 2);
        }
        return (baseValue);
    }
}

/// <summary>
/// damage delegate
/// </summary>
public delegate void CalculateHealth(float dmg);

/// <summary>
/// modifiers
/// </summary>
public enum Modifier
{
    /// <summary>
    /// half strength
    /// </summary>
    Weak,
    /// <summary>
    /// normal strength
    /// </summary>
    Base,
    /// <summary>
    /// plus %50 strenght
    /// </summary>
    Strong
}

/// <summary>
/// delegate with modifier
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
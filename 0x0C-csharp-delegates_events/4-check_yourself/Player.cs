using System;

///<summary>
/// Player class
/// </summary>
public class Player
{
    string name { get; set; }
    float maxHp { get; set; }
    float hp { get; set; }

    EventHandler<CurrentHPArgs> HPCheck;
    private string status { get; set; }

    /// <summary>
    /// damage delegate
    /// </summary>
    public delegate void CalculateHealth(float dmg);

    /// <summary>
    /// player constructor
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
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
        this.status = name + " is ready to go!";
        this.HPCheck += CheckStatus;
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
        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    /// <summary>
    /// apply modifier
    /// </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if ((int) modifier == 0)
        {
            baseValue = baseValue / 2f;
        }
        if ((int) modifier == 2)
        {
            baseValue = baseValue * 1.5f;
        }
        return (baseValue);
    }

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            this.status = name + " is in perfect health!";
        }
        else if (e.currentHp >= maxHp * 0.5f)
        {
            this.status = name + " is doing well!";
        }
        else if (e.currentHp >= maxHp * 0.25f)
        {
            this.status = name + " isn't doing too great...";
        }
        else if (e.currentHp > 0)
        {
            this.status = name + " needs help!";
        }
        else
        {
            this.status = name + " is knocked out!";
        }
        Console.WriteLine(status);
    }
}

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
    /// plus %50 strength
    /// </summary>
    Strong
}

/// <summary>
/// delegate with modifier
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// HP args
/// </summary>
class CurrentHPArgs : EventArgs
{
    public float currentHp { get; set; }

    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}
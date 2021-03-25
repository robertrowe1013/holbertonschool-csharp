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
}
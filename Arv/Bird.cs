using System;

namespace Arv;

public class Bird : Animal
{
    public bool IsMigratory { get; set; } = false;

    public Bird(string name, int age, double weight, string color, bool isAlive, bool isMigratory) : base(name, age, weight, color, isAlive)
    {
        IsMigratory = isMigratory;
    }

    public void CheckMigration()
    {
        if (IsMigratory)
        {
            Console.WriteLine("The bird migrates to warmer regions.");
        }
        else
        {
            Console.WriteLine("The bird stays in the same region all year.");
        }
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying..");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} chirps!");
    }
}

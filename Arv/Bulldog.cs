using System;

namespace Arv;

public class Bulldog : Dog
{
    public bool IsHungry { get; set; }

    public Bulldog(string name, int age, double weight, string color, bool isAlive, string breed, bool isHungry) : base(name, age, weight, color, isAlive, breed)
    {
        IsHungry = isHungry;
    }

    public void Breathing()
    {
        if (IsAlive)
        {
            Console.WriteLine($"{Name} is breathing.");
        }
        else
        {
            Console.WriteLine($"{Name} is dead -_-");
        }
    }

    public void HungryStatus()
    {
        if (IsHungry)
        {
            Eat();
        }
        else
        {
            Console.WriteLine($"{Name} is not hungry");
        }
    }
}

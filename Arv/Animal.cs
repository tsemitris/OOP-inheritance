using System;

namespace Arv;

public class Animal
{
    public string Name { get; set; } = "Unknown";
    public int Age { get; set; } = 0;
    public double Weight { get; set; } = 0;
    public string Color { get; set; } = "Unknown";
    public bool IsAlive { get; set; } = false;

    public Animal(string name, int age, double weight, string color, bool isAlive)
    {
        Name = name;
        Age = age;
        Weight = weight;
        Color = color;
        IsAlive = isAlive;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating..");
    }

    public void Sleep()
    {
        Console.WriteLine($"Be quiet! {Name} is sleeping.");
    }

    public void Move()
    {
        Console.WriteLine($"{Name} is moving.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("No animal make sound.");
    }
}

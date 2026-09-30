using System;

namespace Arv;

public class Chihuahua : Dog
{
    public bool IsCold { get; set; }

    public Chihuahua(string name, int age, double weight, string color, bool isAlive, string breed, bool isCold) : base(name, age, weight, color, isAlive, breed)
    {
        IsCold = isCold;
    }

    public void Shake()
    {
        if (IsCold)
        {
            Console.WriteLine($"{Name} is shaking cause is cold");
        }
        else
        {
            Console.WriteLine($"{Name} is not shaking.");
        }
    }

}

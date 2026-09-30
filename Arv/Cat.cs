using System;

namespace Arv;

public class Cat : Animal
{
    public bool LikesToClimb { get; set; } = true;
    public Cat(string name, int age, double weight, string color, bool isAlive, bool likesToClimb) : base(name, age, weight, color, isAlive)
    {
        LikesToClimb = likesToClimb;
    }


    public void Climb()
    {
        if (LikesToClimb)
        {
            Console.WriteLine($"{Name} is climbing");
        }
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} meows.");
    }
}

using System;

namespace Arv;

public class Dog : Animal
{
    public string Breed { get; set; } = "Golden retriever";

    public Dog(string name, int age, double weight, string color, bool isAlive, string breed) : base(name, age, weight, color, isAlive)
    {
        Breed = breed;
    }

    public void Train()
    {
        Console.WriteLine($"{Name}, a {Breed} is training");
    }

    public override void MakeSound()
    {
        if (IsAlive)
        {
            Console.WriteLine($"{Name} barks: woof.");
        }
        else
        {
            Console.WriteLine($"{Name} can't barks cause it's dead.");
        }
    }
}

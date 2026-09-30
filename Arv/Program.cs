namespace Arv;

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Oskar", 2, 30, "White", true, "Poodle");
        Bulldog myBulldog = new Bulldog("Diesel", 3, 30, "Brown", false, "Bulldog", false);
        Chihuahua myChihuahua = new Chihuahua("Lucy", 2, 10, "White", true, "Chihuahua", true);

        Cat myCat = new Cat("Leo", 3, 20, "Black", true, true);
        Bird myBird = new Bird("Mango", 1, 3, "Red, Blue, Green", true, true);

        myDog.MakeSound();
        myBulldog.MakeSound();
        myChihuahua.MakeSound();
        myCat.MakeSound();
        myBird.MakeSound();
    }
}

namespace demoHeritage.Classes;

public class Chien : Animal
{
    public Chien(string name, int age, string color) : base(name, age, color)
    {
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} is barking");
    }
}
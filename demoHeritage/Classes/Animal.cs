namespace demoHeritage.Classes;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }

    public Animal(string name, int age, string color)
    {
        Name = name;
        Age = age;
        Color = color;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping");
    }

    public void Move()
    {
        Console.WriteLine($"{Name} is moving");
    }
}
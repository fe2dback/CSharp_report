class Dog : Animal
{
    public string Color { get; set; }
    public void Bark()
    {
        base.Eat();
    }
}

class Animal
{
    public void Eat()
    {
        Console.WriteLine("eat");
    }
    public void Sleep()
    {
        Console.WriteLine("sleep");
    }
}

class main
{
    static void Main(string[] args)
    {
        List<Animal> list = new List<Animal>();
        {
            new Dog();
        }
        foreach (Animal a in list)
        {
            Console.WriteLine(a.ToString());
        }
    }
}

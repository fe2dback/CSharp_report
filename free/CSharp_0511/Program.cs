using CSharp_0511;

class Program
{

    
    

    static void Main(string[] args)
    { 
        Box box = new Box();
        box.Id = 5;
        //box.id = 5; error
        Console.WriteLine(box.area(3.5f, 3f));

    }
}
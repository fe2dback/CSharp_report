
interface ICar
{
    void Translate();
    void Rotate();
}


class HyunDai : ICar
{
    public String name = "Avante";

    public void Rotate()
    {
        Console.WriteLine("Rotate");
    }

    public void Translate()
    {
        Console.WriteLine("Move");
    }
}

class Tesla : ICar
{
    public String name = "Model3";

    public void Rotate()
    {
        Console.WriteLine("Rotate");
    }
    public void Translate()
    {
        Console.WriteLine("Move");
    }

    public void SelfDriving()
    {
        Console.WriteLine("FSD");
    }
}


class Program_0
{
    /*
    static void Main(string[] args)
    {
        HyunDai avante = new HyunDai();
        Tesla model3 = new Tesla();
        Tesla modelX = new Tesla();


        avante.Translate();
        model3.Translate();
        modelX.Translate();
        modelX.SelfDriving();
    }
    */
}

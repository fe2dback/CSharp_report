delegate void MyDel(int a, int b);

class abc
{
    static void Main(string[] args)
    {
        MyDel mydel1, mydel2;


        mydel1 = (a, b) => { Console.WriteLine(a + b); };
        mydel2 = (a, b) => { Console.WriteLine(a - b); };

        mydel1 = mydel1 + mydel2;
        mydel1 = mydel1 - mydel2;

        mydel1(5, 3);

    }

    
}

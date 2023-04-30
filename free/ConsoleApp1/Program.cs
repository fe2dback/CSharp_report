namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(fact(10));
        }
        static int Add(int a, int b)
        {
            int R = a + b;
            return R;
        }
        static int Add(int a, int b, int c)
        {
            int R = a + b + c;
            return R;
        }
        static int Add(int a, int b, int c, int d)
        {
            int R = a + b + c + d;
            return R;
        }
        static int fact(int x)
        {
            
            int sum = fact(x-1) * fact(x);
            x--;
            return sum;
        }

        

    }
}
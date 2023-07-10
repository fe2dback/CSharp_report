using System.Diagnostics;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            string text = Console.ReadLine();

            compare(text);
        }
    }

    static void compare(string text)
    {
        char[] type = new char[text.Length];
        bool odd = false;
        bool even = false;

        if (text.Length % 2 == 0)
        {
            even = true;
        }
        else
        {
            odd = true;
        }

        for (int i = 0; i < type.Length; i++)
        {
            type[i] = text[i];
        }

        if (even == true)
        {
            int i = 0;
            while (i < type.Length / 2)
            {
                if (type[i] == type[type.Length - 1 - i])
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            Console.WriteLine("true");
            even = false;
        }

        if (odd == true)
        {
            int i = 0;
            while (i < type.Length / 2)
            {
                if (type[i] == type[type.Length - 1 - i])
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            Console.WriteLine("true");
            odd = false;
        }

    }
}
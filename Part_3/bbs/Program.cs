using System;
class bubbbbbbblesort
{
    static void Main(string[] args)
    {
        int size = 10;
        int[] numbers = new int[size];
        make_nums(size, numbers);
    }

    static void sort(int[] number)
    {
        int n = number.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (number[j] > number[j + 1])
                {
                    int temp = number[j];
                    number[j] = number[j + 1];
                    number[j + 1] = temp;
                }
            }
        }
        foreach(int num in number)
        {
            Console.WriteLine(num);
        }
    }

    static void make_nums(int size, int[] numbers)
    {
        Random random = new Random();
        for(int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(0,99);    
        }
        sort(numbers);

    }
}
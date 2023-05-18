namespace D0518
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pow();
            //star();
            //addnum();
            //min();
            //arr();
            //NN();
            /*
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            bool choice = compareS(str1, str2);
            Console.WriteLine(choice);
            */
            //strP();
            //lotto_A();
            lotto_L();
        }

        static void pow()
        {
            int sum = 0;
            for(int i = 0;i < 11;i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
                sum += (int)result;
            }
            Console.WriteLine("sum : {0}", sum);
        }

        static void star()
        {
            Random r = new Random();

            Console.Clear();

            for(int i = 0; i < 20; i++)
            {
                int x = r.Next(30);
                int y = r.Next(20);
                Console.SetCursorPosition(x, y);    
                Console.WriteLine("*");
                Thread.Sleep(300);
            }
        }
        
        static void addnum()
        {
            int sum = 0;
            while(true)
            {
                int num = int.Parse(Console.ReadLine());
                if(num == 0)
                {
                    break;
                }
                else
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);
        }

        static void min()
        {
            int[] nums = new int[] {33,5,9,23,4,6};
            int temp = nums[0];
            for (int i = 0; i<nums.Length;i++)
            {
                
                if(temp > nums[i])
                {
                    temp = nums[i];
                }
            }
            Console.WriteLine(temp);
        }
        static void arr()
        {
            int[] arr = new int[5];
            for(int i = 0 ; i<arr.Length ; i++)
            {
                arr[i] = i + 1;
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void NN()
        {
            int R = int.Parse(Console.ReadLine());
            int sum = 1, n = 1;
            while(sum < R)
            {
                n++;
                sum += n;
                
            }
            Console.WriteLine(n-1);
        }

        static bool compareS(string str1, string str2)
        {
            

            if(str1.Length == str2.Length)
            {
                for(int i = 0; i < str1.Length ; i++)
                {
                    if (str1[i] == str2[i])
                    {
                        i++;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
            return true;
            
        }

        static void numtonum()
        {
            int in1 = int.Parse(Console.ReadLine());
            int in2 = int.Parse(Console.ReadLine());

            for(int i =  in1; i < in2; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void strP()
        {
            string[] animal = new string[]{"Cat", "Dog", "Horse"};
            
            string animals = string.Join(":", animal);
            
            Console.WriteLine(animals);

            string animalsUp = animals.ToUpper();

            Console.WriteLine(animals);
            
            string[] str = animalsUp.Split(':');
            
            foreach(var item in str)
            {
                Console.WriteLine(item);
            }
        }
        static int[] num = new int[6];
        static void lotto_A()
        {
            

            Random r = new Random();

            for(int i = 0; i < 6; i++)
            {
                num[i] = r.Next(45) + 1;

                bool c = Checknum(num[i], i);
                if(c == true)
                {
                    Console.WriteLine(num[i]);
                }
                else
                {
                    i--;
                }
            }
        }
        static bool Checknum(int v, int j)
        {
            for(int i = 0; i < j; i++)
            {
                if(v == num[i])
                {
                    return false;
                }
            }
            return true;
        }

        static void lotto_L()
        {
            Random r = new Random();
            List<int> lotto = new List<int>();

            for(int i = 1; i < 45; i++)
            {
                lotto.Add(i);
            }

            for(int i = 0; i < 6; i++)
            {
                int temp = r.Next(lotto.Count)+1;
                Console.WriteLine(lotto[temp]);
                lotto.Remove(lotto[temp]);
            }
            /*
            foreach(var item in lotto)
            {
                Console.WriteLine(item);
            }*/
        }
    }
}
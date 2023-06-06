using System.Runtime.CompilerServices;

namespace mid
{
    class Program
    {
        static void Main(string[] args)
        {
            //num1();
            //num2();
            //num3();
            //num4();
            //num5();
            //num6();
            //num7();
            //num8();
            //num9();
            //num10();
            //num11();
            //int[] number = new int[] { 14, 22, 73, 44 }; 
            //num12(number);
            //num13();
            //num14();
            //num15();
            //num16();
            //num17();
            //num18();
            //num18_1();
        }


        //넓이와 폭을 입력받아 사각형의 넓이구하기
        static void num1()
        {
            int weight = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(weight * height);
        }


        //시간을입력받아 일과 시간 구하기
        static void num2()
        {
            int hour = int.Parse(Console.ReadLine());
            int days = hour/24;
            int hours = hour%24;
            Console.WriteLine($"{days}일 {hours}시");
        }


        //반복문으로 삼각형 별찍기
        static void num3()
        {
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write("b");

                }
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        //랜덤으로 1, 3, 5, 7, 9 출력
        static void num4()
        {
            Random random = new Random();
            int num = random.Next(0, 4)*2+1;
            Console.WriteLine(num);
        }


        //0이아니면 받은숫자를 계속더하기
        static void num5()
        {
            int num = 0;
            int add = 0;
            while (true)
            {

                num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                add += num;
            }
            Console.WriteLine(add);

        }


        //배열 11칸에 입력받은 x 부터 y까지 저장하기
        static void num6()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }


            /*foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }*/
        }


        //클래스를만들고 x,y속성을 가지게한뒤 인스턴스생성
        static void num7()
        {
            Point point = new Point();
            point.x = 10;
            point.y = 10;
        }


        //리스트를 초기화하고 값을 저장하기
        static void num8()
        {
            List<int> numbers = new List<int>() { 12, 32, 65, 76, 123 };
            numbers.Remove(32);
            numbers.Remove(65);
            numbers.Add(66);
            /*foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }*/
        }


        //2의 0승부터 10승까지 출력/합
        static void num9()
        {
            int add = 0;
            for (int i = 0; i< 10; i++)
            {
                add += (int)Math.Pow(2, i);
            }
            Console.WriteLine(add);
        }


        //30 * 20 화면에 랜덤하게 0.3초 간격으로 20개의 '*' 이 출려되는 프로그램
        static void num10()
        {
            Random random = new Random();
            int x = 0;
            int y = 0;
            for (int i = 0; i < 20; i++)
            {
                x = random.Next(0, 30);
                y = random.Next(0, 20);
                Console.SetCursorPosition(x, y);
                Console.Write("*");
                Thread.Sleep(300);
            }
        }


        //입력받은 값이 0이아니면 더한값을 계속 출력
        static void num11()
        {
            int add = 0;
            int num = 0;
            while (true)
            {
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                add += num;
                Console.WriteLine(add);
            }
        }


        //최소값 구하기
        static void num12(int[] numbers)
        {
            int temp = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (temp > numbers[i])
                {
                    temp = numbers[i];
                }
            }
            Console.WriteLine(temp);
        }

        //전역변수로 배열받기
        static int[] num = new int[5];
        static void num13()
        {
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = i+1;
            }
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
        }


        //최대 자연수 찾기
        static void num14()
        {
            int sum = 1;
            int n = 1;
            int r = int.Parse(Console.ReadLine());

            while (sum < r)
            {
                n++;
                sum += n;
            }
            Console.WriteLine(n-1);
        }

        //문자열 받고 동일한지 체크
        static void num15()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            bool choice = compare(str1, str2);
            Console.WriteLine(choice);
        }

        static bool compare(string str1, string str2)
        {
            if(str1.Length == str2.Length)
            {
                for(int i = 0; i < str2.Length; i++)
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

            
        }

        //x,y 값을받고 사이의 값을출력 x < y
        static void num16()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            for(int i = x; i < y+1; i++)
            {
                Console.WriteLine(i);
            }
        }

        //string split
        static void num17()
        {
            string[] animal = new string[] { "cat", "dog", "hores" };
            string animals = string.Join(":", animal);

            Console.WriteLine(animals);

            string animalsUp = animals.ToUpper();

            Console.WriteLine(animalsUp);

            string[] str = animalsUp.Split(':');

            foreach(var item in str)
            {
                Console.WriteLine(item);
            }
        }
        //중복제거 로또 prof
        static void num18_1()
        {
            Random r = new Random();
            List<int> lotto = new List<int>();

            for(int i = 1; i < 45; i++)
            {
                lotto.Add(i);
            }

            for(int i = 0; i < 6; i++)
            {
                int temp = r.Next(lotto.Count) + 1;
                Console.WriteLine(lotto[temp]);
                lotto.Remove(lotto[temp]);
            }
            /*
            foreach(var item in lotto)
            {
                Console.WriteLine(item);
            }*/
        }

        //중복제거 로또 fe
        static void num18()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            List<int> lotto = new List<int>();
            int num = 0;
            for (int i = 1; i < 46; i++)
            {
                numbers.Add(i);
            }
            while (true)
            {
                num = numbers[random.Next(numbers.Count)];

                if (!lotto.Contains(num))
                {
                    lotto.Add(num);
                    if (lotto.Count == 6)
                    {
                        break;
                    }
                }
            }

            foreach (int i in lotto)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Point
    {
        public int x;
        public int y;
    }

}
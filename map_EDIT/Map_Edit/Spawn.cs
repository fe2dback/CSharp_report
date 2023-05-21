using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_Edit
{
    class Spawn
    {
        static int Float = 5;
        static int size_x = 60;
        static int size_y = 10;
        static int[,] ground = new int[size_x, size_y];
        static bool[,] ground_check = new bool[size_x, size_y];
        static bool[,] fly = new bool[size_x, size_y];

        public void Manager()
        {
            spawn_floor(size_x, size_y);
            

            for (int i = 0; i < 3; i++)
            {

                spawn_block();

            }


        }
        #region player_move
        static void player_move()
        {
            Console.SetCursorPosition(10, Float);

            ConsoleKeyInfo key = Console.ReadKey();
            

            if (key.Key == ConsoleKey.Spacebar)
            {
                int h = 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(10, Float-i);
                    Console.Write(" ");
                    Console.SetCursorPosition(10, Float-i-1);
                    Console.Write("P");
                    Thread.Sleep(30);
                    h++;
                }
                for (int i = h; i > 0; i--)
                {
                    Console.SetCursorPosition(10, h-i);
                    Console.Write(" ");
                    Console.SetCursorPosition(10, h-i+1);
                    Console.Write("P");

                    Thread.Sleep(30);
                }
            }
            else
            {
                return;
            }


        }
        #endregion
        static void spawn_floor(int size_x, int size_y)
        {

            for (int i = 0; i < size_x; i++)
            {
                //ground_check[i, Float] = true;
                Console.SetCursorPosition(i, Float+1);
                Console.Write("_");
                Thread.Sleep(10);
            }
        }

        public void spawn_block()
        {
            Random pos_y = new Random();
            int pos = pos_y.Next(Float);
            for (int i = size_x; i > 0; i--)
            {
                Console.Write(" ");
                Console.SetCursorPosition(i, pos);
                Console.Write("@");
                Console.SetCursorPosition(i, pos);
                fly[i-1, pos] = true;
                Thread.Sleep(50);
            }

        }
    }
}

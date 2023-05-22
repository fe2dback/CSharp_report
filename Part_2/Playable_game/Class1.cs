using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playable_game
{
    class Class1
    {
        static int screenX = 50, screenY = 25;
        static Mark[,] screen = new Mark[screenX, screenY];
        static List<Point> itemList = new List<Point>();
        static int px = 25, py = 12;
        static bool isGameOn = true;

        static void KeyInput()
        {
            Task task = new Task(() =>
            {
                while(true)
                {
                    cki = Console.ReadKey();
                }
            });
            task.Start();
        }
        static void Main(string[] args)
        {
            ClearScreen();
            MakeItem();
            DrawScreen();

            KeyInput();

            while (isGameOn == true)
            {
                MovePlayer();
                CheckState();
            }
            ExitGame();
        }

        static void ClearScreen()
        {
            for (int i = 0; i< screenX; i++)
            {
                for (int j = 0; j < screenY; j++)
                {
                    screen[i, j] = Mark.empty;
                }
            }
        }
        static void MakeItem()
        {
            Random random = new Random();
            for (int i = 0; i < 11; i++)
            {
                int posX = random.Next(1, screenX-1);
                int posY = random.Next(1, screenY-1);
                Point p = new Point(posX, posY);
                itemList.Add(p);
                screen[posX, posY] = Mark.item;

            }
        }
        static void DrawScreen()
        {
            Console.CursorVisible = false;
            for (int i = 0; i < screenX; i++)
            {
                for (int j = 0; j < screenY; j++)
                {
                    if (screen[i, j] == Mark.item)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("❤️");
                    }
                }
            }
            ShowCursorPosition();
        }
        static void MovePlayer()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            Console.SetCursorPosition(px, py);
            Console.WriteLine(" ");
            switch (cki.Key)
            {
                case ConsoleKey.LeftArrow:
                    px--;
                    break;
                case ConsoleKey.RightArrow:
                    px++;
                    break;
                case ConsoleKey.UpArrow:
                    py--;
                    break;
                case ConsoleKey.DownArrow:
                    py++;
                    break;
                default:
                    break;
            }
            if (px >= screenX) px = 1;
            if (px <= 0) px = screenX - 1;
            if (py >= screenY) py = 1;
            if (py <= 0) py = screenY - 1;
            Console.SetCursorPosition(px, py);
            Console.Write("P");
            ShowCursorPosition();
        }
        static void CheckState()
        {
            if (screen[px, py] == Mark.item)
            {
                for (int i = itemList.Count-1; i >= 0;  i--)
                {
                    if (itemList[i].x == px && itemList[i].y ==py)
                    {
                        itemList.Remove(itemList[i]);
                        if (itemList.Count == 0)
                        {
                            isGameOn = false;
                        }
                    }
                }
                screen[px, py] = Mark.empty;
            }
        }
        static void ExitGame()
        {
            for(int i =0; i < screenX; i++)
            {
                for(int j = 0; j < screenY; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.WriteLine("#");

                }
            }
        }
        static void ShowCursorPosition()
        {
            Console.SetCursorPosition(15, 26);
            Console.WriteLine("================X : {0}=Y : {1}=Item : {3}==============",px, py, itemList.Count);
        }
    }
    enum Mark
    {
        empty,
        player,
        item,
    }


    class Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x=x;
            this.y=y;
        }
    }
}

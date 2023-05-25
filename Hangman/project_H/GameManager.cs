using Figgle;
using static System.Net.Mime.MediaTypeNames;
//Install-Package Figgle

namespace project_H
{
    class GameManager
    {
        public static bool Dead = false;
        static int Round = 0;
        static Score score = new Score();
        static void Main(string[] args)
        {
            //시작시 난이도를 설정합니다
            selete_mode();
        }

        static void OnGame(int diff)
        {
            check_draw isGame = new check_draw();
            isGame.arr();//단어를 생성합니다
            isGame.diff = diff;//입력받은 난이도를 설정합니다
            isGame.diff_next = diff;//재시작할때 난이도를 저장합니다
            while (true)
            {
                isGame.check(); //플레이어의 입력을받고 이를 체크합니다
            }
        }
        static void selete_mode()
        {
            Console.CursorVisible = false;
            Console.WriteLine("게임 모드를 선택하세요 . . .\n");
            Console.WriteLine("[1]Classic\n");
            Console.WriteLine("[2]Multiplay");
            ConsoleKeyInfo diff = Console.ReadKey();
            Console.Clear();

            switch (diff.Key)
            {
                case ConsoleKey.D1:
                    check_draw.Setuser(false);
                    OnGame(8);
                    break;
                case ConsoleKey.D2:
                    check_draw.Setuser(true);
                    multi();
                    OnGame(8);
                    break;
                default:
                    selete_mode();
                    break;
            }   
        }
        public static void multi()
        {
            Console.Clear();
            Console.Write("word? : ");
            string text = Console.ReadLine();
            check_draw.SetWord(text.ToUpper());
            check_draw.SetWord_category("answer");
            Console.Clear();   
        }

        public static void multi_die()
        {

        }

        public static void complete(int diff, string answer)
        {
            Console.Clear();

            string asciiArt = FiggleFonts.Standard.Render("COMPLETE");
            Console.Write(asciiArt);
            Console.SetCursorPosition(1, 7);
            Console.WriteLine(answer);
            Thread.Sleep(1000);

            //초기화 그룹-------------------------------------
            StringGroup init = new StringGroup();
            check_draw.SetWord(init.text());
            check_draw.SetWord_category(init.text_category());
            //------------------------------------------------

            Console.Clear();

            OnGame(diff);
            
        }

        public static void Die()
        {
            while (true)
            {
                Console.Clear();
                string die = FiggleFonts.Standard.Render("DEAD . . .");
                Console.Write(die);
                string best_score = FiggleFonts.Standard.Render($"BEST SCORE : {Score.bestscore}");
                Console.Write(best_score);
                Console.WriteLine("\nREPLAY?\n");
                Console.WriteLine("CONTINUE PRESS : R");


                ConsoleKeyInfo repl = Console.ReadKey();
                if (repl.Key == ConsoleKey.R)
                {
                    Console.Clear();
                    //초기화 그룹-------------------------------------
                    StringGroup init = new StringGroup();
                    check_draw.SetWord(init.text());
                    check_draw.SetWord_category(init.text_category());
                    //------------------------------------------------
                    selete_mode();
                    break;
                }
            }
            
        }
    }
}
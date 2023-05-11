using System;
//2차원 배열을 이용하여 아래 영상과 같이 랜덤 아이템 10개를 (50,20)화면에 배치하고 
//플레이어(P)가 방향키로 돌아다니면서 다 먹으면 클리어 하는 게임 제작(플러에어가 화면을 벗어나면 반대방향에서 나오기)
namespace Playable_game
{
    class onGame
    {
        #region value
        
        static int Goal = 10;
        static int Score = 0;
        static int onboard_x = 50;
        static int onboard_y = 20;
        static int player_start_x = onboard_x/2;
        static int player_start_y = onboard_y/2;
        static int player_pos_x;
        static int player_pos_y;
        static bool[,] board = new bool[onboard_x, onboard_y];
        static bool replay = false;
        static bool playing = true;
        static bool dead = false;
        #endregion

        #region 시작옵션
        static void start_opt()
        {
            //Console.SetBufferSize(250,250);
            map();
            player_pos_x = player_start_x;
            player_pos_y = player_start_y;
            Console.SetCursorPosition(player_pos_x, player_pos_y);
            Console.Write("P");
        }
        #endregion

        #region 시작
        public void start()
        {

            while (playing == true)
            {
                Playing();
            }
        }
        #endregion

        #region 게임 플레이
        static void Playing()
        {
            start_opt();
            while (true)
            {
                
                player_move();
                Console.SetCursorPosition(56, 5);
                Console.WriteLine($"Pos : {player_pos_x},{player_pos_y} ");
                Console.SetCursorPosition(56, 6);
                Console.Write($"Score : {Score}");



                if (Score == Goal)
                {
                    Console.Clear();
                    Console.WriteLine("Clear");
                    Console.Write("Replay : R");
                    dead = true;
                    playing = false;
                    replay = true;
                    Score = 0;
                }
            }
        }
        #endregion

        #region 점수관리
        static void score()
        {
            if (board[player_pos_x, player_pos_y] == true)
            {
                Score++;
                board[player_pos_x, player_pos_y] = false;
            }
            else
            {
                return;
            }
        }
        #endregion

        #region 범위 체크
        static void player_check()
        {
            
            if(player_pos_x > onboard_x-1)
            {
                player_pos_x = 1;
            }
            else if (player_pos_x < 1)
            {
                player_pos_x = onboard_x-1;
            }
            else if (player_pos_y > onboard_y-1)
            {
                player_pos_y = 1;
            }
            else if (player_pos_y < 1)
            {
                player_pos_y = onboard_y-1;
            }

        }
        #endregion

        #region 플레이어 조작
        static void player_move()
        {
            ConsoleKeyInfo player_key = Console.ReadKey();
            Console.SetCursorPosition(player_pos_x, player_pos_y);
            Console.Write(" ");
            switch (player_key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (dead == false)
                    {
                        player_pos_y--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (dead == false)
                    {
                        player_pos_y++;
                    }
                        break;
                case ConsoleKey.LeftArrow:
                    if (dead == false)
                    {
                        player_pos_x--;
                    }
                    break;

                case ConsoleKey.RightArrow:
                    if (dead == false)
                    {
                        player_pos_x++;
                    }
                    break;
                case ConsoleKey.R:

                    if (replay == true)
                    {
                        Console.Clear();
                        playing = true;
                        replay = false;
                        dead = false;
                        onGame fe = new onGame();
                        fe.start();
                    }
                    break;
                default:
                    break;
            }
            player_check();
            Console.SetCursorPosition(player_pos_x, player_pos_y);
            Console.Write("P");
            score();
            

        }
        #endregion

        #region 아이템 생성
        static void map()
        {

            Random random = new Random();
            int Pos_1, Pos_2;
            for (int i = 0; i < Goal; i++)
            {
                Pos_1 = random.Next(1, onboard_x);
                Pos_2 = random.Next(1, onboard_y);
                Console.SetCursorPosition(Pos_1, Pos_2);
                board[Pos_1, Pos_2] = true;
                if (board[Pos_1, Pos_2] == true)
                {
                    Console.Write("$");
                }

            }

        }
        #endregion
    }

}


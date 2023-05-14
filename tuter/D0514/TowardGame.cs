internal class Program
{
    static void Main(string[] args)
    {
        GameManager();
    }

    // 4. 전체적인 흐름 컨트롤
    static void GameManager()
    {
        // 변수
        bool isEnd = false;
        int charX = 0;
        int charY = 0;
        int goalX = 0;
        int goalY = 0;
        // 메소드

        // 초기 설정
        Console.CursorVisible = false;
        SetGoal(out goalX, out goalY);
        DrawGoal(goalX, goalY);
        DrawCharacter(charX, charY);

        // loop - 반복
        while (!isEnd)
        {
            // 2. 플레이어 움직임
            Move(ref charX, ref charY);
            DrawGoal(goalX, goalY);
            // 3. 도착했는지 체크
            isEnd = CheckEnd(goalX, goalY, charX, charY);
        }

        // End

    }

    // 목적지 설정
    static void SetGoal(out int goalX, out int goalY)
    {
        // 랜덤 좌표 지정
        Random rand = new Random();
        goalX = rand.Next(10, 20);
        goalY = rand.Next(10, 20);
    }

    static void DrawGoal(int goalX, int goalY)
    {
        // 콘솔창에 그리기
        Console.SetCursorPosition(goalX, goalY);
        Console.Write("X");
    }

    // 플레이어 움직임
    static void Move(ref int charX, ref int charY)
    {
        ConsoleKeyInfo inputKey = Console.ReadKey(true);

        Console.Clear();

        switch (inputKey.Key)
        {
            case ConsoleKey.LeftArrow:
                charX--;
                DrawCharacter(charX, charY);
                break;

            case ConsoleKey.RightArrow:
                charX++;
                DrawCharacter(charX, charY);
                break;

            case ConsoleKey.UpArrow:
                charY--;
                DrawCharacter(charX, charY);
                break;

            case ConsoleKey.DownArrow:
                charY++;
                DrawCharacter(charX, charY);
                break;

            default:
                DrawCharacter(charX, charY);
                break;
        }
    }

    static void DrawCharacter(int charX, int charY)
    {
        Console.SetCursorPosition(charX, charY);
        Console.WriteLine("O");
    }

    static bool CheckEnd(int goalX, int goalY, int charX, int charY)
    {
        // 도착했을때
        if (charX == goalX && charY == goalY)
        {
            Console.Clear();
            Console.SetCursorPosition(60, 10);
            Console.WriteLine("게임 종료!");
            return true;
        }
        else // 도착하지 못했을 때
        {
            return false;
        }
    }
}
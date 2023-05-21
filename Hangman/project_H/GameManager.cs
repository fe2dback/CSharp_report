using project_H.String_M;

namespace project_H
{
    class GameManager
    {
        static void Main(string[] args)
        {
            Manager();    
        }

        //게임매니저
        static void Manager()
        {
            user_input();
            words();
        }

        //0. 플레이 보드 만들기
        static void board()
        {
            Console.SetCursorPosition(10, 3);
            
        }

        //1. 사용자 입력받기
        static void user_input()
        {
            PlayerInput Ui = new PlayerInput();
            char Input = Ui.userChar();
        }
        //2. 랜덤한 단어생성
        static void words()
        {
            StringArray Sa = new StringArray();
            Sa.blank();
            
        }


        //3. 입력받은값과 단어 비교하기 ? 계속 입력받기 : 행맨을 그리고 남은 수 만큼 입력받기
        static void compare(string word, string user_input)
        {
            
        }
    }
}
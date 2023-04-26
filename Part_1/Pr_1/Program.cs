
/*
8일까지 해올 C#과제 (1단계(실행안되도 하는데 까지 해오기)  및 기타 필수, 2단계 및 3단계 선택 ) 
-1단계 : 랜덤한 위치와 크기를 가진 원(Circle)을 생성하는 클래스를 만들고 이를 이용해서 원 인스턴스를 2개 생성하기

-2단계 : 2개의 원이  서로 교차(충돌)하는지 파악하는 기능 추가하기

3단계 : 충돌된 원이 밀려나는 기능과 위 기능을 c#이 제공하는 내장함수를 전혀 사용하지 않고 구현하기(WriteLine 제외)


기타 : 유니티 홈페이지에서 학생 회원 가입하여 아이디 및 패스워드 가져오기(설치 권장)
- 원을 실제 콘솔창에 그리는것이 아닌 메모리에 가상으로 존재하면 됨
*/

namespace Pr_1
{


    class main
    {
        public static void Main(string[] args)
        {
            Circle_tool c1 = new Circle_tool();
            c1.circle();
            Circle_tool c2 = new Circle_tool();
            c2.circle();
            check(c1.data[0], c1.data[1], c1.data[2], c2.data[0], c2.data[1], c2.data[2]);


        }
        static void check(int x1, int y1, int r1, int x2, int y2, int r2)
        {
            if((x1-x2) * (x1-x2) + (y1-y2)*(y1-y2) < (r1 + r2) * (r1 + r2))
            {
                Console.WriteLine("true");
                Console.WriteLine("x1 : y1 : r1");
                Console.WriteLine($"{x1} : {y1} : {r1}");
                Console.WriteLine($"{x2} : {y2} : {r2}");
            }
            else
            {
                Console.WriteLine("false");
                Console.WriteLine("x1 : y1 : r1");
                Console.WriteLine($"{x1} : {y1} : {r1}");
                Console.WriteLine($"{x2} : {y2} : {r2}");
            }
        }
    }


    public class Circle_tool
    {
        public int[] data = new int[3];

        
        public void circle()
        {
            int[] board = new int[2];
            Random rand = new Random();
            int R = rand.Next(2, 2);
            int P1 = rand.Next(1, 10);
            int P2 = rand.Next(1, 10);
            int size = (int)Math.PI * (R * R);
            this.data[0] = P1;
            this.data[1] = P2;
            this.data[2] = R;
        }
    }
}


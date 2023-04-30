
/*
-1단계 : 랜덤한 위치와 크기를 가진 원(Circle)을 생성하는 클래스를 만들고 이를 이용해서 원 인스턴스를 2개 생성하기

-2단계 : 2개의 원이  서로 교차(충돌)하는지 파악하는 기능 추가하기

-3단계 : 충돌된 원이 밀려나는 기능과 위 기능을 c#이 제공하는 내장함수를 전혀 사용하지 않고 구현하기(WriteLine 제외)

- 원을 실제 콘솔창에 그리는것이 아닌 메모리에 가상으로 존재하면 됨
*/

namespace Pr_1
{


    class main
    {
        public static void Main(string[] args)
        {
            Circle_tool c1 = new Circle_tool(); // 원 인스턴스 생성
            c1.circle();
            Circle_tool c2 = new Circle_tool(); // 원 인스턴스 생성
            c2.circle();
            check(c1.data[0], c1.data[1], c1.data[2], c2.data[0], c2.data[1], c2.data[2]); // 겹침 체크
        }



        static void check(int x1, int y1, int r1, int x2, int y2, int r2) // 겹침 확인 기능
        {
            if ((x1-x2) * (x1-x2) + (y1-y2)*(y1-y2) < (r1 + r2) * (r1 + r2)) //원의 교차 여부 공식
            {
                Console.WriteLine("겹침");
                Console.WriteLine("x1 : y1 : r1");
                Console.WriteLine($"{x1} : {y1} : {r1}");
                Console.WriteLine($"{x2} : {y2} : {r2}");
                Console.WriteLine("이동");
                gravity(x1, y1, r1, x2, y2, r2); // 겹친다면 밀릴 방향체크
            }
            else
            {
                Console.WriteLine("안겹침");
                Console.WriteLine("x1 : y1 : r1");
                Console.WriteLine($"{x1} : {y1} : {r1}");
                Console.WriteLine($"{x2} : {y2} : {r2}");
            }

        }


        static void gravity(int x1, int y1, int r1, int x2, int y2, int r2) // 밀림 기능
        {
            if (x2 > x1 && y2 > y1) // x2 좌표와 y2 좌표가 크면 오른쪽 위로 이동
            {
                x2++;
                y2++;
                Console.WriteLine("+ + 방향으로 밀림");
                check(x1, y1, r1, x2, y2, r2);
            }
            else if (x2 > x1 && y2 < y1) // x2 좌표는 크지만 y2 좌표가 적으면 오른쪽 아래로 이동
            {
                x2++;
                y2--;
                Console.WriteLine("+ - 방향으로 밀림");
                check(x1, y1, r1, x2, y2, r2);
            }
            else if (x2 < x1 && y2 > y1) // x2 좌표는 작지만 y2 좌표가 크다면 왼쪽 위로 이동
            {
                x2--;
                y2++;
                Console.WriteLine("- + 방향으로 밀림");
                check(x1, y1, r1, x2, y2, r2);
            }
            else if (x2 < x1 && y2 < y1) // x2 좌표와 y2 좌표가 작으면 왼쪽 아래로 이동
            {
                x2--;
                y2--;
                Console.WriteLine("- - 방향으로 밀림");
                check(x1, y1, r1, x2, y2, r2);
            }
            else if (x2 == x1 && y2 > y1) // x2 와 좌표가 같으면서 y2 좌표가 크면 위로만 이동
            {
                y2++;
                Console.WriteLine("0 + 방향으로 밀림");
                check(x1, y1, r1, x2, y2, r2);
            }
            else if (x2 > x1 && y2 == y1) // x2 좌표가 크면서 y2 좌표가 같으면 오른쪽으로만 이동
            {
                x2++;
                Console.WriteLine("+ 0 방향으로 밀림");
                check(x1, y1, r1, x2, y2, r2);
            }
            else if (x2 == x1 && y2 < y1) // x2 와 좌표가 같으면서 y2 좌표가 작으면 아래로만 이동
            {
                y2--;
                Console.WriteLine("0 - 방향으로 밀림"); 
                check(x1, y1, r1, x2, y2, r2);
            }
            else if (x2 < x1 && y2 == y1) // x2 좌표가 작으면서 y2 좌표가 같으면 왼쪽으로만 이동
            {
                x2--;
                Console.WriteLine("- 0 방향으로 밀림");
                check(x1, y1, r1, x2, y2, r2);
            }
            else
            {
                Console.WriteLine("error");
            }
        }


        public class Circle_tool //원 클래스
        {
            public int[] data = new int[3];


            public void circle()
            {
                int[] board = new int[2];
                Random rand = new Random();
                int R = rand.Next(1, 10); // 반지름 
                int P1 = rand.Next(1, 10); // x 좌표
                int P2 = rand.Next(1, 10); // y 좌표
                int size = (int)Math.PI * (R * R); // 원의 크기(int)
                this.data[0] = P1; // data1 = x
                this.data[1] = P2; // data2 = y
                this.data[2] = R; // data 3= r
            }
        }
    }
}



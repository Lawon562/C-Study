using System;
using System.Security.Cryptography;
using System.Threading;

namespace day1_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //=====================================================================================
            // 주석문 ctrl+k, ctrl+c
            // 주석 해제 ctrl+k, ctrl+u
            // Console.Write("Hello World!");
            // Console.Write("Hello C#!!!");

            /* 
            //Q1
            Console.WriteLine("Hello World의 유래는?\n\nC 와 UNIX를 개발한\n브라이언 커니핸과 데니스 리치가\n쓴 THE C Program Language 교재에\n첫 예제가 Hello World! 출력 이였다.\n\n해당 교재가 유명해지면서\n모든 프로그래밍 첫 예제가\nHello World 출력으로 시작하게 되었다");
            //Q2
            Console.WriteLine("*\n**\n***\n****\n*****");
            //Q3
            Console.WriteLine("{0}\n\t{1}, {2}, {3}, {4}, {5}", "2019", "JAVA", "C", "Python", "C++", "C#");
            Console.WriteLine("{0}\n\t{3}, {5}, {2}, {4}, {1},", "2050", "JAVA", "C", "Python", "C++", "C#");
            */

            /*
            foreach(string line in zero)
            {
                Console.SetCursorPosition(x, y);
                foreach(char ch in line)
                {
                    Console.Write(ch);
                    x += 1;
                }
                if (x >= 10)
                {
                    x = 0;
                    y += 1;
                }
            }
            */

            /*
            int v1 = 100;
            float v2 = 100f;
            string v3 = "2002년 10월 31일";
            bool v4 = true;

            Console.WriteLine("\n\n\n데이타형 확인하기");
            Console.WriteLine($"v1의 값은 [{v1}] 데이터 타입은 {v1.GetType()}");
            Console.WriteLine($"v2의 값은 [{v2}] 데이터 타입은 {v2.GetType()}");
            Console.WriteLine($"v3의 값은 [{v3}] 데이터 타입은 {v3.GetType()}");
            Console.WriteLine($"v4의 값은 [{v4}] 데이터 타입은 {v4.GetType()}");
            */

            // 숫자 구분자
            //int asd = 1_000_000;
            //Console.WriteLine($"{asd},{1_000}");


            // overflow
            /*
            int e1 = int.MaxValue;
            long e2 = int.MaxValue;
            Console.WriteLine($"{e1}, {e2}");
            Console.WriteLine($"{e1 + 1}, {e2 + 1}");
            */

            //Q4
            /*
            Console.Write("원의 반지름 : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"원의 넓이 : {3.14f*r*r}");
            Console.WriteLine($"원의 둘레 : {2*3.14f*r}");
            */

            // Q5
            /*
            Console.WriteLine($"{"byte"} 자료형 최댓값 : {byte.MaxValue} 최소값 : {byte.MinValue}");
            Console.WriteLine($"{"sbyte"} 자료형 최댓값 : {sbyte.MaxValue} 최소값 : {sbyte.MinValue}");
            Console.WriteLine($"{"short"} 자료형 최댓값 : {short.MaxValue} 최소값 : {short.MinValue}");
            Console.WriteLine($"{"ushort"} 자료형 최댓값 : {ushort.MaxValue} 최소값 : {ushort.MinValue}");
            Console.WriteLine($"{"int"} 자료형 최댓값 : {int.MaxValue} 최소값 : {int.MinValue}");
            Console.WriteLine($"{"uint"} 자료형 최댓값 : {uint.MaxValue} 최소값 : {uint.MinValue}");
            Console.WriteLine($"{"long"} 자료형 최댓값 : {long.MaxValue} 최소값 : {long.MinValue}");
            Console.WriteLine($"{"ulong"} 자료형 최댓값 : {ulong.MaxValue} 최소값 : {ulong.MinValue}");
            Console.WriteLine($"{"float"} 자료형 최댓값 : {float.MaxValue} 최소값 : {float.MinValue}");
            Console.WriteLine($"{"double"} 자료형 최댓값 : {double.MaxValue} 최소값 : {double.MinValue}");
            */

            string user1 = "Maria", user2 = "John";
            string msg = "Good Night";
            string msg1 = String.Format("{0}, {1}", user1, user2);
            string msg2 = String.Format("{0}, {1}", user2, user1);
            string msg3 = String.Format($"{user1}, {msg}, \n{user2}, {msg}");
            Console.WriteLine(msg1);            
            Console.WriteLine(msg2);            
            Console.WriteLine(msg3);
            Console.WriteLine("==========================");

            //Q6
            /*
            String ctime = DateTime.Now.ToString().Split(' ')[0];
            string[] cdate = ctime.Split('-');

            Console.WriteLine($"{cdate[0]}년 {cdate[1]}월 {cdate[2]}일 ? 띠 운세");
            Console.WriteLine("\n아무렇지도 않게 사고 있던 복권이 당첨되거나 생각하지 않는 럭키 좋은 행운이 있거나와 매우 행운이 넘치는 날입니다.\n");
            Console.WriteLine("비즈니스면에서는, 지금까지 생각하는 것처럼 이익이 없던 사람도, 이 날 이후에는 안정된 수입을 얻을 수 있게 되겠지요.\n");
            Console.WriteLine("지금까지 착실하게 계속해 온 노력이 보답 받고, 주위로부터의 신뢰를 모으는 등, 그 성과를 얻을 수 있는 시기가 될 것 같습니다.\n");
            Console.WriteLine("또, 자신이 가진 재능을 마음껏 발휘할 수 있을 때이므로, 적극적으로 행동해 보세요.\n");
            */

            //Q7
            const float MAX_FLOAT = float.MaxValue;
            const float MIN_FLOAT = float.MinValue;

            Console.WriteLine($"float 자료형의 최댓값 = {MAX_FLOAT}");
            Console.WriteLine($"float 자료형의 최솟값 = {MIN_FLOAT}");

            //Q8
            Console.Write("사각형의 가로 길이를 숫자로 입력하여 주세요 ... ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("사각형의 세로 길이를 숫자로 입력하여 주세요 ... ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"사각형의 가로 길이 = {width}");
            Console.WriteLine($"사각형의 세로 길이 = {height}");
            Console.WriteLine($"사각형의 넓이 = {width*height}");

            Console.Write(" 이름을 입력하세요 => ");
            string userName = Console.ReadLine();
            Console.WriteLine($" {userName} 님 환영합니다. ");
            Console.WriteLine("===========================");

            int x1 = int.MinValue;
            double x2 = Convert.ToDouble(x1);
            bool x3 = Convert.ToBoolean(x1);
            string x4 = Convert.ToString(x1);
            Console.WriteLine($"\t x1의 값은 {x1} 데이터 형은 {x1.GetType()}");
            Console.WriteLine($"\t x2의 값은 {x2} 데이터 형은 {x2.GetType()}");
            Console.WriteLine($"\t x3의 값은 {x3} 데이터 형은 {x3.GetType()}");
            Console.WriteLine($"\t x4의 값은 {x4} 데이터 형은 {x4.GetType()}");

            int y1 = 100;
            string y2 = Convert.ToString(y1,2);
            string y3 = Convert.ToString(y1,8);
            string y4 = Convert.ToString(y1,16);

            Console.WriteLine($"\t 10진수 = {y1}, 데이타형은 {y1.GetType()}");
            Console.WriteLine($"\t 2진수 = {y2}, 데이타형은 {y2.GetType()}");
            Console.WriteLine($"\t 2진수 = {y2.PadLeft(8, '0')}, 데이타형은 {y2.GetType()}");
            Console.WriteLine($"\t 8진수 = {y3}, 데이타형은 {y3.GetType()}");
            Console.WriteLine($"\t 8진수 = {y3.PadLeft(8, '0')}, 데이타형은 {y3.GetType()}");
            Console.WriteLine($"\t 16진수 = {y4}, 데이타형은 {y4.GetType()}");
            Console.WriteLine($"\t 16진수 = {y4.PadLeft(4, '0')}, 데이타형은 {y4.GetType()}");
            //Q9
            Console.Write("입력 >>");
            int data = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\t2진수 = {Convert.ToString(data, 2)}");
            Console.WriteLine($"\t8진수 = {Convert.ToString(data, 8)}");
            Console.WriteLine($"\t16진수 = {Convert.ToString(data, 16)}");
        }
    }
}

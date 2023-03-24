using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_1
{
    internal class Program
    {
        

        private static void PrintNumber()
        {
            for (int i = 5; i < 100; i += 5)
            {
                Console.Write($"{i,3}");
                if (i % 15 == 0) Console.WriteLine();
            }
        }

        private static void GuguShow()
        {
            for (int i = 2; i < 10; i++)
            {
                for(int k = 1; k<10; k++)
                {
                    Console.WriteLine($"{i} X {k} = {i*k}");
                }
            }
        }

        private static void Fridge()
        {
            string ans = "";
            string total = "";
            while(true)
            {
                Console.Write("입력 종료(q/Q)");
                ans = Console.ReadLine();
                if (ans.Equals("q") || ans.Equals("Q")) break;
                Console.Write("우리집 냉장고에 있는 것은? ... ");
                total += Console.ReadLine();
            } 
            Console.WriteLine($"냉장고에는 {total}가(이) 있다.");
        }


        private static void GuguShow2(int number)
        {
            for(int i = 1; i<10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number*i}");
            }
        }

        private static void Nsum(int number)
        {
            int sum = number * (number + 1) / 2;
            Console.WriteLine($"1부터 {number}까지의 합은? {sum}");
        }

        private static void PrintNumber2(int n1, int n2)
        {
            int count = 0;
            for (int i = n1; i < 100; i+=n1)
            {
                Console.Write($"{i,5}");
                if (++count % n2 == 0) Console.WriteLine();
            }
        }

        private static int ThreeMultiplied(int x, int y, int z)
        {
            return x*y*z;
        }

        private static void CircleArea(int r = 0)
        {
            float pie = 3.14f;
            float area = pie * r * r;
            Console.WriteLine($"원의 넓이는? {r} X {r} X {pie} = {area:F3}");
        }

        private static void gradePrint(
            int kor=0, 
            int eng=0, 
            int math=0)
        {
            Console.WriteLine($"국어 : {kor} 영어 : {eng} 수학 : {math}");
            int total = kor + eng + math;
            int avg = total / 3;
            string result = avg >= 70 ? "합격" : "불합격";
            Console.WriteLine($"총점 : {total} 평균 : {avg} => {result}");
            Console.WriteLine("=======================================");
        }

        private static string printBMI(double weight, double height)
        {
            double bmi = weight / ((height / 100) * (height / 100));

            string result = $"{bmi:F2} ";
            if (bmi < 20) result += "저체중";
            else if (bmi < 25) result += "정상체중";
            else if (bmi < 30) result += "경도비만";
            else if (bmi < 40) result += "비만";
            else result += "고도비만";

            return result;
        }

        private static void printMessage(params string[] names)
        {
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]} 님. 안녕하세요 !!!!");
            }
            Console.WriteLine("\n");
        }

        private static string getMaxNumber(params double[] dnum )
        {
            string res = default(string);
            if (dnum.Length <= 1) res = "오류발생";
            else
            {
                res = "큰수는? ";
                res += dnum.Max();
            }
            return res;
        }

        private static void Calculaor(int n1, int n2)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("정수 int형의 두 수 사칙연산");
            Console.WriteLine("-------------------------");

            Console.WriteLine($"{n1} + {n2} = {n1+n2}");
            Console.WriteLine($"{n1} - {n2} = {n1-n2}");
            Console.WriteLine($"{n1} * {n2} = {n1*n2}");
            Console.WriteLine($"{n1} / {n2} = {n1/n2}");
        }

        private static void Calculaor(double n1, double n2, double n3)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("실수 int형의 세 수 사칙연산");
            Console.WriteLine("-------------------------");

            Console.WriteLine($"{n1} + {n2} + {n3} = {n1 + n2 + n3:F2}");
            Console.WriteLine($"{n1} - {n2} - {n3} = {n1 - n2 - n3:F2}");
            Console.WriteLine($"{n1} * {n2} * {n3} = {n1 * n2 * n3:F2}");
            Console.WriteLine($"{n1} / {n2} / {n3} = {n1 / n2 / n3:F2}");
        }

        private static double GetArea(double r)
        {
            return r * r * 3.14;
        }

        private static double GetArea(double width, double height)
        {
            return width * height;
        }

        private static double GetArea(double upper, double lower, double height)
        {
            return (upper + lower) * height / 2;
        }


        private static void MethodQuiz()
        {
            //10p
            //PrintNumber();

            //11p
            //Console.WriteLine("구구단 출력함수 호출");
            //GuguShow();

            //12p
            //Fridge();

            //14p
            //GuguShow2(2);

            //15p
            //Nsum(100);

            //16p
            //PrintNumber2(7, 7);
            //PrintNumber2(11,2 );

            //22p
            //int x = 78, y = 5, z = 11;
            //Console.WriteLine($"{x} X {y} X {z}의 결과값은? ");
            //Console.WriteLine(ThreeMultiplied(x, y, z));

            //29p
            //CircleArea(0);
            //CircleArea(5);
            //CircleArea(12);

            //30p
            //gradePrint();
            //gradePrint(80);
            //gradePrint(80, 95);
            //gradePrint(80, 95, 70);
            //gradePrint(77, 35, 70);

            //36p
            //Console.WriteLine($"고객001 167.5cm , 55.7kg => BMI {printBMI(height:167.5, weight:55.7)}");
            //Console.WriteLine($"고객002 188cm   , 89.1kg => BMI {printBMI(weight:89.1, height:188)}");
            //Console.WriteLine($"고객003 145cm   , 50.35kg => BMI {printBMI(weight:50.35, height:145)}");

            //43p
            //printMessage("철수");
            //printMessage("강호", "영희");
            //printMessage("영준", "명희", "지민", "수진");

            //45p
            //Console.WriteLine(getMaxNumber());
            //Console.WriteLine(getMaxNumber(55.5));
            //Console.WriteLine(getMaxNumber(12.678, 55.5));
            //Console.WriteLine(getMaxNumber(123.5, -90, 678));
            //Console.WriteLine(getMaxNumber(-90, 678, 999.456, 123));

            //51p
            //Calculaor(100, 4);
            //Calculaor(15.78, 3.456, 23.456);

            //53p
            Console.WriteLine($"반지름 2.5cm인 타원의 면적 = {GetArea(2.5)}cm");
            Console.WriteLine($"가로 5.5cm, 세로 7.5cm인 사각형 면적 = {GetArea(5.5, 7.5)}cm");
            Console.WriteLine($"윗변 2.5cm, 아랫변 4.3cm, 높이 5.2cm인 사다리꼴의 면적 = {GetArea(2.5, 4.3, 5.2)}cm");

        }

        


        static void Main(string[] args)
        {
            MethodQuiz();
        }
    }
}

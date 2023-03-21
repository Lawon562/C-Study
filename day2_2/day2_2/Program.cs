using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_2
{
    internal class Program
    {
        public static string bar = "----------------------------------------------------";
        public static void quizTitle()
        {
            Console.WriteLine($"\n\n{bar}");
            for (int i = 0; i < bar.Length / 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("퀴즈");
            Console.WriteLine($"{bar}");
        }

        public static void discription(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write("· ");
                for (int k = 0; k < args[i].Length; k++)
                {
                    if (k % (bar.Length / 2) == bar.Length / 2 - 1)
                    {
                        Console.WriteLine("");
                        Console.Write("   ");
                    }
                    Console.Write($"{args[i][k]}");
                    
                }
                Console.WriteLine("\n");
                
            }            
        }

        public static void printScreen()
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("          출력화면");
            Console.WriteLine("----------------------------\n");

        }

        public static void Quiz(string[] args)
        {
            quizTitle();
            discription(args);

            printScreen();
        }

        public static int GetInteger(string args)
        {
            Console.Write($"{args}");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        static void Main(string[] args)
        {
            //double n1 = 100;
            //double n2 = 3;
            //Console.WriteLine("\t {0} + {1} = {2}", n1,n2,(n1+n2));
            //Console.WriteLine("\t {0} - {1} = {2}", n1,n2,(n1-n2));
            //Console.WriteLine("\t {0} * {1} = {2}", n1,n2,(n1*n2));
            //Console.WriteLine("\t {0} / {1} = {2:F2}", n1,n2,(n1/n2));
            //Console.WriteLine("\t {0} % {1} = {2}", n1,n2,(n1%n2));

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("          입력화면");
            //Console.WriteLine("----------------------------");

            //Console.Write("첫 번째 숫자 입력 : ");
            //n1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("두 번째 숫자 입력 : ");
            //n2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("          출력화면");
            //Console.WriteLine("----------------------------");

            //Console.WriteLine("{0} + {1} = {2:F2}", n1, n2, (n1 + n2));
            //Console.WriteLine("{0} - {1} = {2:F2}", n1, n2, (n1 - n2));
            //Console.WriteLine("{0} * {1} = {2:F2}", n1, n2, (n1 * n2));
            //Console.WriteLine("{0} / {1} = {2:F2}", n1, n2, (n1 / n2));
            //Console.WriteLine("{0} % {1} = {2:F2}", n1, n2, (n1 % n2));

            //string x1 = "12";
            //int x2 = 100;
            //double x3 = 3.14;
            //bool x4 = true;

            //Console.WriteLine( $"{x1} + {x2} = {x1+x2}");
            //Console.WriteLine( $"{x1} + {x2} = {x1+x3}");
            //Console.WriteLine( $"{x1} + {x2} = {x1+x4}");

            /*
            int xx = 0;
            Console.WriteLine(xx);
            xx += 10;
            Console.WriteLine(xx);
            xx -= 5;
            Console.WriteLine(xx);
            xx *= 3;
            Console.WriteLine(xx);
            xx /= 5;
            Console.WriteLine(xx);
            xx %= 2;
            Console.WriteLine(xx);
            */


            /*
            int amount = Convert.ToInt32(Console.ReadLine());
            int c500 = amount / 500;
            amount %= 500;
            int c100 = amount / 100;
            amount %= 100;
            int c50 = amount / 50;
            amount %= 50;
            int c10 = amount / 10;
            amount %= 10;

            Console.WriteLine($"500 :{c500}\n100 : {c100}\n50 : {c50}\n10 : {c10}\n{amount}");
            */
            /*
            int n = 10;
            Console.WriteLine($"\t 1단계 : n = {n}");
            Console.WriteLine($"\t 2단계 : n = {n++}");
            Console.WriteLine($"\t 3단계 : n = {n}");
            Console.WriteLine($"\t 4단계 : n = {++n}");
            Console.WriteLine($"\t 5단계 : n = {n--}");
            Console.WriteLine($"\t 6단계 : n = {n}");
            Console.WriteLine($"\t 7단계 : n = {--n}");
            */

            //Console.Write("비밀번호 입력 => ");
            //string pwd = Console.ReadLine();
            //Console.WriteLine($"결과 : {pwd=="1234"}");

            //Console.Write("철수의 나이는?  ... ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\n철수의 키는?  ... ");
            //int height = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("          출력화면");
            //Console.WriteLine("----------------------------");

            //Console.WriteLine($"철수는 놀이기구를 탈 수 있을까요? {age >= 10 && height >= 150}");

            //Console.Write("철수의 쿠폰 -> ");
            //int couponA = Convert.ToInt32(Console.ReadLine());
            //Console.Write("영희의 쿠폰 -> ");
            //int couponB = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("결과 >> ");
            //Console.WriteLine($"철수와 영희는 치킨을 먹을 수 있을까... ? {couponA + couponB >= 10}");

            Quiz(new string[]
            {
                "3개의 숫자를 변수로 정의하고 3숫자의 합이 500보다 크고 3숫자 모두 짝수이면 True 그렇지 않으면 False를 출력하도록 프로그래밍 하여라"
            });

            int num1 = GetInteger("첫 번째 수 : ");
            int num2 = GetInteger("두 번째 수 : ");
            int num3 = GetInteger("세 번째 수 : ");

            bool res1 = num1 + num2 + num3 > 500;
            bool res2 = num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0;
            Console.WriteLine($"세 수의 합은 500보다 큰가? {res1}");
            Console.WriteLine($"세 수는 모두 짝수인가? {res2}");
            Console.WriteLine($"세 수의 합은 500보다 크고 세 수는 모두 짝수인가?? {res1 && res2}");


            Quiz(new string[] 
            { 
                "조건 연산자를 이용하여 짝수인지 홀수인지 3과 7의 배수인지를 아래와 같은 결과 화면으로 출력하여라.",
                "입력 받은 숫자를 이용하여야 한다."
            });

            int number = GetInteger("\n숫자를 입력하여 주세요 ... ");
            string result = number % 2 == 0 ? "짝수" : "홀수";
            Console.WriteLine($"{number}는 {result}");
            Console.WriteLine(number % 3 == 0 && number % 7 == 0 ? $"{number}는 3과 7의 배수" : "");

            Quiz(new string[]
            {
                "철수는 놀이공원에서 놀이기구를 타려고 한다. 놀이 기구는 키가 150cm 이상이어야 하고 나이가 10세 이상이어야 한다.",
                "철수의 나이와 키는 입력 받는 값을 이용한다.",
                "조건연산자를 이용하여 철수가 놀이기구를 탈 수 있을지 메세지로 출력한다.",
                "(탈 수 있다 | 탈 수 없다)"
            });

            int age = GetInteger("철수의 나이는? ... ");
            int height = GetInteger("철수의 키는? ... ");
            
            result = height >= 150 || age >= 10 ? "탈 수 있다." : "탈 수 없다";
            Console.WriteLine($"철수는 놀이기구를 탈 수 있을까요? {result}");

        }
    }
}

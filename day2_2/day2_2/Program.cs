using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_2
{
    internal class Program
    {
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

            Console.Write("비밀번호 입력 => ");
            string pwd = Console.ReadLine();
            Console.WriteLine($"결과 : {pwd=="1234"}");
        }
    }
}

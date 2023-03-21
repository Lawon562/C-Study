using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_1
{
    internal class Program
    {

        public static void lesson1()
        {
            var q1 = ".NET Frmaework";
            var q2 = 10;
            var q3 = 123.567;
            var q4 = '옹';
            var q5 = false;

            Console.WriteLine($"\t q1의 값은 {q1}, 데이타 형은 {q1.GetType()}");
            Console.WriteLine($"\t q1의 값은 {q2}, 데이타 형은 {q2.GetType()}");
            Console.WriteLine($"\t q1의 값은 {q3}, 데이타 형은 {q3.GetType()}");
            Console.WriteLine($"\t q1의 값은 {q4}, 데이타 형은 {q4.GetType()}");
            Console.WriteLine($"\t q1의 값은 {q5}, 데이타 형은 {q5.GetType()}");
        }

        static void Main(string[] args)
        {
            lesson1();
        }
    }
}

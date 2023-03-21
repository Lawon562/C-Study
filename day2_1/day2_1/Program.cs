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
            string q1 = ".NET Frmaework";
            int q2 = 10;
            double q3 = 123.567D;
            char q4 = '옹';
            bool q5 = false;

            Console.WriteLine($"\t q1의 값은 {q1}, 데이타 형은 {q1.GetType()}");
            Console.WriteLine($"\t q1의 값은 {q2}, 데이타 형은 {q2.GetType()}");
            Console.WriteLine($"\t q1의 값은 {q3}, 데이타 형은 {q3.GetType()}");
            Console.WriteLine($"\t q1의 값은 {q4}, 데이타 형은 {q4.GetType()}");
            Console.WriteLine($"\t q1의 값은 {q5}, 데이타 형은 {q5.GetType()}");
        }

        public static void lesson1_default() 
        {
            // defalut 키워드를 이용한 변수 초기값 지정 
            int p1 = default;
            long p2 = default;
            float p3 = default;
            bool p4 = default;
            char p5 = default;
            string p6 = default;   // 오류 발생 

            Console.WriteLine($"\t p1의 값은 {p1} 데이타형은 {p1.GetType()}");
            Console.WriteLine($"\t p2의 값은 {p2} 데이타형은 {p2.GetType()}");
            Console.WriteLine($"\t p3의 값은 {p3} 데이타형은 {p3.GetType()}");
            Console.WriteLine($"\t p4의 값은 {p4} 데이타형은 {p4.GetType()}");
            Console.WriteLine($"\t p5의 값은 {p5} 데이타형은 {p5.GetType()}");
            Console.WriteLine($"\t p6의 값은 {p6} 데이타형은 {p6.GetType()}");
        }

        static void Main(string[] args)
        {
            //lesson1();

            lesson1_default();
        }
    }
}
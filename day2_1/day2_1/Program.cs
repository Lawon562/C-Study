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
            //string p6 = default;   // 오류 발생 
            string p6 = "";     

            Console.WriteLine($"\t p1의 값은 {p1} 데이타형은 {p1.GetType()}");
            Console.WriteLine($"\t p2의 값은 {p2} 데이타형은 {p2.GetType()}");
            Console.WriteLine($"\t p3의 값은 {p3} 데이타형은 {p3.GetType()}");
            Console.WriteLine($"\t p4의 값은 {p4} 데이타형은 {p4.GetType()}");
            Console.WriteLine($"\t p5의 값은 {p5} 데이타형은 {p5.GetType()}");
            Console.WriteLine($"\t p6의 값은 {p6} 데이타형은 {p6.GetType()}");
        }

        public static void lesson3_search_method()
        {
            string sampleTxt1 = "Good Morning";
            string sampleTxt2 = "가나다라마바사아자차카타파하";
            Console.WriteLine($"sampleTxt1 = {sampleTxt1}");
            Console.WriteLine($"sampleTxt2 = {sampleTxt2}");
            Console.WriteLine($"마지막 o의 인덱스 위치 = {sampleTxt1.LastIndexOf("o")}");
            Console.WriteLine($"a로 시작하는가? {sampleTxt1.StartsWith("a")}");
            Console.WriteLine($"G로 시작하는가? {sampleTxt1.StartsWith("G")}");
            Console.WriteLine($"G로 끝나는가? {sampleTxt1.EndsWith("a")}");
            Console.WriteLine($"ing로 끝나는가? {sampleTxt1.EndsWith("ing")}");
            Console.WriteLine($"차가 포함되었는가? {sampleTxt1.Contains("차")}");
            Console.WriteLine($"Morning 글자 교체 {sampleTxt1.Replace("Morning", "Night")}");

        }

        static void Main(string[] args)
        {
            //lesson1();

            //lesson1_default();

            lesson3_search_method();
        }
    }
}
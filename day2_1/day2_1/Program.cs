using System;
using System.CodeDom;
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

        public static void lesson1_search_method()
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

        public static void lesson1_string_method()
        {
            string sampleTxt = "Good Morning, Everyone";
            Console.WriteLine(sampleTxt[0]);
            Console.WriteLine(sampleTxt[1]);
            Console.WriteLine(sampleTxt.Length-1);
        }

        public static void lesson2_string_method()
        {
            string sampleTxt1 = "hello C#";
            string sampleTxt2 = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine($"\t sampltTxt1 = {sampleTxt1}");
            Console.WriteLine($"\t sampltTxt2 = {sampleTxt2}");
            Console.WriteLine($"\t ToLower = {sampleTxt2.ToLower()}");
            Console.WriteLine($"\t ToUpper = {sampleTxt2.ToUpper()}");
            Console.WriteLine($"\t sampltTxt2 = {sampleTxt2.Insert(0, "*")}");
            Console.WriteLine($"\t sampltTxt2 = {sampleTxt2.Remove(3, 5)}");

            Console.WriteLine("####");
            Console.Write("Trin={0}", "               홍 길 동           \n".Trim());
            Console.WriteLine("####");

            Console.WriteLine("####");
            Console.Write("Trin={0}", "               홍 길 동           \n".Replace(" ", ""));
            Console.WriteLine("####");

        }

        public static void lesson2_split_method()
        {
            string sampleText = "C# Java Python";
            Console.WriteLine(sampleText);
            Console.WriteLine(sampleText.Substring(2));
            Console.WriteLine(sampleText.Substring(8));

            string[] arr = sampleText.Split();

            Console.WriteLine($"\t arr = {arr}");
            Console.WriteLine($"\t arr = {arr[0]},{arr[1]},{arr[2]}");

            foreach (var item in arr)
            {
                Console.WriteLine($"\t {item}");
            }
        }

        public static void lesson3()
        {
            int x = 10, y = 20, z = 30;
            Console.WriteLine($"{x}+{y}+{z}={x+y+z}");
        }

        public static void lesson3_string_formating()
        {
            string sample1 = "가나다라마바사";
            Console.WriteLine("\t*{0,20}*", sample1);
            Console.WriteLine("\t*{0,-20}*", sample1);

        }

        public static void lesson3_number_formatting()
        {
            Console.WriteLine("\t 10진수 => {0:D10}", 12345);
            Console.WriteLine("\t 16진수 => {0}", 0X32A);
            Console.WriteLine("\t 16진수 => {0:X}", 0X32A);
            Console.WriteLine("\t 16진수 => {0:X10}", 0X32A);
            Console.WriteLine("\t N => {0}", 10000000000);
            Console.WriteLine("\t N => {0:N}", 10000000000);
            Console.WriteLine("\t N => {0:N0}", 10000000000);
            Console.WriteLine("\t F => {0:F}", 1234.5678); // 1234.57
            Console.WriteLine("\t F => {0:F3}", 1234); // 1234.000
            Console.WriteLine("\t F => {0:F0}", 1234.5678); // 1235
            Console.WriteLine("\t F => {0:F7}", 1234.5678);// 1234.5678000
            // {인덱스:E소숫점아래표시숫자} 
            Console.WriteLine("\t E => {0:E}", 1234.5678);// 1.234568E+003
            Console.WriteLine("\t E => {0:E2}", 1234.5678);// 1.23E+003
            Console.WriteLine("\t E => {0:E5}", 1234.5678);// 1.23457E+003
        }


        static void Main(string[] args)
        {
            //lesson1();

            //lesson1_default();

            //lesson1_search_method();

            //lesson1_string_method();

            //lesson2_string_method();

            //lesson2_split_method();

            //lesson3();
            //lesson3_string_formating();

            lesson3_number_formatting();
        }
    }
}
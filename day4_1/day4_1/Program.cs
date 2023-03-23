using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_1
{
    internal class Program
    {
        private static string ReturnStr(string keyword)
        {
            Console.Write(keyword);
            return Console.ReadLine();
        }

        private static Dictionary<string, string> ReturnInputValue(Dictionary<string, string> keyword)
        {
            Dictionary<string, string> returnValue = new Dictionary<string, string>();

            foreach (string key in keyword.Keys)
            {
                string answer = ReturnStr(keyword[key]);
                returnValue.Add(key, answer);
            }

            return returnValue;
        }

        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        enum Language
        {
            C_language = 10,
            C_Plus = 20,
            C_Sharp = 30,
            Python = 40,
            JAVA = 50
        }

        static void Main(string[] args)
        {
            //LoopQuiz5();
            //LoopQuiz6();
            //LoopQuiz7();
            //LoopQuiz8();
            //LoopQuiz9();
            //LoopQuiz10();
            //LoopQuiz11();

            //ArrQuiz1();
            //ArrQuiz2();
            //ArrQuiz3();
            //ArrQuiz4();
            //ArrQuiz5();
            //ArrQuiz6();
            //ArrQuiz7();
            //ArrQuiz8();
            //ArrQuiz9();

            //EnumQuiz1();
            //EnumQuiz2();

        }

        public static void EnumQuiz2()
        {
            Console.WriteLine($"Num\tEnum");
            Console.WriteLine("==================");
            foreach (Language language in Enum.GetValues(typeof(Language)))
            {
                Console.WriteLine($"{(int)language}\t{language}");
            }
        }

        public static void EnumQuiz1()
        {
            foreach (Season season in Enum.GetValues(typeof(Season)))
            {
                Console.WriteLine($"0{(int)season + 1}\t{season}");
            }

            //Console.WriteLine($"01. {Season.Spring}");
            //Console.WriteLine($"02. {Season.Summer}");
            //Console.WriteLine($"03. {Season.Autumn}");
            //Console.WriteLine($"04. {Season.Winter}");
        }


        public static void ArrQuiz9()
        {
            int[,] middle_scores =
            {
                { 55, 88 },
                { 80, 78 },
                { 95, 77 },
            };
            string[] student_names = { "최은우", "마동탁", "박지민" };
            float[,] middle_scores2 = new float[3, 4];
            Console.WriteLine($"\t{"국어"}\t{"영어"}");
            for (int i = 0; i < middle_scores.GetLength(0); i++)
            {
                Console.Write($"{student_names[i]}\t");
                for (int k = 0; k < middle_scores.GetLength(1); k++)
                {
                    Console.Write($"{middle_scores[i, k]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine($"{"학생명"}\t{"국어"}\t{"영어"}\t{"총점"}\t{"평균"}");
            for (int i = 0; i < middle_scores.GetLength(0); i++)
            {
                Console.Write($"{student_names[i]}\t");
                for (int k = 0; k < middle_scores.GetLength(1); k++)
                {
                    middle_scores2[i, k] = middle_scores[i, k];
                    Console.Write($"{middle_scores2[i, k]:.00}\t");
                }
                middle_scores2[i, 2] = middle_scores[i, 0] + middle_scores[i, 1];
                middle_scores2[i, 3] = middle_scores2[i, 2] / 2;
                Console.Write($"{middle_scores2[i, 2]:.00}\t");
                Console.Write($"{middle_scores2[i, 3]:.00}\t");
                Console.WriteLine();
            }
        }


        public static void ArrQuiz8()
        {
            int[,] num2DArr = new int[3, 3];

            for (int i = 0; i < num2DArr.GetLength(0); i++)
            {
                for (int k = 0; k < num2DArr.GetLength(1); k++)
                {
                    if (i == k) num2DArr[i, k] = 1;
                    else num2DArr[i, k] = 0;

                    Console.Write($"{num2DArr[i, k],5}");
                }
                Console.WriteLine("\n");
            }
        }

        public static void ArrQuiz7()
        {
            int[,] num2DArr = new int[5, 5];

            for (int i = 0; i < num2DArr.GetLength(0); i++)
            {
                for (int k = 0; k < num2DArr.GetLength(1); k++)
                {
                    num2DArr[i, k] = (k + 1) * (i + 1) * 5;
                    Console.Write($"{num2DArr[i, k],5}");
                }
                Console.WriteLine();
            }
        }

        public static void ArrQuiz6()
        {
            string[,] userInfo = { { "홍길동","gildong","남"},
                                    { "신은주","eunju67","여"},
                                    { "김수홍","su7836","남"},
                                    { "최민호","minho6","남"},
                                    { "이수진","sujun77","여"}
};

            Console.WriteLine($"{"이 름"}\t{"아이디"}\t{"성 별"}");
            for (int i = 0; i < userInfo.Length; i++)
            {
                Console.WriteLine($"{userInfo[i, 0]}\t{userInfo[i, 1]}\t{userInfo[i, 2]}");
            }
        }

        public static void ArrQuiz5()
        {
            string[] grades = { "국어", "영어", "수학", "과학", "한문" };
            Dictionary<string, int> scores = new Dictionary<string, int>();
            foreach (string grade in grades)
            {
                scores.Add(grade, Convert.ToInt32(ReturnStr($"{grade} 점수 => ")));
            }

            foreach (string grade in grades)
            {
                Console.WriteLine($"{grade} 점수 => {scores[grade]}");
            }
            Console.WriteLine($"합계 => {scores.Values.Sum()}");
            Console.WriteLine($"합계 => {scores.Values.Average():#.###}");
            Console.WriteLine($"합계 => {"FFFFFFDCBAA"[Convert.ToInt32(scores.Values.Average()) / 10]}");

        }

        public static void ArrQuiz4()
        {
            int length = Convert.ToInt32(ReturnStr("배열 길이 입력 => "));
            string[] fruit = new string[length];
            for (int i = 0; i < length; i++)
            {
                fruit[i] = ReturnStr($"{i} 배열값 => ");
            }

            foreach (string key in fruit)
            {
                Console.WriteLine(key);
            }
        }


        public static void ArrQuiz3()
        {
            string[] nameArr = { "민호", "수진", "석진", "남준", "태형" };

            Console.WriteLine($"첫번째 배열값 출력 : {nameArr[0]}");
            Console.WriteLine($"세번째 배열값 출력 : {nameArr[2]}");
            Console.WriteLine("배열 모두 출력하기");
            foreach (string name in nameArr)
            {
                Console.WriteLine($"=> {name}");
            }
        }

        public static void ArrQuiz2()
        {
            string[] countryArr = new string[7];

            for (int i = 0; i < countryArr.Length; i++)
            {
                countryArr[i] = ReturnStr($"{i}번째 배열값 => ");
            }

            foreach (string country in countryArr)
            {
                Console.WriteLine($"=> {country}");
            }
        }

        public static void ArrQuiz1()
        {
            int[] scoreArr = { 65, 77, 55 };
            Console.WriteLine($"총점 = {scoreArr.Sum()}");
            Console.WriteLine($"평균 = {scoreArr.Average():#.###}");
        }


        public static void LoopQuiz11()
        {
            string word = "apple apart ant apply aribaba";
            foreach (char c in word)
            {
                Console.Write(c == 'a' || c == 'l' ? '*' : c);
            }
            //word = word.Replace("a", "*").Replace("l", "*");
            //Console.WriteLine(word);
        }

        public static void LoopQuiz10()
        {
            Dictionary<string, string> user = ReturnInputValue(new Dictionary<string, string>()
            {
                {"Name", "이름..." },
                {"Id", "아이디..." }
            });

            Console.Write(user["Name"][0]);
            for (int i = 1; i < user["Name"].Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write(user["Id"][0]);
            for (int i = 1; i < user["Id"].Length - 1; i++)
            {
                Console.Write("*");
            }
            Console.Write(user["Id"][user["Id"].Length - 1]);
            Console.WriteLine();
        }

        public static void LoopQuiz9()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 4 - i; k > 0; k--) Console.Write("  ");
                for (int k = 0; k <= i * 2; k++) Console.Write("* ");
                Console.WriteLine();
            }
        }

        public static void LoopQuiz8()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 5 - i; k > 0; k--) Console.Write("* ");
                Console.WriteLine();
            }
        }

        public static void LoopQuiz7()
        {
            for (int i = 1; i <= 6; i++)
            {
                Console.Write("{0,-8}", i);
                for (int k = 0; k < 6; k++) Console.Write("{0, -2}", "*");
                Console.WriteLine();
            }
        }

        public static void LoopQuiz6()
        {
            int count = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0,5} ", i);
                    if (++count % 5 == 0) Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public static void LoopQuiz5()
        {
            int num = Convert.ToInt32(ReturnStr("입력 숫자=>"));
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(String.Format("{0} x {1} = {2}", num, i, num * i));
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day3_1
{

    delegate void MulticastDelegate();

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

            foreach(string key in keyword.Keys)
            {
                string answer = ReturnStr(keyword[key]);
                returnValue.Add(key, answer);
            }

            return returnValue;
        }



        static void Main(string[] args)
        {
            //MulticastDelegate multi = null;
            //multi += new MulticastDelegate(LoopQuiz1);
            //multi += new MulticastDelegate(LoopQuiz2);
            //multi += new MulticastDelegate(LoopQuiz3);

            //multi();
            //ConditionEx1();
            //ConditionQuiz1();
            //ConditionQuiz2();
            //ConditionQuiz3();
            //ConditionQuiz4();
            //ConditionQuiz5();

            //LoopQuiz1();
            //LoopQuiz2();
            //LoopQuiz3();
            //LoopQuiz4();
            //LoopQuiz5();
            //LoopQuiz6();
            //LoopQuiz7();
            //LoopQuiz8();
            LoopQuiz9();
            //LoopQuiz10();
            //LoopQuiz11();
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
            /*
             *            *             i = 0
             *          * * *           i = 1
             *        * * * * *         i = 2
             *      * * * * * * *       i = 3
             *    * * * * * * * * *     i = 4
             *   
             *   먼저, 앞에 공백을 입력한 후, *을 찍습니다.
             *   공백을 위한 for문, 별을 찍기위한 for문을 별개로 두어야 합니다.
             *   
             *   ________*             i = 0
             *   ______* * *           i = 1
             *   ____* * * * *         i = 2
             *   __* * * * * * *       i = 3
             *   * * * * * * * * *     i = 4
             *   
             */
            for (int i = 0; i < 5; i++)
            {
                /* 
                 * 공백 추가 코드 
                 * int k = 4-i라고 작성하면 i가 증가할 때마다
                 * k값이 점점 줄어듭니다. 
                 * 즉, 공백이 점점 줄어드는 것을 구현할 수 있습니다.
                 */
                for (int k = 4 - i; k > 0; k--)
                {
                    Console.Write("  ");
                }

                /* 
                 * 별 찍기 코드 
                 * k가 0부터, i*2한 값까지 반복합니다.
                 * 처음 반복에는(i가 0일때) i*2를 해도 * 한개만 찍히지만
                 * 그 다음 반복(i가 1일때)에서는 i(1) * 2 => 2, k는 0부터 시작하므로 i값까지 0, 1, 2 총 3번 반복한다.
                 * 그 다음에는 i(2) * 2 = 4 -> 0, 1, 2, 3, 4 총 5번 반복한다.
                 */
                for (int k = 0; k <= i * 2; k++)
                {
                    Console.Write("* ");
                }
                /* 줄바꿈용 코드 */
                Console.WriteLine();
            }
        }

        public static void LoopQuiz8()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 5 - i; k > 0; k--)
                {
                    Console.Write("* ");
                }
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

        public static void LoopQuiz4()
        {
            int num = 1;
            int total = 0;
            do
            {
                num++;
                if (num % 7 == 0 || num % 11 == 0)
                {
                    Console.Write("{0, 5}", num);
                    if (total++ > 0 && total % 5 == 0) Console.WriteLine();
                }
            } while (num < 100);
            Console.WriteLine("\n총 갯수는? {0}", total);
        }

        public static void LoopQuiz3()
        {
            string s = "";
            StringBuilder stringBuilder = new StringBuilder();
            while (!(s.Equals("q")))
            {
                stringBuilder.Append(s).Append(" ");
                Console.WriteLine("Q나 q를 입력하면 입력이 종료됩니다.");
                s = ReturnStr("종목 >> ");
                Console.WriteLine();
            }
            Console.WriteLine("입력이 종료되었습니다.");
            Console.WriteLine("보유 주식 종목 : {0}", stringBuilder);
        }

        public static void LoopQuiz2()
        {
            int i = 1;
            while (i++ < 10)
            {
                Console.WriteLine(string.Format("{0,5}{1}", i, "단"));
                int k = 0;
                while (k++ < 10)
                {
                    Console.WriteLine(String.Format("{0} x {1} = {2}", i, k, k * i));
                }
            }
        }

        public static void LoopQuiz1()
        {
            int num = Convert.ToInt32(ReturnStr("입력 숫자=>"));
            int i = 1;
            while (i < 10)
            {
                Console.WriteLine(String.Format("{0} x {1} = {2}", num, i, num * i));
                i++;
            }
        }

        public static void ConditionQuiz6()
        {

            int year = Convert.ToInt32(ReturnStr("출생년도 입력 >>> "));
            string[] zodiacSign = { "원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양" };
            string result = default(string);

            //Console.WriteLine($"{year}년생은 {zodiacSign[year%12]}띠입니다.");
            switch (year % 12)
            {
                case 0: result = zodiacSign[0]; break;
                case 1: result = zodiacSign[1]; break;
                case 2: result = zodiacSign[2]; break;
                case 3: result = zodiacSign[3]; break;
                case 4: result = zodiacSign[4]; break;
                case 5: result = zodiacSign[5]; break;
                case 6: result = zodiacSign[6]; break;
                case 7: result = zodiacSign[7]; break;
                case 8: result = zodiacSign[8]; break;
                case 9: result = zodiacSign[9]; break;
                case 10: result = zodiacSign[10]; break;
                case 11: result = zodiacSign[11]; break;
                default: break;
            }
            Console.WriteLine($"{year}년생은 {zodiacSign[year % 12]}띠입니다.");
        }

        public static void ConditionQuiz5()
        {
            int s = Convert.ToInt32(ReturnStr("점수를 입력하세요: "));
            char grade = "FFFFFFDCBAA"[s / 10];
            Console.WriteLine($"학점은 {grade}");

            string grade2 = "";
            switch (s / 10)
            {
                case 10:
                case 9: grade2 = "A"; break;
                case 8: grade2 = "B"; break;
                case 7: grade2 = "C"; break;
                case 6: grade2 = "D"; break;
                default: grade2 = "F"; break;
            }
            Console.WriteLine("학점은 {0}", grade2);

            
        }

        public static void ConditionQuiz4()
        {
            int result = Convert.ToInt32(ReturnStr("가장 좋아하는 프로그래밍 언어를 입력하시오.\n1.C  2.C++  3.C#  4.JAVA\n\n입력=>"));
            string str;
            switch (result)
            {
                case 1: str = "C"; break;
                case 2: str = "C++"; break;
                case 3: str = "C#"; break;
                case 4: str = "JAVA"; break;
                default: str = "잘못된 선택"; break;
            }
            Console.WriteLine(str);
        }

        public static void ConditionQuiz3()
        {
            Dictionary<string, string> bmiInfo = ReturnInputValue(new Dictionary<string, string>()
            {
                {"Height", "키를 입력하세요(cm): " },
                {"Weight", "몸무게를 입력하세요(Kg): " }
            });

            double height = Convert.ToDouble(bmiInfo["Height"]) / 100;
            double weight = Convert.ToDouble(bmiInfo["Weight"]);

            double bmi = weight / (height * height);
            char bmiResult = "LLLLNOFFHHH"[Convert.ToInt32(bmi / 5)];

            string result = default(string);
            if (bmiResult == 'L') result = "저체중";
            else if (bmiResult == 'N') result = "정상체중";
            else if (bmiResult == 'O') result = "경도비만";
            else if (bmiResult == 'F') result = "비만";
            else if (bmiResult == 'H') result = "고도비만";

            Console.WriteLine($"BMI = {bmi:0.#}, {result}입니다.");
        }

        public static void ConditionQuiz2()
        {
            int score = Convert.ToInt32(ReturnStr("점수=>"));
            char grade = "FFFFFFFCBAA"[(score / 10)];
            string result;

            if (grade == 'A') result = "축하합니다.\n금메달을 수상하셨습니다..";
            else if (grade == 'B') result = "축하합니다.\n은메달을 수상하셨습니다..";
            else if (grade == 'C') result = "축하합니다.\n동메달을 수상하셨습니다..";
            else result = $"{score}점. 수고하셨습니다.";

            Console.WriteLine(result);
        }


        public static void ConditionQuiz1()
        {
            Dictionary<string, string> answer = ReturnInputValue(new Dictionary<string, string>()
            {
                { "First", "첫 번째 수 입력: " },
                { "Second", "두 번째 수 입력: " }
            });

            int num1 = Convert.ToInt32(answer["First"]);
            int num2 = Convert.ToInt32(answer["Second"]);
            string result = default(string);
            int calc = 0;
            if (num1 > num2)
            {
                result = "첫 번째 수";
                calc = num1 - num2;
            }
            else if (num2 > num1)
            {
                result = "두 번째 수";
                calc = num2 - num1;
            }
            else result = "입력 숫자가 같다.";


            Console.WriteLine(calc == 0 ? result : $"{result}가 {calc} 더 크다");

        }

        public static void ConditionEx1()
        {
            string id = "UserName";
            string pwd = "Password";

            Dictionary<string, string> answer = ReturnInputValue(new Dictionary<string, string>
            {
                {id, "Enter to Username: " },
                {pwd, "Enter to Password: " }
            });

            Dictionary<string, string> currentUser = new Dictionary<string, string>
            {
                {id, "User1234" },
                {pwd, "P@ssw0rd" },
            };

            if (answer[id].Equals(currentUser[id]) && answer[pwd].Equals(currentUser[pwd]))
            {
                Console.WriteLine(String.Format("Welcome back, {0}.", currentUser[id]));
            }
            else
            {
                Console.WriteLine("Access Deined. Please check your name or password");
            }
        }
    }
}

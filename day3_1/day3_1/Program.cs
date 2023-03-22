using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_1
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

            foreach(string key in keyword.Keys)
            {
                string answer = ReturnStr(keyword[key]);
                returnValue.Add(key, answer);
            }

            return returnValue;
        }


        static void Main(string[] args)
        {
            //ConditionEx1();
            //ConditionQuiz1();
            //ConditionQuiz2();
            ConditionQuiz3();



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

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Collections;

namespace Day9_1
{
    class Student
    {
        private int No;
        public int no
        {
            get { return this.No; }
            set { this.No = (value >= 3000 && value < 4000) ? value : 0; }
        }

        private int Grade;
        public int grade
        {
            get { return this.Grade; }
            set { this.Grade = (value >= 1 && value <= 4) ? value : 0; }
        }
        private char Gender;
        public char gender
        {
            get { return this.Gender; }
            set
            {
                this.Gender = (Gender == 'F' || Gender == 'M') ? value : 'U';
            }
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.no = 2900;
            //Console.WriteLine($"{student.no}");
            //student.no = 3100;
            //Console.WriteLine($"{student.no}");
            //student.no = 3500;
            //Console.WriteLine($"{student.no}");
            //student.no = 4000;
            //Console.WriteLine($"{student.no}");
            /*
            List<string> questions = new List<string>
            {
                "좋아하는 음식은? ",
                "최근 본 영화는? ",
                "좋아하는 가수는? ",
                "좋아하는 숫자? ",
                "최근 여행지? ",
            };

            ArrayList answers = new ArrayList();

            foreach (string question in questions)
            {
                Console.Write(question);
                answers.Add(Console.ReadLine());
            }
            
            Console.Write("[");
            foreach (string answer in answers)
            {
                Console.Write($"'{answer}', ");
            }
            
            Console.Write("\b\b]");
            */

            /*
            ArrayList snacks = new ArrayList { "사과", "망고", "치즈케이크", "주스" };

            Console.Write("우리집 냉장고에는? ");
            Console.Write("[");
            foreach (string snack in snacks) Console.Write($"'{snack}', ");
            Console.WriteLine("\b\b]");

            Console.WriteLine("동생이 사과를 먹었다.");
            snacks.Remove("사과");

            Console.Write("우리집 냉장고에는? ");
            Console.Write("[");
            foreach (string snack in snacks) Console.Write($"'{snack}', ");
            Console.WriteLine("\b\b]");

            Console.WriteLine("이모가 수박을 사오셨다.");
            snacks.Add("수박");


            Console.Write("우리집 냉장고에는? ");
            Console.Write("[");
            foreach (string snack in snacks) Console.Write($"'{snack}', ");
            Console.WriteLine("\b\b]");

            Console.WriteLine("동생 친구가 치즈케이크, 수박을 먹었다.");
            snacks.Remove("치즈케이크");
            snacks.Remove("수박");

            Console.Write("우리집 냉장고에는? ");
            Console.Write("[");
            foreach (string snack in snacks) Console.Write($"'{snack}', ");
            Console.WriteLine("\b\b]");
            */

            //Stack stack = new Stack();
            //string before = "도레미파솔라시";
            //for(int i = 0; i<before.Length; i++)
            //{
            //    stack.Push(before[i]);
            //}
            //for (int i = 0; i < stack.Count; i++)
            //{
            //    Console.Write($"{stack.Pop()} = ");
            //}

            //int[] n = Enumerable.Range(0, 15)
            //    .Select(i => 3 + i * 3)
            //    .ToArray();
            //Queue queue = new Queue();
            //for (int i = 0; i < n.Length; i++)
            //{
            //    queue.Enqueue(n[i]);
            //}
            //for (int i = 0; i < n.Length; i++)
            //{
            //    Console.Write($"^{queue.Dequeue()} ");
            //}

            //string myWord = "banana fruit orange apple mango";
            //Hashtable hashtable = new Hashtable();
            //string[] myWords = myWord.Split();

            //for (int i = 0; i < myWords.Length; i++)
            //{
            //    hashtable.Add(myWords[i][0], myWords[i]);
            //}

            //foreach (var key in hashtable.Keys)
            //{
            //    Console.WriteLine(hashtable[key]);
            //}

            string[] routes = { "E 2", "S 2", "W 1" };
            for (int i = 0; i < routes.Length; i++)
            {
                int direction = -1;
                string[] route = routes[i].Split();
                switch (route[0])
                {
                    case "N": direction = 0; break;
                    case "E": direction = 1; break;
                    case "S": direction = 2; break;
                    case "W": direction = 3; break;
                }
                int distance = int.Parse(route[1]);


            }
        }

    }
}

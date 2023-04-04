using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            while ((N = int.Parse(Console.ReadLine())) != -1)
            {
                int sum = 0;

                List<int> list = new List<int>();

                for (int i = 1; i <= N / 2; i++)
                {
                    if (N % i == 0)
                    {
                        list.Add(i);
                        sum += i;
                    }
                }


                if (sum == N)
                {
                    Console.WriteLine($"{N} = {string.Join(" + ", list)}");
                }
                else
                {
                    Console.WriteLine($"{N} is NOT perfect");
                }

            }
        }
    }
}

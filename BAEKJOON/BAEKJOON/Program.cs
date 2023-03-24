using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    internal class Program
    {
        
        private struct Point
        {
            public int x, y;
            public Point(int x, int y)
            {
                this.x = x; this.y = y;
            }
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] paper = new int[10000];
            for (int i = 0; i < N; i++)
            {
                var s = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int x = s[0], y = s[1], xMax = x+10, yMax = y+10;
                for (int j = y; j < yMax; j++)
                {
                    for (int k = x; k < xMax; k++)
                    {
                        paper[j * 100 + k] = 1;
                    }
                }
            }
            Console.WriteLine(paper.Count(x => x == 1));







        }
    }
}

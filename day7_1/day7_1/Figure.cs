using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day7_1
{
    internal class Figure
    {
        private double[] datas;

        public Figure(double Radius)
        {
            datas = new double[1];
            datas[0] = Radius;
            
        }

        public Figure(double width, double height)
        {
            datas = new double[2];
            datas[0] = width;
            datas[1] = height;
            
        }

        public Figure(double upper, double lower, double height)
        {
            datas = new double[3];
            datas[0] = upper;
            datas[1] = lower;
            datas[2] = height;
        }

        public void PrintInfo()
        {
            if (datas.Length == 1)
            {
                Console.WriteLine("타원 도형 정보");
                Console.WriteLine($"반지름 : {datas[0]} cm");
                Console.WriteLine($"넓이 : {Math.PI * datas[0] * datas[0]} cm");
            }
            else if (datas.Length == 2)
            {
                Console.WriteLine("사각형 도형 정보");
                Console.WriteLine($"가로 : {datas[0]} cm");
                Console.WriteLine($"세로 : {datas[1]} cm");
                Console.WriteLine($"넓이 : {datas[0] * datas[1]} cm");
            }
            else if(datas.Length == 3)
            {
                Console.WriteLine("사다리꼴 도형 정보");
                Console.WriteLine($"윗변 : {datas[0]} cm");
                Console.WriteLine($"아랫변 : {datas[1]} cm");
                Console.WriteLine($"높이 : {datas[2]} cm");
                Console.WriteLine($"넓이 : {(datas[0] + datas[1]) * datas[2] / 2} cm");

            }
        }



    }
}

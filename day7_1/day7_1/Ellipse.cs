using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_1
{
    internal class Ellipse
    {
        string Name;
        double Radius;

        public Ellipse(string name, double radius)
        {
            this.Name = name;
            this.Radius = radius;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name : {this.Name}");
            Console.WriteLine($"Radius : {this.Radius:#.###}");
            Console.WriteLine($"원의 넓이 : {GetArea1():#.###}");
            Console.WriteLine($"원의 넓이 : {GetArea2()} ");
        }

        private double GetArea1()
        {
            return Math.PI * Radius * Radius;
        }

        private string GetArea2()
        {
            return $"{this.Radius:#.###} * {this.Radius:#.###} * {Math.PI:#.##} = {GetArea1():#.###}";
        }
    }
}

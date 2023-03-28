using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_1
{
    internal class Program
    {



        static void Main(string[] args)
        {
            //Ellipse quiz1 = new Ellipse("Green", 1.5);
            //quiz1.PrintInfo();

            //BookManager bookManager1 = new BookManager(
            //    new Book(9788932917245, "어린왕자", "생텍쥐페리", 15000)
            //);

            //BookManager bookManager2 = new BookManager(
            //    new Book(9791162243770, "이것이 C#이다", "박상현", 35000)
            //);

            //bookManager1.PrintBookInfo(0.25);
            //bookManager2.PrintBookInfo(0.3);

            //Figure circle = new Figure(2.5);
            //Figure square = new Figure(4.5, 3.0);
            //Figure trapezoid = new Figure(1.5, 3.0, 2.5);

            //circle.PrintInfo();
            //square.PrintInfo();
            //trapezoid.PrintInfo();
            
            //Console.WriteLine($"\t{2009}년 생은 {Zodiac.GetZodiac(2009)} 띠");
            //Console.WriteLine($"\t{2009}년 생은 {Zodiac.GetZodiac(2023)} 띠");
            //Console.WriteLine($"\t{2009}년 생은 {Zodiac.GetZodiac(1997)} 띠");

            Tyranno tyranno = new Tyranno();
            tyranno.Sleep();
            tyranno.Hunt();
            tyranno.Eat();

            Console.WriteLine();

            Dooly dooly = new Dooly();
            dooly.Sleep();
            dooly.Eat();
            dooly.Dance();
            dooly.Sing();
        }
    }


}

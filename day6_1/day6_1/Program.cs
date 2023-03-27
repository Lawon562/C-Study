using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_1
{
    internal class Program
    {
        struct Trapezoid
        {
            public string Name;
            public double Height;
            public double Topbase;
            public double Bottombase;

            public Trapezoid(string name, double height, double topbase, double bottombase)
            {
                this.Name = name;
                this.Height = height;
                this.Topbase = topbase;
                this.Bottombase = bottombase;
            }

        }
        
        public static void Quiz1()
        {
            Trapezoid trapezoid = new Trapezoid();
            trapezoid.Name = "사다리꼴A";
            trapezoid.Height = 50;
            trapezoid.Topbase = 120;
            trapezoid.Bottombase = 230;
            Console.WriteLine($"{trapezoid.Name}");
            Console.WriteLine($"윗변 = {trapezoid.Topbase}cm");
            Console.WriteLine($"아랫변 = {trapezoid.Bottombase}cm");
            Console.WriteLine($"높이 = {trapezoid.Height}cm");
            Console.WriteLine($"넓이 = {(trapezoid.Topbase + trapezoid.Bottombase) * trapezoid.Height / 2}cm");
        }

        public static void Quiz2()
        {
            Trapezoid trapezoid = new Trapezoid("사다리꼴A", 50, 120, 230);
            Console.WriteLine($"{trapezoid.Name}");
            Console.WriteLine($"윗변 = {trapezoid.Topbase}cm");
            Console.WriteLine($"아랫변 = {trapezoid.Bottombase}cm");
            Console.WriteLine($"높이 = {trapezoid.Height}cm");
            Console.WriteLine($"넓이 = {(trapezoid.Topbase + trapezoid.Bottombase) * trapezoid.Height / 2}cm");
        }

        struct Book
        {
            long ISBN;
            string Name;
            string Author;
            int price;

            public Book(long isbn, string name, string author, int price)
            {
                this.ISBN = isbn;
                this.Name = name;
                this.Author = author;
                this.price = price;
            }

            
            public override string ToString()
            {
                return $"ISBN: {this.ISBN}\n제  목: {this.Name}\n저  자: {this.Author}\n정  가: {this.price}";
            }

            public void PrintPrice(int amount)
            {
                Console.WriteLine($"할인가({amount}%) : {this.price - this.price * 25 / 100}원");
            }
        }

        public static void Quiz3()
        {
            Book book1 = new Book(9788932917245, "어린왕자", "생텍쥐페리", 15000);
            Book book2 = new Book(9791162243770, "이것이 C#이다", "박상현", 35000);

            Console.WriteLine(book1.ToString());
            Console.WriteLine(book2.ToString());

        }

        struct Customer
        {
            string Name;
            string Id;
            int Age;
            string Residence;

            public Customer(string name, string id, int age, string residence)
            {
                this.Name = name;
                this.Id = id;
                this.Age = age;
                this.Residence = residence;
            }

            public override string ToString()
            {
                
                string sName = this.Name[0] + "**";
                string sId = this.Id[0].ToString();
                for (int i = 0; i < this.Id.Length-1; i++) sId += "*";
                sId += this.Id[Id.Length - 1].ToString();
                

                return $"고객명 => {sName}\nID => {sId}\n나이 => {this.Age}\n거주지 => {this.Residence}";
            }
        }

        public static void Quiz4()
        {
            //Customer c1 = new Customer("김철수", 33, "서울");
            //Customer c2 = new Customer("마동탁", 45, "대구");
            //Customer c3 = new Customer("이민주", 25, "전주");

            //Console.WriteLine(c1.ToString());
            //Console.WriteLine(c2.ToString());
            //Console.WriteLine(c3.ToString());
        }

        struct Triangle
        {
            public string Name;
            public double Width;
            public double Height;

            public Triangle(string name, double width, double height)
            {
                this.Name = name;
                this.Width = width;
                this.Height = height;
            }

            public override string ToString()
            {
                return $"Name: {this.Name}, Width: {this.Width}, Height: {this.Height}";
            }
        }

        public static void Quiz5()
        {
            Triangle triangle = new Triangle("정삼각형", 5, 5);
            Console.WriteLine(triangle.Name);
            Console.WriteLine($"가로크기 = {triangle.Width}cm");
            Console.WriteLine($"세로크기 = {triangle.Height}cm");
            Console.WriteLine($"넓이= {triangle.Width*triangle.Height/2:0.00}cm");
            
        }

        public static void Quiz6()
        {
            Book book1 = new Book(9788932917245, "어린왕자", "생텍쥐페리", 15000);
            Book book2 = new Book(9791162243770, "이것이 C#이다", "박상현", 35000);

            Console.WriteLine(book1.ToString());
            book1.PrintPrice(25);
            Console.WriteLine(book2.ToString());
            book2.PrintPrice(30);
        }

        public static void Quiz7()
        {
            Customer c1 = new Customer("이민주", "lee123456789", 25, "전주");
            Customer c2 = new Customer("김철수", "kim1234", 33, "서울");
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
        }

        static void Main(string[] args)
        {
            Quiz1();
            Quiz2();
            Quiz3();
            Quiz4();
            Quiz5();
            Quiz6();
            Quiz7();
        }
    }
}

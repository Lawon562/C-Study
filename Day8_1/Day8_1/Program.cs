using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Day8_1
{
    abstract class Animal
    {
        public void Run()
        {
            Console.WriteLine($"엄청 빨리 달린다");
        }

        public abstract void Hunt(string What, string Where);
        public abstract void Sleep(int time, string Where);
    }

    class Tiger : Animal
    {
        public override void Hunt(string What, string Where)
        {
            Console.WriteLine($"호랑이가 {Where}에서 {What}을/를 사냥한다.");
        }

        public override void Sleep(int time, string Where)
        {
            Console.WriteLine($"호랑이가 {time}시간을 {Where}에서 잤다.");
        }
    }

    class Cat : Animal
    {
        public override void Hunt(string What, string Where)
        {
            Console.WriteLine($"고양이가 {Where}에서 {What}을/를 사냥한다.");
        }

        public override void Sleep(int time, string Where)
        {
            Console.WriteLine($"고양이가 {time}시간을 {Where}에서 잤다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            tiger.Sleep(7, "동굴");
            tiger.Hunt("바다","물고기");

            Cat cat = new Cat();
            cat.Sleep(3, "침대");
            cat.Hunt("공원", "쥐");
        }
    }
}

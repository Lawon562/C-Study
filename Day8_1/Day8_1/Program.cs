using Microsoft.SqlServer.Server;
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

    interface IDino
    {
        void Eat(string what);
        void Sleep(string where);
        void Play(int num);
        void Today(string what, int num, string where);
    }

    class Tyrano : IDino
    {
        public void Eat(string what)
        {
            Console.WriteLine($"{what} 을/를 먹는다.");
        }

        public void Play(int num)
        {
            Console.WriteLine($"친구 {num} 명과 놀고 있다.");
        }

        public void Sleep(string where)
        {
            Console.WriteLine($"{where} 에서 잔다");
        }

        public void Today(string what, int num, string where)
        {
            Console.WriteLine($"===== 티라노 티티의 하루 일상 =====");
            Eat(what);
            Play(num);
            Sleep(where);
        }
    }


    interface ITiger
    {
        void Jump();
        void Cry_tiger();
    }

    interface ILion
    {
        void Bite();
        void Cry_lion();
    }

    interface ILiger : ITiger, ILion
    {
        void Play(string what);
    }

    class Liger : ILiger
    {
        public string Name;
        public Liger(string name)
        {
            this.Name = name;
        }

        public void Bite()
        {
            Console.WriteLine("사자처럼 한입에 꿀꺽하기");
        }

        public void Cry_lion()
        {
            Console.WriteLine("사자처럼 으르렁 ~~~");
        }

        public void Cry_tiger()
        {
            Console.WriteLine("호랑이처럼 어흥 ~~~");
        }

        public void Jump()
        {
            Console.WriteLine("호랑이처럼 점프하기");
        }

        public void Play(string what)
        {
            Console.WriteLine($"{what}와 놀기");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //Tiger tiger = new Tiger();
            //tiger.Sleep(7, "동굴");
            //tiger.Hunt("바다","물고기");

            //Cat cat = new Cat();
            //cat.Sleep(3, "침대");
            //cat.Hunt("공원", "쥐");


            //Tyrano tyrano = new Tyrano();
            //tyrano.Eat("고기");
            //tyrano.Eat("생선");
            //tyrano.Play(3);
            //tyrano.Today("사과", 2, "숲속");

            Liger liger = new Liger("꿈돌이");
            Console.WriteLine($"\t 라이거 {liger.Name}의 하루");
            liger.Cry_tiger();
            liger.Play("사육사");
            liger.Bite();
            liger.Cry_tiger();
            liger.Cry_lion();
            liger.Jump();
        }
    }
}

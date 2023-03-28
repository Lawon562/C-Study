using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_1
{
    internal class Dinosaur
    {
        string kind = "";

        public Dinosaur()
        {
            Console.WriteLine($"공룡 {kind}");
        }

        public void Eat()
        {
            Console.WriteLine("를/을 먹는다!!!");
        }

        public void Sleep()
        {
            Console.WriteLine("잔다!!!");
        }
    }

    class Tyranno : Dinosaur
    {
        string Name;

        public Tyranno()
        {
            Name = "티라노사우루스";
            Console.WriteLine($"공룡 {Name}");
        }

        public void Eat()
        {
            Console.WriteLine("물고기를/을 먹는다!!!");
        }

        public void Sleep()
        {
            Console.WriteLine("동굴에서 잔다!!!");
        }


        public void Hunt()
        {
            Console.WriteLine($"{this.Name}가 물고기를/을 사냥한다!!!");
        }
        
    }

    class Dooly : Dinosaur
    {
        string Name;

        public Dooly()
        {
            Name = "둘리";
            Console.WriteLine($"공룡 {Name}");
        }

        public void Eat()
        {
            Console.WriteLine("치킨를/을 먹는다!!!");
        }

        public void Sleep()
        {
            Console.WriteLine("공원에서 잔다!!!");
        }

        public void Sing()
        {
            Console.WriteLine($"{Name}가 노래한다!!!");
        }

        public void Dance()
        {
            Console.WriteLine($"{Name}가 춤춘다!!!");
        }
    }
}

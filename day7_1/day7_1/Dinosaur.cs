using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_1
{
    internal class Dinosaur
    {
        public string kind = "";

        public Dinosaur()
        {
            Console.Write($"공룡 ");
        }


        public void Eat(string something)
        {
            Console.WriteLine($"\t{something}를/을 먹는다!!!");
        }

        public void Sleep(string space)
        {
            Console.WriteLine($"\t{space}에서 잔다!!!");
        }
    }

    class Tyranno : Dinosaur
    {
        public Tyranno()
        {
            kind = "티라노사우루스";
            Console.WriteLine(kind);
        }


        public void Hunt(string something)
        {
            Console.WriteLine($"\t{this.kind}가 {something}를/을 사냥한다!!!");
        }
        
    }

    class Dooly : Dinosaur
    {

        public Dooly()
        {
            kind = "둘리";
            Console.WriteLine($"{kind}");
        }

        
        public void Sing()
        {
            Console.WriteLine($"\t{kind}가 노래한다!!!");
        }

        public void Dance()
        {
            Console.WriteLine($"\t{kind}가 춤춘다!!!");
        }
    }
}

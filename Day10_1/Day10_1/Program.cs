using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;

namespace Day10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] stringsArr = { "하나", "둘", "셋" };
            //Queue queue = new Queue(stringsArr);
            //try
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine(queue.Dequeue());
            //    }
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("오류 발생");
            //}
            //finally
            //{
            //    Console.WriteLine("예외처리 종료");
            //}

            //ArrayList list = new ArrayList();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("데이터를 입력하세요...");
            //    try
            //    {
            //        int data = int.Parse(Console.ReadLine());
            //        list.Add(data);
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine("오류 발생");
            //    }
            //    finally
            //    {
            //          Console.Write("\n\n numlist = ");
            //          // 대충 for문
            //    }
            //}
            //var line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //var line = Console.ReadLine().Split();

            //string N = line[0];
            //int B = int.Parse(line[1]);
            //long res = 0;
            //int count = N.Length-1;
            //foreach (char ch in N)
            //{
            //    int tmp = ((int)ch - 48) > 9 ? ch - 55 : ch - 48;
            //    res += tmp * ((long)Math.Pow(B,count--));                
            //}
            //Console.WriteLine(res);

            /*
            const string FILE_PATH = @"D:\WorkSpace230320\C-Study\national_anthem.txt";
            StreamReader inFp = new StreamReader(FILE_PATH);
            int i = 1;
            while (!inFp.EndOfStream)
            {
                Console.WriteLine($"{i++} : {inFp.ReadLine()}");
            }
            */
            /*
            const string FILE_PATH = @"D:\WorkSpace230320\C-Study\data_kor.txt";
            StreamReader inFp = new StreamReader(FILE_PATH);
            int sum = 0;
            int i = 0;
            while (!inFp.EndOfStream)
            {
                sum += int.Parse(inFp.ReadLine());
                i++;
            }
            Console.WriteLine($"총점: {sum}\n평균: {sum/i}");
            */
            /*
            const string FILE_PATH = @"D:\WorkSpace230320\C-Study\output\gugu.txt";
            StreamWriter outFp = new StreamWriter(FILE_PATH);

            for (int row = 1; row < 10; row++)
            {
                for (int col = 1; col < 10; col++)
                {
                    outFp.WriteLine($"{row} * {col} = {row*col}");
                }
            }
            outFp.Close();
            Console.WriteLine("파일 쓰기 완료");
            */
            //const string FILE_PATH = @"D:\WorkSpace230320\C-Study\output\sample.txt";
            //StreamWriter outFp = new StreamWriter(FILE_PATH);

            //int count = 0;
            //string s = "";
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0 || i % 11 == 0)
            //    {
            //        count++;
            //        s = $"{i, 3} ";
            //        if (count >= 5)
            //        {
            //            s += "\n";
            //            count = 0;
            //        }
            //        outFp.Write(s);
            //    }

            //}
            //outFp.Close();


            //string[] READ_FILE_PATH = 
            //{ 
            //    @"D:\WorkSpace230320\C-Study\data_kor.txt",
            //    @"D:\WorkSpace230320\C-Study\data_eng.txt"
            //};
            //const string WRITE_FILE_PATH = @"D:\WorkSpace230320\C-Study\output\score.txt";


            //Score[] scores = new Score[2];
            //StreamReader reader = default( StreamReader );
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    reader = new StreamReader(READ_FILE_PATH[i]);
            //    int count = 0;
            //    while (!reader.EndOfStream)
            //    {
            //        scores[i].Sum += int.Parse(reader.ReadLine());
            //        count++;
            //    }
            //    scores[i].Avg = scores[i].Sum / count;
            //    reader.Close();
            //}
            //StreamWriter writer = new StreamWriter(WRITE_FILE_PATH);
            //writer.WriteLine($"국어 총점 : {scores[0].Sum}, 평균 : {scores[0].Avg}");
            //writer.WriteLine($"영어 총점 : {scores[1].Sum}, 평균 : {scores[1].Avg}");
            //writer.Close();



            //const string READ_FILE_PATH = @"D:\WorkSpace230320\C-Study\national_anthem.txt";
            //const string WRITER_FILE_PATH = @"D:\WorkSpace230320\C-Study\output\1절.txt";

            //StreamReader inFp = new StreamReader(READ_FILE_PATH);
            //StreamWriter outFp = new StreamWriter(WRITER_FILE_PATH);

            //int i = 1;
            //StringBuilder sb = new StringBuilder();
            //while (!inFp.EndOfStream)
            //{   
            //    string s = ($"{inFp.ReadLine()}\n");
            //    if(i++ < 6) { sb.Append(s); }
            //}
            //inFp.Close();


            //outFp.Write(sb.ToString());
            //outFp.Close();  

            
            BigInteger[] line = Array.ConvertAll(Console.ReadLine().Split(), BigInteger.Parse);
            BigInteger res = line[0] + line[1];
            Console.WriteLine(res);





















        }
        //struct Score
        //{
        //    public string FilePath;
        //    public int Sum;
        //    public double Avg;
        //}
    }
}

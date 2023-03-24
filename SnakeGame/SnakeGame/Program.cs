using SnakeGame.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * 작성자 : 이라원
 * 작성일자 : 2023.03.24
 * 
 * 
 */
namespace SnakeGame
{
    internal class Program
    {
        public struct Point
        {
            public int x, y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            

            /* 윈도우를 정해진 크기로 설정하기*/
            Point window = new Point(Key.WINDOW_X, Key.WINDOW_Y);
            Console.SetWindowSize(window.x, window.y);


            /* 맵 UI 설정 */
            int posX = window.x/4;
            int posY = 0;

            Console.SetCursorPosition(posX, posY);
            for (int i = 0; i < Key.MAP_X; i++) Console.Write("■");
            Console.WriteLine();

            for (int k = 0; k < Key.MAP_Y - 2; k++)
            {
                for (int i = 0; i < posX; i++) Console.Write(" ");
                Console.Write("■");
                for (int i = 0; i < Key.MAP_X - 2; i++) Console.Write("  ");
                Console.WriteLine("■");
            }

            for (int i = 0; i < posX; i++) Console.Write(" ");
            for (int i = 0; i < Key.MAP_X; i++) Console.Write("■");

            // Player 생성
            posX = Key.MAP_X + posX - 1;
            posY = Key.MAP_Y / 2;
            Console.SetCursorPosition(posX, posY);

            Console.Write("○");
            HashSet<Point> Player = new HashSet<Point>();
            Player.Add(new Point(posX, posY));

            int playerBodyLength = 5;
            for (int i = 1; i <= playerBodyLength; i++)
            {
                Console.Write("●");
                Player.Add(new Point(posX + i, posY));
            }

            int speed = 1000;
            int score = 0;
            while (true)
            {
                Thread.Sleep(speed);

                if (/* 만약 벽에 부딪히면 */) 
                    /*
                     * 반복 종료
                     */
                if (/* 만약 점수모양에 닿았다면 */)
                    /*
                     * 점수증가
                     * snake body 하나 추가
                     * snake 속도 증가
                     */
            }

            /*
             * 당신의 점수는?? 출력하기
             */
            Console.ReadLine();

        }
    }
}

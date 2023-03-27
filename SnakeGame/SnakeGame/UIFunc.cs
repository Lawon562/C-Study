using SnakeGame.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SnakeGame.Structure;

namespace SnakeGame
{

    public class UIFunc
    {
        public static void DrawElements(Point itemPoint, List<Point> Player, int direction)
        {
            UIFunc.DrawItem(itemPoint);     /* Item 출력 */
            Func.Move(Player, direction);   /* Player 이동시키기(Player, 원하는 방향) */
            Console.ForegroundColor = ConsoleColor.Green;
            UIFunc.DrawPlayer(Player);      /* Player 전체 그리기*/
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void DrawText(int x, int y, string[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.SetCursorPosition(x, y++);
                Console.Write(text[i]);
            }
        }

        public static void DrawText(int x, int y, string text)
        {
            int j = 0;
            Console.SetCursorPosition(x, y++);
            foreach (char ch in text)
            {
                if (++j % Key.MAP_X == 0)
                {
                    j = 0;
                    Console.SetCursorPosition(x, y++);
                }
                Console.Write(ch);
            }
        }

        public static void DrawUI()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            DrawMap();
            Console.ForegroundColor = ConsoleColor.Green;
            DrawText(0, 0, Key.TITLE_TEXT);
            DrawText(0, 10, Key.GAME_DESCRIPTION);
            Console.ForegroundColor = ConsoleColor.Black;
            DrawButton();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void DrawButton()
        {
            Console.SetCursorPosition(2, 26);
            for (int i = 0; i < 24; i++)
            {
                //Console.BackgroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write(" ");
            }
            Console.SetCursorPosition(4, 26);
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write($"{"press enter to start",23 / 2 + 2}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //int x = Key.SCORE_TEXT_X + 2;
            //int y = Key.MAP_Y / 2 + 1;
        }

        public static void DrawNumber(string[] target, int xOffset)
        {
            int x = Key.SCORE_TEXT_X + xOffset;
            int y = Key.SCORE_TEXT_Y + 10;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < target.Length; i++)
            {
                Console.WriteLine(target[i]);
                Console.SetCursorPosition(x, ++y);
            }
        }

        public static void DrawScore(string eScore, int score)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            string[] target;
            target = Func.GetScoreText(eScore[eScore.Length - 1]);
            DrawNumber(target, 18);
            if (score >= 10)
            {
                target = Func.GetScoreText(eScore[eScore.Length - 2]);
                DrawNumber(target, 9);
            }
            if (score >= 100)
            {
                target = Func.GetScoreText(eScore[eScore.Length - 3]);
                DrawNumber(target, 0);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        // UI
        public static void DrawMap()
        {
            /* 맵 UI 설정 */
            // 상단 벽 생성
            Console.SetCursorPosition(Key.MAP_START_X, Key.MAP_START_Y);
            for (int i = 0; i < Key.MAP_X; i++) Console.Write(Key.WALL_SHAPE);
            Console.WriteLine();

            // 양쪽 벽 생성
            for (int k = 0; k < Key.MAP_Y - 2; k++)
            {
                // 왼쪽 벽
                for (int i = 0; i < Key.MAP_START_X; i++) Console.Write(" ");
                Console.Write(Key.WALL_SHAPE);
                // 오른쪽 벽
                for (int i = 0; i < Key.MAP_X - 2; i++) Console.Write("  ");
                Console.WriteLine(Key.WALL_SHAPE);
            }

            // 하단 벽 생성
            for (int i = 0; i < Key.MAP_START_X; i++) Console.Write(" ");
            for (int i = 0; i < Key.MAP_X; i++) Console.Write(Key.WALL_SHAPE);
        }

        // UI
        public static void DrawItem(Point itemPoint)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(itemPoint.x, itemPoint.y);
            Console.Write(Key.ITEM_SHAPE);
            Console.ForegroundColor = ConsoleColor.White;
        }

        // UI
        public static void DrawPlayer(List<Point> Player)
        {
            int i = 0;
            do
            {
                Console.SetCursorPosition(Player[i].x, Player[i].y);
                if (i == 0) Console.Write(Key.PLAYER_HEAD);
                else Console.Write(Key.PLAYER_BODY);
            } while (++i < Player.Count);

        }

    }
}

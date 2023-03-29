using ConsoleTodoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolTodoApp
{
    public class Drawer
    {
        /* To-do의 Title ASCII ART를 지정된 색상으로 그려주는 메소드 */
        private static int DrawTitleHeader(ConsoleColor foreColor)
        {
            Console.ForegroundColor = foreColor;

            int y = 0;
            int length = StringTemplate.Title.Length;
            for(int i = 0; i< length; i++)
            {
                Console.SetCursorPosition(Key.TitlePositionStartX, y++);
                Console.WriteLine(StringTemplate.Title[i]);
            }
            
            // Title이 끝난 후 바로 다음 줄에 프로그램 정보를 출력하기 위해
            // 현재 커서의 y축 데이터를 반환한다.
            return y;
        }

        /* 프로그램의 정보를 출력하기 위한 메소드 */
        private static void DrawProgramInfo(int y, ConsoleColor foreColor)
        {
            Console.ForegroundColor = foreColor;

            int authorX = Key.ProgramDescriptionStartX - StringTemplate.Author.Length - 2;
            int dateX = Key.ProgramDescriptionStartX - StringTemplate.Date.Length;
            /* ConsoleHelper.WriteProgramInfo는 전달받은 x,y 위치에 string을 출력한다. */
            ConsoleHelper.WriteProgramInfo(authorX, y++, StringTemplate.Author);
            ConsoleHelper.WriteProgramInfo(dateX, y++, StringTemplate.Date);

            Console.ForegroundColor = foreColor;
        }

        /* Todo 프로그램의 타이틀을 출력해주는 메소드 */
        public static void DrawTitle()
        {
            Key.ForeColor = ConsoleColor.White;
            int y = DrawTitleHeader(foreColor: ConsoleColor.Red);
            DrawProgramInfo(y, foreColor: ConsoleColor.DarkGray);
            
            Console.ForegroundColor = Key.ForeColor;
        }

        public static void DrawInputCard(bool color)
        {
            DrawBox(Key.CardStartX, Key.InputCardBorderStartX, Key.todoListWidth, Key.todoListHeight, color);
            Console.SetCursorPosition(Key.todoListTextStartX, Key.todoListTextStartY);
            Console.Write(StringTemplate.CreateButtonText);
        }

        public static void DrawInputBox()
        {
            Drawer.DrawBox(Key.InputBoxBorderX, Key.InputBoxBordereY, Key.InputBoxWidth, Key.InputBoxHeight);
        }

        public static void DrawTodoCard(int count, int choiceIdx)
        {
            int x = Key.CardStartX;
            int y = Key.CardStartY + 7 * count;
            int width = Key.CardWidth;
            int height = Key.CardHeight;
            bool check = count % Program.TodoList.Count == choiceIdx ? true : false;

            DrawBox(x, y, width, height, check);

            // 몇 번째 카드인지 출력
            Console.SetCursorPosition(x - 1, y + 1);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" # {count + 1} ");

            // 카드에 to-do 출력
            Console.SetCursorPosition(x + 2, y + 3);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" To-do : ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($" {Program.TodoList[count].Context} ");
            Console.SetCursorPosition(x + 2, y + Key.CardHeight);

            // 카드에 태그 출력
            string[] tags = Program.TodoList[count].Tag.Split();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;
            if (Program.TodoList[count].Tag.Length > 0)
                foreach (string tag in tags) Console.Write($"#{tag} ");
            Console.ForegroundColor = ConsoleColor.White;

            Key.InputCardBorderStartX = 1 + 7 * Program.TodoList.Count;
            Key.todoListTextStartY = 2 + 7 * Program.TodoList.Count;
        }

        /* 박스 만들기 - 가로 줄 생성 */
        private static void DrawHorizontalLine(int x, int y, int length, string startSymbol, string horizontalSymbol, string endSymbol)
        {
            Console.SetCursorPosition(x, y++);
            Console.Write(startSymbol);
            for (int i = 0; i < length; i++) Console.Write(horizontalSymbol);
            Console.Write(endSymbol);
        }
        /* 박스 만들기 - 세로 줄 생성 */
        private static void DrawVerticalLine(int x, int y, int length, int width, string symbol)
        {
            for (int i = 0; i < length; i++)
            {
                Console.SetCursorPosition(x, y++);
                Console.Write(symbol);
                for (int k = 0; k < width; k++)
                {
                    Console.Write(" ");
                }
                Console.Write(symbol);
            }
        }

        private const string topLeft = "┏";
        private const string horizontalLine = "━";
        private const string topRight = "┓";
        private const string verticalLine = "┃";
        private const string bottomLeft = "┗";
        private const string bottomRight = "┛";

        /* 박스 만들기(상자 좌측 위치값, 상자 상단 위치값, 가로, 세로, 색깔을 넣을지 말지) */
        public static void DrawBox(int boxLeft, int boxTop, int width, int height, bool color = false)
        {
            
            Console.ForegroundColor = color ? ConsoleColor.Red : ConsoleColor.DarkGray;

            DrawHorizontalLine(boxLeft, boxTop++, width, topLeft, horizontalLine, topRight);
            DrawVerticalLine(boxLeft, boxTop, height, width, verticalLine);
            boxTop += height;
            DrawHorizontalLine(boxLeft, boxTop++, width, bottomLeft, horizontalLine, bottomRight);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

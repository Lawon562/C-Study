using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleTodoApp.StringTemplate;

namespace ConsoleTodoApp
{
    public class Key
    {
        public static ConsoleColor ForeColor = Console.ForegroundColor;
        public static ConsoleColor BackColor = Console.BackgroundColor;
        public const int TitlePositionStartX = 0;

        public static int TitleLength => StringTemplate.Title[0].Length;
        private const int TitlePadding = 3;


        public static int InputBoxBorderX = 0;
        public static int InputBoxBordereY = 11;
        public static int InputBoxWidth = TitleLength - 2;
        public static int InputBoxHeight = 1;


        public static int ProgramDescriptionStartX = TitlePositionStartX + TitleLength;

        public const int WindowX = 120;
        public const int WindowY = 40;

        public static int CurrentScreenX = 0;
        public static int CurrentScreenY = 0;



        public static int CardStartX => TitleLength + TitlePadding;
        public static int CardStartY = 1;
        public static int CardWidth = WindowX / 2 + 2;
        public static int CardHeight = 5;


        public static int InputCardBorderStartX = 1;
        public static int todoListWidth = WindowX / 2 + 2;
        public static int todoListHeight = 1;
        public static int todoListTextStartX => TitleLength + 6 + (WindowX / 2 + 2) / 2 - (StringTemplate.CreateButtonText.Length) + 2;
        public static int todoListTextStartY = 2;

        public static int instructionLineNumber = 28;

        public static int TodoCount = 0;

    }
}

using ConsoleTodoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolTodoApp
{
    public class ConsoleHelper
    {
        /* 전달받은 x,y 위치에 string을 출력하기 위한 메소드 */
        public static void WriteProgramInfo(int x, int y, string str)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(str);
        }

        public static void EraseInstructionLine()
        {
            Console.SetCursorPosition(0, Key.instructionLineNumber);
            Console.Write(StringTemplate.InstructionSpace);
            Console.SetCursorPosition(0, Key.instructionLineNumber);
        }

        public static void EraseInputLine()
        {
            //Console.SetCursorPosition(Key.TitlePositionStartX + 14, 12);
            Console.ForegroundColor = ConsoleColor.Black;
            for (int y = 11; y < 31; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write(StringTemplate.InputSpace);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;

        }

        public static void InstructionWrite(string args)
        {
            EraseInstructionLine();
            Console.Write(args);
        }






    }




}

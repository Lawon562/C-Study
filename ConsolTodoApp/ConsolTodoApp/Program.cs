using ConsoleTodoApp;
using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace ConsolTodoApp
{
    internal class Program
    {
        
        public static void WriteProgramInfo(int x, int y, string str)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(str);
        }

        public static void DrawTitle()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int y = 0;
            foreach (string line in StringTemplate.Title)
            {
                Console.SetCursorPosition(Key.TitlePositionStartX, y++);
                Console.WriteLine(line);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;

            int authorX = Key.ProgramDescriptionStartX - StringTemplate.Author.Length - 2;
            int dateX = Key.ProgramDescriptionStartX - StringTemplate.Date.Length;
            WriteProgramInfo(authorX, y++, StringTemplate.Author);
            WriteProgramInfo(dateX, y++, StringTemplate.Date);
            
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DrawBox(int startX, int startY, int width, int height, bool color=false)
        {
            if (color) { Console.ForegroundColor = ConsoleColor.Red; }
            else { Console.ForegroundColor = ConsoleColor.DarkGray; }
            Console.SetCursorPosition(startX, startY++);
            Console.Write("┏");
            
            for (int k = 0; k < width; k++)
            {
                Console.Write("━");
            }
            Console.Write("┓");

            
            for(int i=0; i< height; i++)
            {
                Console.SetCursorPosition(startX, startY++);
                Console.Write("┃");
                for (int k = 0; k < width; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("┃");
            }
            
            Console.SetCursorPosition(startX, startY++);
            Console.Write("┗");
            for (int k = 0; k < width; k++)
            {
                Console.Write("━");
            }
            Console.Write("┛");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void DrawInputBox()
        {
            DrawBox(Key.InputBoxBorderX, Key.InputBoxBordereY, Key.InputBoxWidth, Key.InputBoxHeight);
        }
        
        public static void DrawInputCard(bool color)
        {
            DrawBox(Key.CardStartX, Key.InputCardBorderStartX, Key.todoListWidth, Key.todoListHeight, color);
            Console.SetCursorPosition(Key.todoListTextStartX, Key.todoListTextStartY);
            Console.Write(StringTemplate.CreateButtonText);
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
            Console.ForegroundColor= ConsoleColor.Black;
            for (int y = 11; y < 14; y++)
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

        public static void DrawTodoCard(int count, int choiceIdx)
        {
            int x = Key.CardStartX;
            int y = Key.CardStartY + 7 * count;
            int width = Key.CardWidth;
            int height = Key.CardHeight;
            bool check = count % todoList.Count == choiceIdx ? true : false;

            DrawBox(x, y, width, height, check);
         
            // 몇 번째 카드인지 출력
            Console.SetCursorPosition(x - 1, y + 1);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" # {count +1} ");
            
            // 카드에 to-do 출력
            Console.SetCursorPosition(x + 2, y + 3);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" To-do : ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($" {todoList[count].Context} ");
            Console.SetCursorPosition(x + 2, y + Key.CardHeight);
            
            // 카드에 태그 출력
            string[] tags = todoList[count].Tag.Split();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;
            if (todoList[count].Tag.Length > 0)
                foreach ( string tag in tags ) Console.Write($"#{tag} ");
            Console.ForegroundColor = ConsoleColor.White;

            Key.InputCardBorderStartX = 1 + 7 * todoList.Count;
            Key.todoListTextStartY = 2+7*todoList.Count;
        }

        
        //public static void SetPoint()
        //{
        //    Console.SetCursorPosition(Key.CurrentScreenX, Key.CurrentScreenY);
        //}

        public struct Todo
        {
            public string Context;
            public string Tag;
            public string Description;

            public Todo(string context, string tag, string description)
            {
                this.Context = context;
                this.Tag = tag;
                this.Description = description;
            }
        }

        public static List<Todo> todoList = new List<Todo>();




        static void Main(string[] args)
        {
            Console.SetWindowSize(Key.WindowX, Key.WindowY);
            Console.CursorVisible = false;

            DrawTitle();
            
            ConsoleKey key = default(ConsoleKey);
            int choiceIdx = 0;
            DrawInputCard(true);
            
            do
            {
                while (Console.KeyAvailable) Console.ReadKey(false);
                EraseInstructionLine();
                EraseInputLine();


                if (todoList.Count <= 0 || (choiceIdx == todoList.Count && key.Equals(ConsoleKey.Enter)))
                {
                    if (todoList.Count >= 5)
                    {
                            InstructionWrite(StringTemplate.CreateLimitText);
                    }
                    else 
                    {
                        DrawInputBox();
                        Console.CursorVisible = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                    
                        string element = default(string);
                        do
                        {
                            Console.SetCursorPosition(Key.TitlePositionStartX + 2, 12);
                            Console.Write(StringTemplate.InputTodoText);
                            element = Console.ReadLine();
                        } while (element.Equals(""));
                    

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                        EraseInstructionLine();
                        Console.Write(StringTemplate.InputDescriptionText);
                        string description = Console.ReadLine();

                        EraseInstructionLine();
                        Console.Write(StringTemplate.InputTagText);
                        string tag = Console.ReadLine();

                        InstructionWrite(StringTemplate.AskSaveText);
                        string answer = Console.ReadLine();

                        if(Array.IndexOf(StringTemplate.Yes, answer) != -1)
                        {
                            todoList.Add(new Todo(element, tag, description));
                            InstructionWrite(StringTemplate.SaveText);
                        }
                        else
                        {
                            key = default(ConsoleKey);
                            InstructionWrite(StringTemplate.DontSaveText);
                        }

                        Console.Write(StringTemplate.PressEnterText);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.CursorVisible = false;
                    
                        choiceIdx = todoList.Count-1;
                        EraseInputLine();
                    }
                }
                
                else
                {
                    if (key == ConsoleKey.UpArrow || key == ConsoleKey.LeftArrow)
                    {
                        if (--choiceIdx <= 0) choiceIdx = 0;
                    }
                    else if (key == ConsoleKey.DownArrow || key == ConsoleKey.RightArrow)
                    {
                        if (++choiceIdx > todoList.Count) choiceIdx = todoList.Count;
                    }
                    for (int i = choiceIdx > 1 ? choiceIdx-1 : 0; i <= todoList.Count - 1; i++)
                        DrawTodoCard(i, choiceIdx);      

                    DrawInputCard(todoList.Count == choiceIdx);
                }
            } while ((key = Console.ReadKey().Key) != ConsoleKey.Q);
            
        }
    }
}

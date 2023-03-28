using System;
using System.Collections.Generic;

namespace ConsolTodoApp
{
    internal class Program
    {
        public const int TitlePositionStartX = 0;
        public const int windowX = 120;
        public const int windowY = 50;

        public static string[] Title =
        {
            @"(`-')                         _(`-')              ",
            @"( OO).->       .->           ( (OO ).->     .->",
            @"/    '._  (`-')----.  (`-')   \    .'_ (`-')----. ",
            @"|'--...__)( OO).-.  ' ( OO).->'`'-..__)( OO).-.  '",
            @"`--.  .--'( _) | |  |(,------.|  |  ' |( _) | |  |",
            @"   |  |    \|  |)|  | `------'|  |  / : \|  |)|  |",
            @"   |  |     '  '-'  '         |  '-'  /  '  '-'  '",
            @"   `--'      `-----'          `------'    `-----'"
        };

        public static void DrawTitle()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int i = 0;
            foreach (string line in Title)
            {
                Console.SetCursorPosition(TitlePositionStartX, i++);
                Console.WriteLine(line);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string author = "made by 이라원";
            string date = "(2023. 03. 28 version 1.0)";
            Console.SetCursorPosition(TitlePositionStartX + Title[0].Length - author.Length - 2, i++);
            Console.Write(author);
            Console.SetCursorPosition(TitlePositionStartX + Title[0].Length - date.Length, i++);
            Console.Write(date);
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
            DrawBox(TitlePositionStartX, 11, Title[0].Length - 2, 1);
        }
        
        public static void DrawInputCard(bool color)
        {
            DrawBox(todoListStartX, todoListStartY, todoListWidth, todoListHeight, color);
            Console.SetCursorPosition(todoListTextStartX, todoListTextStartY);
            Console.Write(createTodoText);
        }

        public static void EraseInstructionLine()
        {
            Console.SetCursorPosition(0, 28);
            Console.Write("                                                                                              ");
            Console.SetCursorPosition(0, 28);
        }

        public static void EraseInputLine()
        {
            Console.SetCursorPosition(TitlePositionStartX + 2 + 12, 12);
            Console.Write("                                  ");
        }


        public static void InstructionWrite(string args)
        {
            EraseInstructionLine();
            Console.Write(args);
        }

        public static void DrawTodoCard(int i, int choiceIdx )
        {
            bool check = i % todoList.Count == choiceIdx ? true : false;

            DrawBox(
                todoCardStartX,
                todoCardStartY + 7 * i,
                todoCardWidth,
                todoCardHeight,
                check
            );

            screenX = todoCardStartX;
            screenY = todoCardStartY + 7 * i;
         
            Console.SetCursorPosition(todoCardStartX - 1, todoCardStartY + 7 * i + 1);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" # {i+1} ");
            

            
            Console.SetCursorPosition(todoCardStartX + 2, todoCardStartY + 7 * i + 3);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" To-do : ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($" {todoList[i].Context} ");
            Console.SetCursorPosition(todoCardStartX + 2, todoCardStartY + 7 * i + todoCardHeight);
            
            string[] tags = todoList[i].Tag.Split();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;
            if (todoList[i].Tag.Length > 0)
                foreach ( string tag in tags ) Console.Write($"#{tag} ");
            Console.ForegroundColor = ConsoleColor.White;
            todoListStartY = 1 + 7 * todoList.Count;
            todoListTextStartY = 2+7*todoList.Count;
        }

        public static int screenX = 0;
        public static int screenY = 0;
        public static void SetPoint()
        {
            Console.SetCursorPosition(screenX, screenY);
        }

        public struct Todo
        {
            public string Context;
            public string Tag;

            public Todo(string context, string tag)
            {
                this.Context = context;
                this.Tag = tag;
            }
        }

        public static List<Todo> todoList = new List<Todo>();

        public static int todoCardStartX = Title[0].Length + 3;
        public static int todoCardStartY = 1 + 7 * 0;
        public static int todoCardWidth = windowX / 2 + 2;
        public static int todoCardHeight = 5;

        public static string createTodoText = "일정을 생성하시려면 여기를 눌러 주세요.";
        public static int todoListStartY = 1;
        public static int todoListStartX = Title[0].Length + 3;
        public static int todoListWidth = windowX / 2 + 2;
        public static int todoListHeight = 1;
        public static int todoListTextStartX = Title[0].Length + 6 + (windowX / 2 + 2) / 2 - (createTodoText.Length) + 2;
        public static int todoListTextStartY = 2;



        static void Main(string[] args)
        {
            Console.SetWindowSize(windowX, windowY);
            Console.CursorVisible = false;

            DrawTitle();
            DrawInputBox();

            ConsoleKey key = default(ConsoleKey);
            int choiceIdx = 0;
            
            DrawInputCard(todoList.Count == choiceIdx);
            
            do
            {
                while (Console.KeyAvailable) Console.ReadKey(false);
                EraseInstructionLine();
                EraseInputLine();


                if (todoList.Count <= 0 || (choiceIdx == todoList.Count && key.Equals(ConsoleKey.Enter)))
                {
                    Console.CursorVisible = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    
                    string element = default(string);
                    do
                    {
                        Console.SetCursorPosition(TitlePositionStartX + 2, 12);
                        Console.Write("할 일 입력 : ");
                        element = Console.ReadLine();
                    } while (element.Equals(""));
                    

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;

                    EraseInstructionLine();
                    Console.Write("태그 입력(공백으로 구분): ");
                    string tag = Console.ReadLine();

                    InstructionWrite("저장하시겠습니까? (Y/N): ");
                    string answer = Console.ReadLine();
                    if (answer.Equals("Y") || answer.Equals("y"))
                    {
                        todoList.Add(new Todo(element, tag));
                        InstructionWrite("저장되었습니다.");
                    }
                    else
                    {
                        key = default(ConsoleKey);
                        InstructionWrite("저장되지 않았습니다.");
                    }

                    Console.Write(" 엔터키를 눌러주세요.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.CursorVisible = false;
                    
                    choiceIdx = todoList.Count-1;
                    
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

                    //SetPoint();

                }
            } while ((key = Console.ReadKey().Key) != ConsoleKey.Q);
            
        }
    }
}

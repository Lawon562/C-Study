using ConsoleTodoApp;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Schema;

namespace ConsolTodoApp
{
    internal class Program
    {
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

        static bool ContainsKorean(char ch)
        {
            
            if (ch >= 0xAC00 && ch <= 0xD7A3)
            {
                return true;
            }
            return false;
        }

        public static List<Todo> TodoList = new List<Todo>();

        static void Main(string[] args)
        {
            TodoList.Add(new Todo("장 보러 가기", "my name is", "장 보러 가기장 보러 가기장 보러 가기장 보러 가기장 보러 가기"));
            TodoList.Add(new Todo("Bye", "my name is", "asdfkjawdsfselfj a welfjewkflwjfl"));
            TodoList.Add(new Todo("reHi", "my name is", "asdfkjawelfhh jawelfjewkfasdfasfasdfasd asdfasd ads asdf asda sd asdfasdfasdfasdsd sad asdadsf asd asdf asdf asdf asdsdfsaffafadsafslwjfl"));

            Console.SetWindowSize(Key.WindowX, Key.WindowY);
            Console.CursorVisible = false;

            Drawer.DrawTitle();
            
            ConsoleKey key = default(ConsoleKey);
            int choiceIdx = 0;
            Drawer.DrawInputCard(true);
            //int ib = 0;
            do
            {
                while (Console.KeyAvailable) Console.ReadKey(false);
                ConsoleHelper.EraseInstructionLine();
                ConsoleHelper.EraseInputLine();

                if (TodoList.Count > 0 && choiceIdx < TodoList.Count && key.Equals(ConsoleKey.Enter))
                {
                    Drawer.DrawBox(Key.InputBoxBorderX, Key.InputBoxBordereY, Key.InputBoxWidth, Key.InputBoxHeight+15, true);
                    string context = $" #### {TodoList[choiceIdx].Context} #### ";
                    int x = Key.InputBoxBorderX + 3;
                    Console.SetCursorPosition(x, Key.InputBoxBordereY + 2);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(context);


                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(x, Key.InputBoxBordereY + 4);
                    Console.Write("Description");

                    Console.SetCursorPosition(x, Key.InputBoxBordereY + 6);
                    int y = Key.InputBoxBordereY + 6;
                    int length = TodoList[choiceIdx].Description.Length;

                    int checker = 0;
                    for (int i = 0; i < length; i++)
                    {
                        char ch = TodoList[choiceIdx].Description[i];
                        if (ContainsKorean(ch)/* && i % 25 == 0*/)
                        {
                            checker+=6;
                        }
                        else
                        {
                            checker += 1;
                        }
                        if (checker % 45 == 0)
                        {
                            checker = 1;
                            Console.SetCursorPosition(x, ++y);
                        }
                        Console.Write(ch);
                    }

                    y = Key.InputBoxBordereY + Key.InputBoxHeight + 15;
                    Console.SetCursorPosition(x, y);
                    string[] s = TodoList[choiceIdx].Tag.Split();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    for (int i = 0; i < s.Length; i++)
                    {
                        Console.Write($"#{s[i]} ");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                }
                if (TodoList.Count <= 0 || (choiceIdx == TodoList.Count && key.Equals(ConsoleKey.Enter)))
                {
                    if (TodoList.Count >= 5)
                    {
                        ConsoleHelper.InstructionWrite(StringTemplate.CreateLimitText);
                    }
                    else 
                    {
                        Drawer.DrawInputBox();
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

                        ConsoleHelper.EraseInstructionLine();
                        Console.Write(StringTemplate.InputDescriptionText);
                        string description = Console.ReadLine();

                        ConsoleHelper.EraseInstructionLine();
                        Console.Write(StringTemplate.InputTagText);
                        string tag = Console.ReadLine();

                        ConsoleHelper.InstructionWrite(StringTemplate.AskSaveText);
                        string answer = Console.ReadLine();

                        if(Array.IndexOf(StringTemplate.Yes, answer) != -1)
                        {
                            TodoList.Add(new Todo(element, tag, description));
                            ConsoleHelper.InstructionWrite(StringTemplate.SaveText);
                        }
                        else
                        {
                            key = default(ConsoleKey);
                            ConsoleHelper.InstructionWrite(StringTemplate.DontSaveText);
                        }

                        Console.Write(StringTemplate.PressEnterText);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.CursorVisible = false;
                    
                        choiceIdx = TodoList.Count-1;
                        ConsoleHelper.EraseInputLine();
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
                        if (++choiceIdx > TodoList.Count) choiceIdx = TodoList.Count;
                    }
                    for (int i = choiceIdx > 1 ? choiceIdx-1 : 0; i <= TodoList.Count - 1; i++)
                        Drawer.DrawTodoCard(i, choiceIdx);

                    Drawer.DrawInputCard(TodoList.Count == choiceIdx);
                }
            } while ((key = Console.ReadKey().Key) != ConsoleKey.Q);
            
        }
    }
}

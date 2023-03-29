using ConsoleTodoApp;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;
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

        public static void ChoiceButton(int detailChoiceIdx)
        {
            Console.SetCursorPosition(2, 30);
            if (detailChoiceIdx == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write("  수정하기  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" | ");
            if (detailChoiceIdx == 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write("  삭제하기  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static List<Todo> TodoList = new List<Todo>();

        static void Main(string[] args)
        {
            Console.SetWindowSize(Key.WindowX, Key.WindowY);
            Console.CursorVisible = false;

            Drawer.DrawTitle();
            int enterCount = 0;
            
            ConsoleKey key = default(ConsoleKey);
            int choiceIdx = 0;
            int detailIdx = -1;
            Drawer.DrawInputCard(true);
            do
            {
                if (key.Equals(ConsoleKey.Enter))
                {
                    enterCount++;
                }
                while (Console.KeyAvailable) Console.ReadKey(false);

                /* ######################## 카드 디테일 출력 ########################### */
                if (TodoList.Count > 0 && choiceIdx < TodoList.Count && key.Equals(ConsoleKey.Enter) & enterCount == 1)
                {
                    Drawer.DrawBox(Key.InputBoxBorderX, Key.InputBoxBordereY+2, Key.InputBoxWidth, Key.InputBoxHeight+15, true);
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
                        if (ContainsKorean(ch)) checker+=6;
                        else checker += 1;
                        
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
                }
                /* ######################## 카드가 0개이거나 choiceIdx가 todoList의 마지막을 보고 엔터를 누르면 실행 ########################### */
                if (TodoList.Count <= 0 || (choiceIdx == TodoList.Count && key.Equals(ConsoleKey.Enter)))
                {
                    /* ######################## 카드가 5개 이상일 시 추가 제한 ########################### */
                    if (TodoList.Count >= 5)
                    {
                        ConsoleHelper.InstructionWrite(StringTemplate.CreateLimitText);
                    }
                    /* ######################## 카드 추가 ########################### */
                    else
                    {
                        enterCount = 0;
                        ConsoleHelper.EraseInstructionLine();
                        ConsoleHelper.EraseInputLine();
                        Drawer.DrawInputBox();
                        Console.CursorVisible = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                    
                        string element = default(string);

                        Console.SetCursorPosition(Key.TitlePositionStartX + 2, 12);
                        Console.Write(StringTemplate.InputTodoText);
                        element = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        if (!element.Equals(""))
                        {
                            enterCount = 0;
                            ConsoleHelper.EraseInstructionLine();
                            Console.Write(StringTemplate.InputDescriptionText);
                            string description = Console.ReadLine();

                            ConsoleHelper.EraseInstructionLine();
                            Console.Write(StringTemplate.InputTagText);
                            string tag = Console.ReadLine();

                            ConsoleHelper.InstructionWrite(StringTemplate.AskSaveText);
                            string answer = Console.ReadLine();

                            if (Array.IndexOf(StringTemplate.Yes, answer) != -1)
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

                            choiceIdx = TodoList.Count - 1;

                            ConsoleHelper.EraseInputLine();
                            Console.CursorVisible = false;
                        }
                    }
                }
                else
                {
                    /* ######################## 카드 출력 및 이동 구현 ########################### */
                    if (key == ConsoleKey.UpArrow)
                    {
                        if (--choiceIdx <= 0) choiceIdx = 0;
                        enterCount = 0;
                    }
                    else if (key == ConsoleKey.DownArrow)
                    {
                        if (++choiceIdx > TodoList.Count) choiceIdx = TodoList.Count;
                        enterCount = 0;
                    }
                    for (int i = choiceIdx > 1 ? choiceIdx-1 : 0; i <= TodoList.Count - 1; i++)
                        Drawer.DrawTodoCard(i, choiceIdx);

                    Drawer.DrawInputCard(TodoList.Count == choiceIdx);
                }
                if (enterCount == 1)
                {
                    if (key.Equals(ConsoleKey.LeftArrow))
                    {
                        if (--detailIdx <= 0) detailIdx = 0;
                        enterCount=1;
                    }
                    else if (key.Equals(ConsoleKey.RightArrow))
                    {
                        if (++detailIdx > 0) detailIdx = 1;
                        enterCount=1;
                    }
                    ChoiceButton(detailIdx);
                    key = default(ConsoleKey);
                }
                if (enterCount > 1 && detailIdx != -1 && key.Equals(ConsoleKey.Enter))
                {
                    if (detailIdx == 0) ConsoleHelper.InstructionWrite("수정하시겠습니까?(Y/N) : ");
                    else if (detailIdx == 1) ConsoleHelper.InstructionWrite("삭제하시겠습니까?(Y/N) : ");

                    Console.CursorVisible = true;
                    string answer = Console.ReadLine();
                    if (answer.Equals("Y") || answer.Equals("y"))
                    {
                        if (detailIdx == 0)
                        {
                            // 수정
                            ConsoleHelper.EraseInstructionLine();
                            Console.Write(StringTemplate.InputTodoText);
                            string element = Console.ReadLine();
                            if (!element.Equals(""))
                            {

                                ConsoleHelper.EraseInstructionLine();
                                Console.Write(StringTemplate.InputDescriptionText);
                                string description = Console.ReadLine();

                                ConsoleHelper.EraseInstructionLine();
                                Console.Write(StringTemplate.InputTagText);
                                string tag = Console.ReadLine();

                                ConsoleHelper.InstructionWrite(StringTemplate.AskSaveText);
                                string result = Console.ReadLine();

                                if (Array.IndexOf(StringTemplate.Yes, result) != -1)
                                {
                                    TodoList[choiceIdx] = new Todo(element, tag, description);
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

                                choiceIdx = TodoList.Count - 1;

                                ConsoleHelper.EraseInputLine();
                                Console.CursorVisible = false;
                                enterCount = 0;


                            }
                        }
                        else if (detailIdx == 1)
                        {
                            // 삭제
                            TodoList.RemoveAt(choiceIdx);
                            choiceIdx = choiceIdx == 0 ? 0 : choiceIdx - 1;

                            for (int k = 1; k < 50; k++)
                            {
                                Console.SetCursorPosition(Key.CardStartX-2, k);
                                for (int i = 0; i <= Key.todoListWidth+3; i++)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Thread.Sleep(1000);

                            Key.InputCardBorderStartX = 1;
                            Key.todoListTextStartY = 2;
                            for (int i = 0; i < TodoList.Count; i++)
                            {
                                Drawer.DrawTodoCard(i, choiceIdx);
                            }

                            Drawer.DrawInputCard(TodoList.Count == choiceIdx);
                            Console.SetCursorPosition(0, 0);
                        }
                    } else
                    {
                        ConsoleHelper.InstructionWrite("작업이 취소되었습니다.");
                    }

                    enterCount = 0;
                    Thread.Sleep(1000);
                    ConsoleHelper.EraseInputLine();
                    ConsoleHelper.EraseInstructionLine();
                    Console.CursorVisible = false;


                }

            } while ((key = Console.ReadKey().Key) != ConsoleKey.Q);
            
        }
    }
}

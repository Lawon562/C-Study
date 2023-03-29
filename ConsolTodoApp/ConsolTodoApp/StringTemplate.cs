using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTodoApp
{
    public class StringTemplate
    {
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

        public static string Author = "made by 이라원";
        public static string Date = "(2023. 03. 28 version 1.0)";

        //public static string[] Corner = { "┏", "┓", "┗", "┛" };
        public static string InstructionSpace = "                                                                                              ";
        public static string InputSpace = "                                                  ";

        public const string CreateButtonText = "일정을 생성하시려면 여기를 눌러 주세요.";

        public static string CreateLimitText = "집중력 유지 및 성취감 등을 이유로 To-do는 최대 5개까지 생성할 수 있습니다.";

        public static string InputTodoText = "할 일 입력 : ";
        public static string InputDescriptionText = "설명을 입력해주세요 : ";
        public static string InputTagText = "태그 입력(공백으로 구분): ";

        public static string AskSaveText = "저장하시겠습니까? (Y/N): ";
        public static string[] Yes = { "Y", "y" };
        public static string SaveText = "저장되었습니다.";
        public static string DontSaveText = "저장되지 않았습니다.";

        public static string PressEnterText = " 엔터키를 눌러주세요.";





    }
}

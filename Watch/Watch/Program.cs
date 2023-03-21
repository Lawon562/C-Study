using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Watch
{
    internal class Program
    {
        public static string[] zero = 
        { 
            "  /$$$$$$  ", 
            " /$$$_  $$ ", 
            "| $$$$\\ $$", 
            "| $$ $$ $$ ", 
            "| $$\\ $$$$", 
            "| $$ \\ $$$", 
            "|  $$$$$$/ ", 
            " \\______/ " 
        };
        public static string[] one = 
        { 
            "     /$$   ", 
            "   /$$$$   ", 
            "  |_  $$   ", 
            "    | $$   ", 
            "    | $$   ", 
            "    | $$   ", 
            "  /$$$$$$  ", 
            "  ______/  " 
        };
        public static string[] two = 
        { 
            "  /$$$$$$  ", 
            " /$$__  $$ ", 
            "|__/  \\ $$", 
            "  /$$$$$$/ ", 
            " /$$____/  ", 
            "| $$       ", 
            "| $$$$$$$$ ", 
            "|________/ " 
        };
        public static string[] three = 
        { 
            "  /$$$$$$  ", 
            " /$$__  $$ ", 
            "|__/  \\ $$", 
            "   /$$$$$/ ", 
            "  |___  $$ ", 
            " /$$  \\ $$", 
            "|  $$$$$$/ ", 
            " \\______/ " 
        };
        public static string[] four = 
        { 
            " /$$   /$$", 
            "| $$  | $$", 
            "| $$  | $$", 
            "| $$$$$$$$", 
            "|_____  $$", 
            "      | $$", 
            "      | $$", 
            "      |__/" 
        };
        public static string[] five = 
        { 
            " /$$$$$$$ ", 
            "| $$____/ ", 
            "| $$      ", 
            "| $$$$$$$ ", 
            "|_____  $$", 
            " /$$  \\ $$", 
            "|  $$$$$$/", 
            " \\______/ " 
        };
        public static string[] six = 
        { 
            "  /$$$$$$ ", 
            " /$$__  $$", 
            "| $$  \\__/", 
            "| $$$$$$$ ", 
            "| $$__  $$", 
            "| $$  \\ $$", 
            "|  $$$$$$/", 
            " \\______/ " 
        };
        public static string[] seven = 
        { 
            " /$$$$$$$$", 
            "|_____ $$/", 
            "     /$$/ ", 
            "    /$$/  ", 
            "   /$$/   ", 
            "  /$$/    ", 
            " /$$/     ", 
            "|__/      " 
        };
        public static string[] eight = 
        { 
            "  /$$$$$$ ", 
            " /$$__  $$", 
            "| $$  \\ $$", 
            "|  $$$$$$/", 
            " >$$__  $$", 
            "| $$  \\ $$", 
            "|  $$$$$$/", 
            " \\______/ " 
        };
        public static string[] nine = 
        { 
            "  /$$$$$$ ", 
            " /$$__  $$", 
            "| $$  \\ $$", 
            "|  $$$$$$$", 
            " \\____  $$", 
            " /$$  \\ $$", 
            "|  $$$$$$/", 
            " \\______/ " 
        };

        public static int x = 0;
        public static int y = 0;

        public const int INCREASE_X_SIZE = 10;

        public enum DATE { DATE, AMPM, TIME }

        public static void setPosition(int setX, int setY)
        {
            x = setX;
            y = setY;
        }

        public static void IncreaseX(int amount)
        {
            x += amount;
        }

        public static void WriteText(string[] args, DATE date)
        {
            int crtX = x;
            int crtY = y;

            switch (date)
            {
                case DATE.DATE:
                case DATE.TIME:
                    foreach (string line in args)
                    {
                        Console.SetCursorPosition(crtX, crtY);
                        foreach (char ch in line)
                        {
                            Console.Write(ch);
                            crtX += 1;
                        }
                        if (crtX >= 10)
                        {
                            crtX = x;
                            crtY += 1;
                        }
                    }
                    break;
                case DATE.AMPM:
                    break;
            }
            IncreaseX(INCREASE_X_SIZE);
        }

        public static void WriteSeperator(DATE date)
        {
            int crtX = default(int);
            int crtY = default(int);
            
            switch (date)
            {
                case DATE.DATE :
                    crtX = x;
                    crtY = y + 3;
                    for (int i = 0; i < 2; i++)
                    {
                        Console.SetCursorPosition(crtX, crtY + i);
                        Console.WriteLine("==========");
                    }
                    break;
                case DATE.TIME :
                    crtX = x + 5;
                    crtY = y + 1;
                    for (int i = 0; i < 4; i++)
                    {
                        Console.SetCursorPosition(crtX, crtY + i);
                        Console.WriteLine("==");
                        if (i == 1) crtY += 4;
                    }
                    break;
            }
            
            IncreaseX(10);
        }


        /* 전달받은 글자에 대응되는 ASCII 코드를 매칭시켜 객체를 반환한다 */
        public static string[] CheckCondition(char ch, DATE date)
        {
            string[] text = zero;
            if (ch == '1') text = one;
            else if (ch == '2') text = two;
            else if (ch == '3') text = three;
            else if (ch == '4') text = four;
            else if (ch == '5') text = five;
            else if (ch == '6') text = six;
            else if (ch == '7') text = seven;
            else if (ch == '8') text = eight;
            else if (ch == '9') text = nine;
            return text;
        }

        public static void Routine(string[] args, DATE date)
        {
            for (int i = 0; i < 3; i++)
            {
                foreach (char ch in args[i]) WriteText( CheckCondition(ch, date), date );
                if (i != 2) WriteSeperator(date);
            }
        }

        static void Main(string[] args)
        {
            char key = default(char);       /* 타이머를 종료시킬 수 있는 key 변수 선언 - default value 설정 */
            Console.CursorVisible = false;  /* 점멸하는 커서를 아예 안보이게 막기 */

            int crtDay = 0;

            while (key != 'q')              /* key에 저장된 값이 q라면 반복 종료 */
            {
                /* 키 입력이 있을 때만 key 변수에 입력된 값 저장하기 */
                if (Console.KeyAvailable) key = Console.ReadKey().KeyChar;
                /* 1초 대기 - 필요한 코드인가? ----------------------------------------------------------- */
                Thread.Sleep(200);

                /* 타이머를 그려줄 좌표를 0, 0으로 설정 */
                setPosition(0, 0);


                /* 
                 * 현재 시간을 전부 가져와줄 변수 now, 문자열 배열의 형태로 현재 시간을 저장한다. 
                 * "2023-00-00", "AMPM", "00:00:00"의 형태로 저장된다                 
                 */
                String[] now = DateTime.Now.ToString().Split();
                
                /*
                 * 문자열 배열 date에는 가져온 현재 시간 중 연월일 데이터만 가져온다.
                 * 즉, now의 0번째 데이터를 가져와서 문자 '-'를 기준으로 split한다.
                 */
                string[] date = now[0].Split('-');

                /* 날짜가 바뀌지 않는 이상 날짜 부분은 다시 그리지 않음 */
                if (crtDay != Convert.ToInt32(date[2]))
                {
                    crtDay = DateTime.Now.Day;
                    /* 가져온 date를 ASCII Art로 출력한다 */
                    Routine(date, DATE.DATE);
                }

                /* x, y 위치 재설정  */
                setPosition(0, 10);
                Console.SetCursorPosition(x, y);

                /* 현재 시간 출력 */
                string[] time = now[2].Split(':');
                Routine(time, DATE.TIME);
            }
        }
    }
}

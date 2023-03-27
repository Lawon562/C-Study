using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SnakeGame.Program;
using static SnakeGame.Structure;

namespace SnakeGame.Common
{
    public static class Key
    {
        // Console Window의 사이즈를 지정한 리터럴 변수
        public const int WINDOW_X = 120;
        public const int WINDOW_Y = 30;

        // 게임 MAP의 크기를 지정해둔 리터럴 변수
        public const int MAP_X = 30;
        public const int MAP_Y = 30;

        // 게임 맵이 그려질 위치를 지정해둔 리터럴 변수
        public const int MAP_START_X = WINDOW_X / 4;
        public const int MAP_START_Y = 0;

        // 게임 맵의 벽 모양을 저장해둔 리터럴 변수
        public const char WALL_SHAPE = '■';

        // Player의 시작 위치를 지정해둔 리터럴 변수
        public const int PLAYER_X = Key.MAP_X + Key.MAP_START_X - 1;
        public const int PLAYER_Y = Key.MAP_Y / 2;

        // Player 모양을 저장해둔 리터럴 변수
        public const char PLAYER_HEAD = '○';
        public const char PLAYER_BODY = '●';

        // Item 모양을 저장해둔 리터럴 변수
        public const char ITEM_SHAPE = '◆';

        // 아이템을 한 번 먹을 때 올라갈 점수를 저장해둔 리터럴 변수
        public const int SCORE = 1;

        //public static Point WINDOW = new Point(Key.WINDOW_X, Key.WINDOW_Y);

        public const int SCORE_TEXT_X = Key.WINDOW_X - Key.MAP_X;
        public const int SCORE_TEXT_Y = 0;

        public static string[] SCORE_TEXT =
        {
            " ____ _____ _____ _____ ____ ",
            "|  __|  ___|  _  | __  |  __|",
            "|__  | |___| |_| |    -|  __|",
            "|____|_____|_____|__|__|____|"
        };

        public static string[] TITLE_TEXT =
        {
            " ____ _____ _____ _____ _____",
            "|  __|   | |  _  |  |  |   __|",
            "|_   | | | |     |    -|   __|",
            "|____|_|___|__|__|__|__|_____|",
            "   _____ _____ _____ _____",
            "  |   __|  _  |     |   __|",
            "  |  |  |     | | | |   __|",
            "  |_____|__|__|_|_|_|_____|"
        };

        public static string GAME_DESCRIPTION = "The player controls a long, thin creature, resembling a snake, which roams around on a bordered plane, picking up some item, trying to avoid hitting its own tail or the edges of the playing area.\nEach time the snake eats a piece of food, its tail grows longer, making the game increasingly difficult. The user controls the direction of the snake's head (up, down, left, or right), and the snake's body follows.";


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

    }
}

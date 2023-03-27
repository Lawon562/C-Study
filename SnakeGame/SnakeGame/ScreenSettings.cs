using SnakeGame.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class ScreenSettings
    {
        /* Screen을 Setting해주는 클래스/메소드
         * 윈도우 크기 설정
         * 커서 안보이게 처리
         */
        public static void execute()
        {
            /* 윈도우를 정해진 크기로 설정하기*/
            Console.SetWindowSize(Key.WINDOW_X, Key.WINDOW_Y);
            Console.CursorVisible = false;
            Console.Title = "Snake Game";

        }
    }
}

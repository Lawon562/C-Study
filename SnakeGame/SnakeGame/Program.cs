using SnakeGame.Common;
using System;
using System.Collections.Generic;
using System.Threading;
using static SnakeGame.Structure;

/*
 * 작성자 : 이라원
 * 작성일자 : 2023.03.24
 * 프로젝트명 : SnakeGame
 * 더 추가하고 싶은것 - 소리, 데이터 기록(순위)
 */
namespace SnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 화면 설정  */ ScreenSettings.execute();    /* UI 설정 */ UIFunc.DrawUI();

            /* 게임 필수 변수 설정 */
            int direction = -1;     /* Player의 방향을 설정해줄 direction */
            int speed = 200;        /* 게임의 속도감을 책임져줄 speed 변수 */
            int score = 0;          /* 게임의 흥미요소인 score 변수와 item 설정 */
            // item을 하나 먹을때마다 점수가 n씩 올라가게 할 것.

            /* Player 생성 */ /* Player 위치정보를 관리해줄 List-Point를 만들고 정해진 좌표 넣기*/
            List<Point> Player = Func.CreatePlayer();
            UIFunc.DrawPlayer(Player);

            /* item 생성 */ /* item의 위치정보를 관리해줄 Point 객체를 만들고 랜덤 좌표 넣기 */
            Point itemPoint = Func.RandomPositionSet();
            UIFunc.DrawItem(itemPoint);

            /* 게임을 관리해줄 변수 game는 false면 게임이 진행되지 않는다 */
            bool game = false;
            ConsoleKeyInfo inputKey = default(ConsoleKeyInfo);
            while (true)
            {
                inputKey = Console.ReadKey();
                if (inputKey.Key == ConsoleKey.Enter)
                {
                    game = true;
                    break;
                }
            }
            
            while (game)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                UIFunc.DrawText(Key.SCORE_TEXT_X, Key.SCORE_TEXT_Y, Key.SCORE_TEXT);
                Console.ForegroundColor = ConsoleColor.White;

                // item과 player가 충돌했는지 점검하고, 점수를 반환한다.
                if (Func.CollideItem(Player, itemPoint))
                {
                    score += Func.GetScore(Player, itemPoint);      // 점수 증가
                    Func.SetItemPosition(ref itemPoint);            // item 위치 재설정
                }
                    
                // 게임 속도감을 위한 Thread.Sleep로, 점수가 올라갈수록 게임의 속도도 올라가야 한다.
                Thread.Sleep(speed - (score * 5));

                /* 키 입력받기 - 만약 키를 눌렀다면 입력받을 것. */
                Func.Handlingkeystrokes(ref direction);
                
                /* 아이템, 플레이어 그리기 */
                UIFunc.DrawElements(itemPoint, Player, direction);

                /* ------------------------------------------------------- */
                string eScore = score.ToString();
                UIFunc.DrawScore(eScore, score);
                
                /* ------------------------------------------------------- */
                /* Player가 맵과 충돌했거나 자기 자신과 충돌했는지 검사하여 충돌하였으면 게임 중지 */
                if (Func.CheckEnd(Player)) break;
            }
        }
    }
}

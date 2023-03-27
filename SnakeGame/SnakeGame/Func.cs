using SnakeGame.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SnakeGame.Structure;

namespace SnakeGame
{
    public class Func
    {
        /* item과 Player의 충돌 감지 체크 함수 */
        public static bool CollideItem(List<Point> Player, Point itemPoint)
        {
            return Player[0].GetPoint().Equals(itemPoint.GetPoint());
        }

        /* Player와 Item이 서로 충돌했을 시 Key.SCORE점수를 반환하는 함수 */
        public static int GetScore(List<Point> Player, Point itemPoint)
        {
            // Player의 좌표배열에 itemPoint의 좌표배열 추가
            Player.Add(new Point(itemPoint.x, itemPoint.y));
            // 랜덤 좌표 받아와 아이템 좌표 설정하기
            return Key.SCORE; 
        }

        /* Player가 맵에 충돌했거나 자기자신과 부딪혔는지 체크하여 결과를 반환하는 메소드 */
        public static bool CheckEnd(List<Point> Player)
        {
            bool res = false;
            if (Player[0].x <= Key.MAP_X + 1 ||                          // Player가 왼쪽 벽에 부딪혔다면(이상있음)
                    Player[0].x >= (Key.WINDOW_X / 4) + Key.MAP_X * 2 - 4 || // Player가 오른쪽 벽에 부딪혔다면
                    Player[0].y <= 0 ||                                      // Player가 위쪽 벽에 부딪혔다면
                    Player[0].y >= Key.MAP_Y - 1 ||                          // Player가 아래쪽 벽에 부딪혔다면
                    Func.CheckBody(Player))                                       // Player가 자기자신과 부딪혔다면
            {
                res = true;
            }
            return res;
        }

        /* PLAYER_HEAD가 PLAYER_BODY에 부딪혔는지 체크해주는 메서드 */
        public static bool CheckBody(List<Point> Player)
        {
            for (int i = 1; i < Player.Count; i++)
            {
                if (Player[0].GetPoint().Equals(Player[i].GetPoint())) return true;
            }
            return false;
        }

        public static string[] GetScoreText(char eScore)
        {
            string[] target;
            if (eScore == '0') target = Key.zero;
            else if (eScore == '1') target = Key.one;
            else if (eScore == '2') target = Key.two;
            else if (eScore == '3') target = Key.three;
            else if (eScore == '4') target = Key.four;
            else if (eScore == '5') target = Key.five;
            else if (eScore == '6') target = Key.six;
            else if (eScore == '7') target = Key.seven;
            else if (eScore == '8') target = Key.eight;
            else target = Key.nine;

            return target;
        }

        /* Player의 키 입력에 따라 방향을 체크하는 메서드 */
        /* direction 0  왼쪽
         * direction 1  오른쪽
         * direction 10 위쪽
         * direction 11 아래쪽
         */
        public static int GetDirection(ConsoleKey inputKey)
        {
            int direction = default(int);
            if (inputKey.Equals(ConsoleKey.LeftArrow)) direction = 0;
            else if (inputKey.Equals(ConsoleKey.RightArrow)) direction = 1;
            else if (inputKey.Equals(ConsoleKey.UpArrow)) direction = 10;
            else if (inputKey.Equals(ConsoleKey.DownArrow)) direction = 11;

            return direction;
        }

        /* 체크된 방향을 받아 이동된 방향으로 x,y 좌표를 전달하는 메서드(Tuple로, 언패킹 할 것) */
        public static Tuple<int, int> CalcDirection(int dir)
        {
            int x = 0;
            int y = 0;

            if (dir == 0) x = -2;
            else if (dir == 1) x = 2;
            else if (dir == 10) y = -1;
            else if (dir == 11) y = 1;

            return new Tuple<int, int>(x, y);
        }

        // Player를 움직이게 하는 메서드
        public static void Move(List<Point> Player, int direction)
        {
            int x, y;
            (x, y) = CalcDirection(direction);

            Point point = new Point(Player[0].x + x, Player[0].y + y);

            Player.Insert(1, Player[0]);
            Console.SetCursorPosition(Player[Player.Count - 1].x, Player[Player.Count - 1].y);
            Console.Write("  ");

            Player.RemoveAt(Player.Count - 1);
            Player[0] = new Point(point.x, point.y);
        }

        /* Player 생성 메서드 */
        public static List<Point> CreatePlayer()
        {
            Console.SetCursorPosition(Key.PLAYER_X, Key.PLAYER_Y);      // Player 위치 지정
            List<Point> Player = new List<Point>();                     // Player 생성 및 머리 그리기
            Player.Add(new Point(Key.PLAYER_X, Key.PLAYER_Y));
            return Player;
        }

        /* itemPoint 생성 메서드 */
        public static Point RandomPositionSet()
        {
            Random random = new Random();
            // x: 맵 시작 위치(x)+2부터, 맵시작위치(x)+맵의길이(x)*2 - 4한 값
            // y: 1부터 맵의길이(y)-1한 값
            int x = random.Next(Key.MAP_START_X + 2, Key.MAP_START_X + Key.MAP_X * 2 - 4);
            if (x % 2 == 0) { x += 1; }
            int y = random.Next(1, Key.MAP_Y - 1);

            return new Point(x, y);
        }

        /* item의 위치를 랜덤으로 변경 가능한 메서드 */
        public static void SetItemPosition(ref Point itemPoint)
        {
            Point randomPoint = RandomPositionSet();
            itemPoint.SetPoint(randomPoint.x, randomPoint.y);
        }

        /* 키 입력을 핸들링해주는 함수 */
        public static void Handlingkeystrokes(ref int direction)
        {
            ConsoleKey inputKey = default(ConsoleKey);
            while (Console.KeyAvailable)
            {
                //if (!game) game = true;
                // 키 입력받기
                inputKey = Console.ReadKey().Key;
                // 입력받은 키로 방향 정하기
                direction = Func.GetDirection(inputKey);
            }
        }
    }
}

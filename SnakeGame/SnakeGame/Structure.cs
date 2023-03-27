using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Structure
    {
        public struct Point
        {
            public int x, y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public Point GetPoint()
            {
                return new Point(this.x, this.y);
            }

            public void SetPoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}

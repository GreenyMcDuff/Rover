using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rover.Api.Logic
{
    public class Coordinates
    {
        public Coordinates(int x, int y, char direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        private int _x;
        public int X
        {
            get { return _x; }
            set { _x = WrapX(value); }
        }

        private int _y;
        public int Y
        {
            get { return _y; }
            set { _y = WrapY(value); }
        }

        public char Direction { get; set; }

        public int MaxX { get; } = 100;
        public int MaxY { get; } = 100;

        private int WrapX(int x)
        {
            if (x > MaxX)
            {
                return 0;
            }

            if (x == -1)
            {
                return MaxX;
            }

            return x;
        }

        private int WrapY(int y)
        {
            if (y > MaxY)
            {
                return 0;
            }

            if (y == -1)
            {
                return MaxY;
            }

            return y;
        }
    }
}

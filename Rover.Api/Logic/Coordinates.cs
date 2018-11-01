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
            return x > MaxX ? 0 : x;
        }

        private int WrapY(int y)
        {
            return y > MaxY ? 0 : y;
        }
    }
}

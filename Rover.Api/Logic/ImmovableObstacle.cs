using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rover.Api.Logic
{
    public class ImmovableObstacle
    {
        public Coordinates Position { get; set; }

        public ImmovableObstacle(int x, int y)
        {
            Position.X = x;
            Position.Y = y;
        }
    }
}

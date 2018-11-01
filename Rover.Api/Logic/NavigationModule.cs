using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rover.Api.Logic
{
    public class NavigationModule
    {
        public NavigationModule()
        {
            // probably need to take in the command string here
        }

        public Coordinates CurrentPosition { get; set; }

        public void Move(Coordinates startPosition, char command)
        {
            if (startPosition.Direction == 'N' && command == 'F')
            {
                startPosition.Y++;
                CurrentPosition = startPosition;
            }

            if (startPosition.Direction == 'N' && command == 'B')
            {
                startPosition.Y--;
                CurrentPosition = startPosition;
            }

            if (startPosition.Direction == 'E' && command == 'F')
            {
                startPosition.X++;
                CurrentPosition = startPosition;
            }

            if (startPosition.Direction == 'E' && command == 'B')
            {
                startPosition.X--;
                CurrentPosition = startPosition;
            }

            if (startPosition.Direction == 'S' && command == 'F')
            {
                startPosition.Y--;
                CurrentPosition = startPosition;
            }

            if (startPosition.Direction == 'S' && command == 'B')
            {
                startPosition.Y++;
                CurrentPosition = startPosition;
            }

            if (startPosition.Direction == 'W' && command == 'F')
            {
                startPosition.X--;
                CurrentPosition = startPosition;
            }

            if (startPosition.Direction == 'W' && command == 'B')
            {
                startPosition.X++;
                CurrentPosition = startPosition;
            }
        }

        public void Rotate(Coordinates startPosition, char command)
        {
            // TODO ..
        }
    }
}

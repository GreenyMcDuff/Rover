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
                return;
            }

            if (startPosition.Direction == 'N' && command == 'B')
            {
                startPosition.Y--;
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'E' && command == 'F')
            {
                startPosition.X++;
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'E' && command == 'B')
            {
                startPosition.X--;
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'S' && command == 'F')
            {
                startPosition.Y--;
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'S' && command == 'B')
            {
                startPosition.Y++;
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'W' && command == 'F')
            {
                startPosition.X--;
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'W' && command == 'B')
            {
                startPosition.X++;
                CurrentPosition = startPosition;
                return;
            }
        }

        public void Rotate(Coordinates startPosition, char command)
        {
            if (startPosition.Direction == 'N' && command == 'R')
            {
                startPosition.Direction = 'E';
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'E' && command == 'R')
            {
                startPosition.Direction = 'S';
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'S' && command == 'R')
            {
                startPosition.Direction = 'W';
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'W' && command == 'R')
            {
                startPosition.Direction = 'N';
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'N' && command == 'L')
            {
                startPosition.Direction = 'W';
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'E' && command == 'L')
            {
                startPosition.Direction = 'N';
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'S' && command == 'L')
            {
                startPosition.Direction = 'E';
                CurrentPosition = startPosition;
                return;
            }

            if (startPosition.Direction == 'W' && command == 'L')
            {
                startPosition.Direction = 'S';
                CurrentPosition = startPosition;
                return;
            }
        }
    }
}

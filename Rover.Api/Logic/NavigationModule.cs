using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rover.Api.Logic
{
    public class NavigationModule
    {
        private readonly char[] _commands;

        public NavigationModule(string commandString)
        {
            _commands = commandString.ToCharArray();
        }

        public ImmovableObstacle ImmovableObstacle { get; set; }
        public Coordinates CurrentPosition { get; set; } = new Coordinates(0, 0, 'N');
        public string Message { get; set; }

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

        public bool ImmovableObstacleFound(Coordinates startPosition, char command)
        {
            var proposedPosition = Move(startPosition, command);

            if (ImmovableObstacle.Position.X == CurrentPosition.X && ImmovableObstacle.Position.Y == CurrentPosition.Y)
            {
                return true;
            }

            return false;
        }

        public bool ExecuteCommand()
        {
            foreach (var command in _commands)
            {
                if (command.Equals('R') || command.Equals('L'))
                {
                    Rotate(CurrentPosition, command);
                }
                else
                {
                    if (ImmovableObstacleFound())
                    {
                        Message = "I found an obstacle, stoping command early";
                        return false;
                    }
                    Move(CurrentPosition, command);
                }
            }
            Message = "No obstacles found during command execution";
            return true;
        }
    }
}

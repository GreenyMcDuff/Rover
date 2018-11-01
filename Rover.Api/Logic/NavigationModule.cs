﻿using System;
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
        }
    }
}
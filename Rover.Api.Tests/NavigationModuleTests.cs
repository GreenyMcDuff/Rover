using Rover.Api.Logic;
using Xunit;

namespace Rover.Api.Tests
{

    public class NavigationModuleTests
    {
        [Theory]
        [InlineData(0, 0, 'N', 'F', 0, 1, 'N')]
        public void Should_MoveInCorrectDirection(int beginX, int beginY, char beginDirection, char command,
            int expectedX, int expectedY, char expectedDirection)
        {
            // need something to hold coordinates
            var startCoordinates = new Coordinates(beginX, beginY, beginDirection);


            // need something to do the doing of the command
            var navigationModule = new NavigationModule();
            navigationModule.Move(startCoordinates, command);
            var actual = navigationModule.CurrentPosition;

            Assert.Equal(expectedX, actual.X);
            Assert.Equal(expectedY, actual.Y);
            Assert.Equal(expectedDirection, actual.Direction);
        }
    }
}

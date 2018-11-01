using Rover.Api.Logic;
using Xunit;

namespace Rover.Api.Tests
{

    public class NavigationModuleTests
    {
        [Theory]
        [InlineData(0, 0, 'N', 'F', 0, 1, 'N')]
        [InlineData(0, 0, 'N', 'B', 0, -1, 'N')]
        [InlineData(0, 0, 'E', 'F', 1, 0, 'E')]
        [InlineData(0, 0, 'E', 'B', -1, 0, 'E')]
        [InlineData(0, 0, 'S', 'F', 0, -1, 'S')]
        [InlineData(0, 0, 'S', 'B', 0, 1, 'S')]
        [InlineData(0, 0, 'W', 'F', -1, 0, 'W')]
        [InlineData(0, 0, 'W', 'B', 1, 0, 'W')]
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

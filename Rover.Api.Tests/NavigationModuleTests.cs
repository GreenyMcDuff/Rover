using Rover.Api.Logic;
using Xunit;

namespace Rover.Api.Tests
{

    public class NavigationModuleTests
    {
        [Theory]
        [InlineData(0, 0, 'N', 'R', 0, 0, 'E')]
        [InlineData(0, 0, 'E', 'R', 0, 0, 'S')]
        [InlineData(0, 0, 'S', 'R', 0, 0, 'W')]
        [InlineData(0, 0, 'W', 'R', 0, 0, 'N')]
        [InlineData(0, 0, 'N', 'L', 0, 0, 'W')]
        [InlineData(0, 0, 'E', 'L', 0, 0, 'N')]
        [InlineData(0, 0, 'S', 'L', 0, 0, 'E')]
        [InlineData(0, 0, 'W', 'L', 0, 0, 'S')]
        public void Should_RotateAndFaceNewDirection(int beginX, int beginY, char beginDirection, char command,
            int expectedX, int expectedY, char expectedDirection)
        {
            // assemble
            var startCoordinates = new Coordinates(beginX, beginY, beginDirection);
            var navigationModule = new NavigationModule();

            // act
            navigationModule.Rotate(startCoordinates, command);
            var actual = navigationModule.CurrentPosition;

            // assert
            Assert.Equal(expectedX, actual.X);
            Assert.Equal(expectedY, actual.Y);
            Assert.Equal(expectedDirection, actual.Direction);
        }

        [Theory]
        [InlineData(0, 0, 'N', 'F', 0, 1, 'N')]
        [InlineData(0, 0, 'N', 'B', 0, 100, 'N')]
        [InlineData(0, 0, 'E', 'F', 1, 0, 'E')]
        [InlineData(0, 0, 'E', 'B', 100, 0, 'E')]
        [InlineData(0, 0, 'S', 'F', 0, 100, 'S')]
        [InlineData(0, 0, 'S', 'B', 0, 1, 'S')]
        [InlineData(0, 0, 'W', 'F', 100, 0, 'W')]
        [InlineData(0, 0, 'W', 'B', 1, 0, 'W')]
        [InlineData(0, 100, 'N', 'F', 0, 0, 'N')]
        [InlineData(100, 0, 'E', 'F', 0, 0, 'E')]
        [InlineData(100, 100, 'N', 'F', 100, 0, 'N')]
        [InlineData(100, 100, 'E', 'F', 0, 100, 'E')]
        public void Should_MoveInCorrectDirection(int beginX, int beginY, char beginDirection, char command,
            int expectedX, int expectedY, char expectedDirection)
        {
            // assemble
            var startCoordinates = new Coordinates(beginX, beginY, beginDirection);
            var navigationModule = new NavigationModule();

            // act
            navigationModule.Move(startCoordinates, command);
            var actual = navigationModule.CurrentPosition;

            // assert
            Assert.Equal(expectedX, actual.X);
            Assert.Equal(expectedY, actual.Y);
            Assert.Equal(expectedDirection, actual.Direction);
        }
    }
}

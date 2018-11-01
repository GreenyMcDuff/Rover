using Xunit;

namespace Rover.Api.Tests
{

    public class NavigationModuleTests
    {
        [Theory]
        [InlineData(0, 0, "N", "F", 0, 1, "")]
        public void Should_MoveInCorrectDirection(int beginX, int beginY, string beginDirection, string command,
            int expectedX, int expectedY, string expectedDirection)
        {
            // need something to hold coordinates

            // need something to do the doing of the command
            var navigationModule = new NavigationModule();
            navigationModule.Move(coordinates);
            var actual = navigationModule.CurrentLocation;

            Assert.Equal(expectedX, actual.XCoordinate);
            Assert.Equal(expectedY, actual.YCoordinate);
            Assert.Equal(expectedDirection, actual.Direction);
        }
    }
}

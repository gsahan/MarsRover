using System;
using Xunit;
using MarsRover.Constants;
using MarsRover.Handlers;

namespace MarsRover.Tests
{
    public class MarsRoverTester
    {
        [Fact]
        public void TestDirection()
        {
            var dHandler = new DirectionHandler();
            
            var nextDirection = dHandler.GetNewDirection(Directions.north,"L");
            Assert.True(nextDirection == Directions.east, "Direction North + Left is "+nextDirection);
        }
    }
}

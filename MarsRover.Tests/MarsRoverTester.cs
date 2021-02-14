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

            Map map = new Map(5, 5);
            Rover rover = new Rover(map, new Coordinate(1, 2), Directions.north);


            var dHandler = DirectionHandler.getInstance();
            
            var nextDirection = (dHandler as DirectionHandler).GetNewDirection(Directions.north,"L");
            Assert.True(nextDirection == Directions.east, "Direction North + Left is "+nextDirection);

            nextDirection = (dHandler as DirectionHandler).GetNewDirection(Directions.south, "L");
            Assert.True(nextDirection == Directions.west, "Direction South + Left is " + nextDirection);


        }


        [Fact]
        public void TestCommand()
        {

            Map map = new Map(5,5);
            Rover rover = new Rover(map,new Coordinate(1,2),Directions.north);

            CommandHandler.Handle("LMLMLMLMM",rover);


            Assert.True(rover.coordinate.x.ToString()+rover.coordinate.y.ToString()+rover.direction == "13N","rover move failed.");


        }
    }
}

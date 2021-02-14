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
            Rover rover1 = new Rover(map,new Coordinate(1,2),Directions.north);
            Rover rover2 = new Rover(map, new Coordinate(3, 3), Directions.east);
            rover1.ExecuteCommand("LMLMLMLMM");
            rover2.ExecuteCommand("MMRMMRMRRM");



            Assert.True(rover1.coordinate.x.ToString()+rover1.coordinate.y.ToString()+rover1.direction == "13N","rover1 move failed.");
            Assert.True(rover2.coordinate.x.ToString() + rover2.coordinate.y.ToString() + rover2.direction == "15E", "rover2 move failed.");



        }

        [Fact]
        public void TestFactory()
        {

            var mhandler = HandlerFactory.GetHandler('M');

            var dhandler = HandlerFactory.GetHandler('L');


            Assert.False(mhandler == null, "mhandler is null");
            Assert.False(dhandler == null, "dhandler is null");



        }

    }
}

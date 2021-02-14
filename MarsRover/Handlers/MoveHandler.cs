using MarsRover.Constants;
using MarsRover.Interfaces;

namespace MarsRover.Handlers
{
    public class MoveHandler : IHandler
    {

        private static IHandler single;

        public static IHandler getInstance()
        {
            if (single == null)
                single = new MoveHandler();
            return single;
        }

        private MoveHandler()
        {
            
        }

        public void Handle(char command,IRover rover)
        {
            if(command.ToString() == Commands.move)
                switch (rover.direction)
                {
                    case Directions.north :
                         rover.coordinate = new Coordinate(rover.coordinate.x,rover.coordinate.y+1);
                        break;
                    case Directions.west:
                        rover.coordinate = new Coordinate(rover.coordinate.x+1 , rover.coordinate.y);
                        break;
                    case Directions.south:
                        rover.coordinate = new Coordinate(rover.coordinate.x, rover.coordinate.y - 1); 
                        break;
                    case Directions.east:
                        rover.coordinate = new Coordinate(rover.coordinate.x -1 , rover.coordinate.y);
                        break;                 
                }
        }
    }

}
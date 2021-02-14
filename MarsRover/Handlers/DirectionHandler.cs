using MarsRover.Constants;
using MarsRover.Interfaces;

namespace MarsRover.Handlers
{
    public class DirectionHandler : IHandler
    {
        private static IHandler single;

        public static IHandler getInstance()
        {
            if (single == null)
                single = new DirectionHandler();
            return single;
        }

        private DirectionHandler()
        {

        }

        public string GetNewDirection(string current, string Command)
        {
            
                for (int i = 0; i < Directions.DirectionList.Length; i++)
                {
                    if (Directions.DirectionList[i] == current)
                    {
                        if (Command == Ways.left)
                        {
                            return Directions.DirectionList[(i - 1 < 0) ? Directions.DirectionList.Length - 1 : (i - 1) % Directions.DirectionList.Length];
                        }
                        else if(Command == Ways.right)
                        {
                            return Directions.DirectionList[(i + 1) % Directions.DirectionList.Length];
                        }

                        break;
                    }
                }
            

            throw new System.Exception("Cannot find new direction current " + current + " command " + Command);
        }

        public void Handle(char command,IRover rover)
        {
            rover.direction = GetNewDirection(rover.direction,command.ToString());
        }

    }
}
using MarsRover.Constants;

namespace MarsRover.Handlers
{
    public class DirectionHandler
    {
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
                        else
                        {
                            return Directions.DirectionList[(i + 1) % Directions.DirectionList.Length];
                        }
                    }
                }
            

            throw new System.Exception("Cannot find new direction current " + current + " command " + Command);
        }
    }

}
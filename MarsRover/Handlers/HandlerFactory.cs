using MarsRover.Constants;
using MarsRover.Interfaces;

namespace MarsRover.Handlers
{
    public static class HandlerFactory
    {
       
        public static IHandler GetHandler(char command)
        {

                if (command.ToString() == Commands.move)
                {
                    return MoveHandler.getInstance();
                }
                else
                {
                    return DirectionHandler.getInstance();
                }

             
            
        }
    }

}
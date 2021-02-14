using MarsRover.Constants;
using MarsRover.Interfaces;

namespace MarsRover.Handlers
{
    public static class CommandHandler 
    {
        public static void Handle(string command,IRover rover)
        {
            for (int i = 0; i < command.Length; i++)
            {
                HandlerFactory.GetHandler(command[i]).Handle(command[i],rover);
            }
        }
    }
    
}
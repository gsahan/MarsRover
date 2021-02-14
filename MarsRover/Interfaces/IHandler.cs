
namespace MarsRover.Interfaces
{
    public interface IHandler
    {
        void Handle(char command,IRover rover);
    }
}

namespace MarsRover.Interfaces
{
    public interface IRover
    {
        string roverGuid { get; }

        Coordinate coordinate {get; set; }
        string direction { get; set; }

        IMap map {get ; set;}

        void ExecuteCommand(string cmd);


    }
}
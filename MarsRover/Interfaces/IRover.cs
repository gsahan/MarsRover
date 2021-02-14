
namespace MarsRover.Interfaces
{
    public interface IRover
    {
        Coordinate coordinate {get; set; }
        string direction { get; set; }

        IMap map {get ; set;}

        


    }
}
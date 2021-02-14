
namespace MarsRover.Interfaces
{
    public interface IMap
    {
        int xCorLimit { get; set; }
        int yCorLimit { get; set; }

        bool isEmptyZone(Coordinate cor);
        void setRoverPositiontoMap(IRover rover, Coordinate oldPos);

    }
}
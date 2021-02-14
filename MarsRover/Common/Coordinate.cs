namespace MarsRover
{
    public class Coordinate
    {

        public int x {get; private set;}
        public int y {get; private set;}

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Coordinate(Coordinate cor){
            this.x = cor.x;
            this.y = cor.y;
        }


    }
}
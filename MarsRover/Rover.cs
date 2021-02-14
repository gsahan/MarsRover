using System;
using MarsRover.Interfaces;

namespace MarsRover
{
    public class Rover : IRover
    {
        private Coordinate _coordinate; 

        public IMap map { get ; set;}
        public string direction { get; set; }
        public Coordinate coordinate { 
            
            get {return _coordinate; } 
        
            set 
            {
                    if (value.x != map.xCorLimit && value.x > -1 && value.y != map.yCorLimit && value.y > -1)
                    {
                        _coordinate = value;
                    }
            } 
        }

        public Rover(IMap map, Coordinate cor, string direction)
        {
            this.map = map;
            this._coordinate = cor;
            this.direction = direction;
        }

    }
}

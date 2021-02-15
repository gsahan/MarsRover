using System;
using MarsRover.Handlers;
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
                    if (value.x < map.xCorLimit + 1  && value.x > -1 && value.y < map.yCorLimit + 1 && value.y > -1)
                    {
                        _coordinate = value; 
                    }
            } 
        }

        public string roverGuid => new Guid().ToString();

        public Rover(IMap map, Coordinate cor, string direction)
        {
            this.map = map;            
            this._coordinate = cor;
            this.direction = direction;
        }

        public void ExecuteCommand(string cmd)
        {
            CommandHandler.Handle(cmd,this);
            Console.WriteLine(this.coordinate.x.ToString() + this.coordinate.y.ToString() + this.direction);
        }
    }
}

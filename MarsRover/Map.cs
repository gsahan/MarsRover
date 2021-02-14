using System;
using System.Collections.Generic;
using MarsRover.Interfaces;

namespace MarsRover
{
    public class Map : IMap
    {
        public int xCorLimit { get;set; }
        public int yCorLimit { get;set; }

        public Map(int xLimit, int yLimit)
        {
            xCorLimit = xLimit;
            yCorLimit = yLimit;
        }

        private Dictionary<string,IRover> dic = new Dictionary<string,IRover>();
        private string getKey(Coordinate cor)
        {
            return cor.x.ToString() + "-" + cor.y.ToString();
        }
        public bool isEmptyZone(Coordinate cor)
        {
            return !dic.ContainsKey(getKey(cor));
        }

        public void setRoverPositiontoMap(IRover rover, Coordinate oldPos)
        {
            if(isEmptyZone(rover.coordinate) && (oldPos == null || dic[getKey(oldPos)].roverGuid == rover.roverGuid ) ) {
                if(oldPos != null ) 
                    dic.Remove(getKey(oldPos));
                dic.Add(getKey(rover.coordinate),rover);
            }
            else
                throw new Exception("Map collision detected");
        }

        

        
    }
}

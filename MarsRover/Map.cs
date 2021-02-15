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

    }
}

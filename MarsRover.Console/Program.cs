using System;
using MarsRover;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please give the inputs :");
        var mapString = Console.ReadLine().Split(" ");
        var r1 = Console.ReadLine().Split(" ");
        var r1Command = Console.ReadLine();
        var r2 = Console.ReadLine().Split(" ");
        var r2Command = Console.ReadLine();

        //todo: check inputs
        
        Map map = new Map(Convert.ToInt32(mapString[0]),Convert.ToInt32(mapString[1]));
        var rover1 = new Rover(map,new Coordinate(Convert.ToInt32(r1[0]),Convert.ToInt32(r1[1])),r1[2]);
        var rover2 = new Rover(map, new Coordinate(Convert.ToInt32(r2[0]), Convert.ToInt32(r2[1])), r2[2]);
        
        rover1.ExecuteCommand(r1Command);
        rover2.ExecuteCommand(r2Command);




    }
}


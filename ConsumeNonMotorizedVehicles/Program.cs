using Enumerations;
using NonMotorizedVehicles;
using Structures;
using System;

namespace ConsumeNonMotorizedVehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bicycle bike = new Bicycle
                {
                    TerrainType = TerrainType.Beach,
                    NoOfWheels = 2
                };

                Tricycle trike = new Tricycle
                {
                    TerrainType = TerrainType.City,
                    NoOfWheels = 3
                };

                //I believe Dan once mentioned that one of the difference between
                //struct and class, when you copy a class and make a change to copied
                //class, original class also get modified,
                //whereas if you copy a struct and make a change to copied struct,
                //original struct fields remain the same.
                Bicycle bikeTwin = bike;
                bikeTwin.TerrainType = TerrainType.AllTerrain;
                Console.WriteLine($"bike has terrain type {bike.TerrainType}");

                Tricycle trikeTwin = trike;
                trikeTwin.TerrainType = TerrainType.Mountain;
                Console.WriteLine($"trike has terrain type {trike.TerrainType}");
            }
            catch (Exception e)
            { throw e; }


        }
    }
}

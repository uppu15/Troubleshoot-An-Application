using Enumerations;
using INonMotorizedVehicles;

namespace Structures
{
    public struct Tricycle : INonMotorizedVehicle
    {
        public TerrainType TerrainType { get; set; }
        public int NoOfTires { get; set; }
        public string Brakes { get; set; }
        public bool HasPedals { get; set; }
        public int NoOfWheels { get; set; }
        public bool isMoving;

        public bool Moving()
        {
            return false;
        }

        public bool Moving(bool moving)
        {
            return Moving(this.isMoving);
        }
        public bool Driving(bool isMoving)
        {
            this.isMoving = isMoving;
            return this.isMoving;
        }
    }
}

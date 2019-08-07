using Enumerations;

namespace INonMotorizedVehicles
{
    public interface INonMotorizedVehicle
    {
        bool HasPedals { get; set; }
        int NoOfWheels { get; set; }
        TerrainType TerrainType { get; set; }

        bool Moving();
        bool Moving(bool isMoving);

    }
}

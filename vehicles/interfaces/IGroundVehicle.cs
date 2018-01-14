
namespace vehicles
{
    public interface IGroundVehicle
    {
        int Wheels { get; set; }
        string TransmissionType { get; set; }
        double MaxLandSpeed { get; set; }
    }
}
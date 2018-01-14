namespace vehicles {
    public interface IAirVehicle
    {
        int Wheels { get; set; }
        bool Winged { get; set; }
        double MaxAirSpeed { get; set; }
        void Fly();
    }
}
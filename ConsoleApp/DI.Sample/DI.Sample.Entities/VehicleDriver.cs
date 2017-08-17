namespace DI.Sample.Entities
{
    public class VehicleDriver
    {
        private readonly IVehicle _vehicle;
        public VehicleDriver(IVehicle vehicle)
        {
            //Construtor injection
            _vehicle = vehicle;
        }

        public void Drive()
        {            
            //Start the Vehicle
            _vehicle.Start();
        }
    }
}

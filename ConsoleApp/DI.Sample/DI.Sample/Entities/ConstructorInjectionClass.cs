namespace DI.Sample.Entities
{
    //Class to explain Injection
    public class ConstructorInjectionClass
    {
       
        private readonly IVehicle _vehicle;
        public ConstructorInjectionClass(IVehicle vehicle)
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

using System;

namespace DI.Sample.Entities
{
    public class Car : IVehicle
    {
        public int NumberOfWheels { get { return 4; } }

        public void Start()
        {
            Console.WriteLine(string.Format("I am driving a Car with {0} wheels", NumberOfWheels.ToString()));
        }
    }
}

using System;

namespace DI.Sample.Entities
{
    public class Bike : IVehicle
    {
        public int NumberOfWheels { get { return 2; }  }

        public void Start()
        {            
            Console.WriteLine(string.Format("I am driving a Bike with {0} wheels", NumberOfWheels.ToString()));
        }
    }
}

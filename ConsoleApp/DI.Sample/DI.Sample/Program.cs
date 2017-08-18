using DI.Sample.Entities;
using StructureMap;
using System;


namespace DI.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple DI Using Constructor Injection
            //IVehicle vehicle = new Car();
            //VehicleDriver driver = new VehicleDriver(vehicle);
            //driver.Drive();

            // Using StructureMap Container
            var container = new Container();
            Startup.Start(container);  //Initialize container      
            //It's a Vehicle Driver Class
            ConstructorInjectionClass driver = container.GetInstance<ConstructorInjectionClass>();
            driver.Drive(); 

            //Property Injection
            PropertyInjectionClass pic = container.GetInstance<PropertyInjectionClass>();            
            Console.WriteLine("My Vehicle Class:  " + pic.MyVehicle);

            Console.WriteLine("Driving Completed");
            Console.Read();
        }
    }
}

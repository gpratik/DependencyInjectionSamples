using DI.Sample.Entities;
using StructureMap;

namespace DI.Sample
{
    internal class Startup
    {
        public static void Start(Container container)
        {
            //Register all the dependent Classes here
            container.Configure(x => x.For<IVehicle>().Use<Car>());
            //container.Configure(x => x.For<IVehicle>().Use<Bike>());

            //Set all Properties of type IVehicle
            container.Configure(x=>x.Policies.SetAllProperties(y => y.OfType<IVehicle>()));
            
        }
    }
}

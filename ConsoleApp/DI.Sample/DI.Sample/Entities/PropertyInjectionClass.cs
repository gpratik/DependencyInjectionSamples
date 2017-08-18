using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using StructureMap.Attributes;

namespace DI.Sample.Entities
{
    public class PropertyInjectionClass
    {
        [SetterProperty]
        public IVehicle MyVehicle { get; set; }
    }
}

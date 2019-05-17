using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFinal.ShippingServices
{
    public class CarrierPigeonService : DeliveryService
    {
        public CarrierPigeonService(IShippingVehicle vehicle) : base(vehicle)
        {
            costPerRefuel = 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFinal.ShippingServices
{
    public class CarrierPigeonService : DefaultShippingService
    {
        public CarrierPigeonService(IDeliveryService Service, List<IProduct> Products, IShippingLocation Location) : base(Service, Products, Location)
        {
            
        }
    }
}

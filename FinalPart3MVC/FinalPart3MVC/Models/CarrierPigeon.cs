using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFinal.Vehicles
{
    public class CarrierPigeon : MotorVehicle
    {
        public CarrierPigeon()
        {
            MaxDistancePerRefuel = 10000;
            MaxWeight = 10;
            TopSpeed = 60;
        }
    }
}

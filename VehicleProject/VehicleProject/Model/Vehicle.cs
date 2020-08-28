using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleProject.Model
{
    public class Vehicle
    {
        public int VehicleNumber { get; set; }
        public string Vehicletype { get; set; }
        public long ChassisNumber { get; set; }
        public string EngineNumber { get; set; }
        public int ManYear { get; set; }
        public string LoadCapacity { get; set; }
        public string MakeVehicle { get; set; }
        public string ModelNumber { get; set; }
        public string Bodytype { get; set; }
        public int OrganisationNumber { get; set; }
        public string DeviceID { get; set; }
        public int UserID { get; set; }
    }
}

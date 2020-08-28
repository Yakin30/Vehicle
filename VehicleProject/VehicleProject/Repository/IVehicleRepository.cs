using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleProject.Model;
namespace VehicleProject.Repository
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetVehicles();

        Vehicle GetVehicleByID(int Vehiclenumber);

        void InsertVehicle(Vehicle vehicle);

        void DeleteVehicle(int vehiclenumber);

        void UpdateVehicle(Vehicle vehicle);

        void Save();
    }
}

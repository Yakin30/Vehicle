using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleProject.DBContexts;
using VehicleProject.Model;
namespace VehicleProject.Repository
{
    public class VehicleRepository:IVehicleRepository
    {
        private readonly VehicleContext _dbContext;

        public VehicleRepository(VehicleContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteVehicle(int Vehnumber)
        {
            var vehicle = _dbContext.vehicles.Find(Vehnumber);
            _dbContext.vehicles.Remove(vehicle);
            Save();
        }

        public Vehicle GetVehicleByID(int productId)
        {
            return _dbContext.vehicles.Find(productId);
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            return _dbContext.vehicles.ToList();
        }

        public void InsertVehicle(Vehicle product)
        {
            _dbContext.Add(product);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateVehicle(Vehicle product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            Save();
        }
    }

}

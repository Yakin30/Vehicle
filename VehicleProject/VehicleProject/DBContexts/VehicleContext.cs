using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleProject.Model;

namespace VehicleProject.DBContexts
{
    public class VehicleContext : DbContext
    {

        public VehicleContext(DbContextOptions<VehicleContext> items) : base(items)
        {

        }

        public DbSet<Vehicle> vehicles { get; set; }

        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    VehicleNumber = 1,
                    Vehicletype = "tt",
                    ChassisNumber = 12,
                    EngineNumber = "e23",
                    ManYear = 2020,
                    LoadCapacity = "200",
                    MakeVehicle = "234",
                    ModelNumber = "M234",
                    Bodytype = "SRT",

                    OrganisationNumber = 234,
                    DeviceID = "234",
                    UserID = 2,
                }
           );
        }
    }
}

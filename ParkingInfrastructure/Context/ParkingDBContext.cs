using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingDomain.Entities;
namespace ParkingInfrastructure.Context
{
    public class ParkingDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
          
            options.UseSqlServer("Server=localhost,1433;Database=ParkingSystemDB;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");
        }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }


    }
}

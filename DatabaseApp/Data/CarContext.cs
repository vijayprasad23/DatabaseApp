using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DatabaseApp.Models;

namespace DatabaseApp.Data
{
    public class CarContext : DbContext
    {
        public CarContext (DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        public DbSet<DatabaseApp.Models.Car> Cars { get; set; }

        public DbSet<DatabaseApp.Models.Manufacturer> Manufacturers { get; set; }
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Car>().ToTable("Car");
    //    modelBuilder.Entity<Manufacturer>().ToTable("Manufacturer");
    //}

}

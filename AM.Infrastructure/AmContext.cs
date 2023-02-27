﻿using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AmContext :  DbContext
    {
      // public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
       // public DbSet<Staff> Staffs { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AirportManagementDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }


        // Config clé primaire   sinn bel Annotations 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration Fluent API 
            modelBuilder.ApplyConfiguration(new PassangersConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
          
        }

    }
}

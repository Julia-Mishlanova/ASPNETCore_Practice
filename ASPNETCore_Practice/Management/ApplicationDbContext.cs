using ASPNETCore_Practice.Domain;
using Microsoft.EntityFrameworkCore;
using ASPNETCore_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Management
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<FlightStatus> FlightStatuses { get; set; }
        public DbSet<FlightSeatPricePrice> FlightSeatPrices { get; set; }
        public DbSet<Flight> Flights { get; set; }

        public ApplicationDbContext()
        {
            if (Database.EnsureCreated())
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    
                }
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionDB.ConnectionString());
        }
    }
}

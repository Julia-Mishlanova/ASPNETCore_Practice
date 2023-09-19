using Microsoft.EntityFrameworkCore;
using ASPNETCore_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPNETCore_Practice.Models.Domain;

namespace ASPNETCore_Practice.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<FlightStatus> FlightStatus { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Airport> Airport { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Direction> Direction { get; set; }
        public DbSet<FlightSeatPrice> FlightSeatPrice { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Booking> Booking { get; set; }

        public ApplicationDbContext()
        {
            //if (Database.EnsureCreated())
            //{
            //    using (ApplicationDbContext db = new ApplicationDbContext())
            //    {
            //        db.Countries.Add(
            //            new Country
            //            {
            //                Id = 0,
            //                Name = "SystemCountryName"
            //            });
            //        db.SaveChanges();
            //    }
            //}
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionDB.ConnectionString());
        }
    }
}

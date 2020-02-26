using BookingBackend.Modal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingBackend.Data
{
    public class BookingSystemContext : DbContext
    {
        public BookingSystemContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<City> City { get; set; }
        public DbSet<Driver> Driver { get; set; }
    }
}

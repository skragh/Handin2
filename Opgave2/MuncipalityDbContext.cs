using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class MuncipalityDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
        }

        public DbSet<Addresses> addresses;
        public DbSet<Locations> locations;
        public DbSet<Memberships> memberships;
        public DbSet<Municipalities> municipalities;
        public DbSet<Persons> persons;
        public DbSet<Properties> properties;
        public DbSet<RoomBookings> roomBookings;
        public DbSet<Rooms> rooms;
        public DbSet<Societies> societies;
        public DbSet<Timespans> timespans;
    }
}

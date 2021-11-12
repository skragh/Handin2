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

        public DbSet<Addresses> addresses { get; set; }
        public DbSet<Locations> locations { get; set; }
        public DbSet<Memberships> memberships { get; set; }
        public DbSet<Municipalities> municipalities { get; set; }
        public DbSet<Persons> persons { get; set; }
        public DbSet<Properties> properties { get; set; }
        public DbSet<RoomBookings> roomBookings { get; set; }
        public DbSet<Rooms> rooms { get; set; }
        public DbSet<Societies> societies { get; set; }
        public DbSet<Timespans> timespans { get; set; }
    }
}

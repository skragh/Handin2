using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class MuncipalityDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            modelbuilder.Entity<Municipalities>()
                .Property(m => m.zipCode)
                .HasDefaultValue(0);


            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelbuilder);
        }

        public DbSet<AccessKey> accessKeys { get; set; }
        public DbSet<Addresses> addresses { get; set; }
        public DbSet<KeyResponsible> keyResponsibles { get; set; }
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

using System;
using System.IO;
using System.Linq;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("app.db"))
            {
                File.Delete("app.db");
            }

            var context = new MuncipalityDbContext();
            Dataseed data = new Dataseed();
            data.SeedData();

            var test = context.addresses.Find(1);

            if (test != null)
                Console.WriteLine($"{test.ToString()}");
            else
                Console.WriteLine("Test is null");

            var query = new Queries(context);

            var zipCode = 8000;
            //var roomsInOdder = query.GetRoomsInMunicipality(8300);
            var roomsInOdder = from location in context.locations
                               where location.municipality.zipCode == zipCode
                               join room in context.rooms
                               on location.locationId equals room.location.locationId
                               select room;
            if (roomsInOdder != null)
                foreach (var room in roomsInOdder)
                    Console.WriteLine($"{room}");

            /*
            var allSocieties = query.GetSocietiesByActivity("Computing");
            if (allSocieties != null)
                foreach (var (society, member, address) in allSocieties)
                    Console.WriteLine($"{society}, {member.person}, {address}");
                    */
        }
    }
}

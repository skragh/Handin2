using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MuncipalityDbContext();
            Dataseed data = new Dataseed();
            data.SeedData();

            var test = context.addresses.Find(1);

            if (test != null)
                Console.WriteLine($"{test.ToString()}");
            else
                Console.WriteLine("Test is null");

            var query = new Queries(context);

            var roomsInOdder = query.GetRoomsInMunicipality(8300);
            if (roomsInOdder != null)
                foreach (var room in roomsInOdder)
                    Console.WriteLine($"{room}");

            var allSocieties = query.GetSocietiesByActivity("Computing");
            if (allSocieties != null)
                foreach (var (society, member, address) in allSocieties)
                    Console.WriteLine($"{society}, {member.person}, {address}");
        }
    }
}

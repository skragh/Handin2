using System;

namespace Opgave4
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

            Console.WriteLine("\n--- Gets all Rooms in Municipality (Example: 8300 Odder) ---\n");
            var roomsInOdder = query.GetRoomsInMunicipality(8300);
            if (roomsInOdder != null)
                foreach (var room in roomsInOdder)
                    Console.WriteLine($"{room}");


            Console.WriteLine("\n--- Gets all Societies by Activity (Example: Computing) ---\n");
            var allSocieties = query.GetSocietiesByActivity("Computing");
            if (allSocieties != null)
                foreach (var (society, member, address) in allSocieties)
                    Console.WriteLine($"{society}, {member.person}, {address}");


            Console.WriteLine("\n--- Gets all Booked Rooms ---\n");
            var allBookedRooms = query.GetAllBookedRooms();
            if (allBookedRooms != null)
                foreach (var (room, location, person, timespan) in allBookedRooms)
                    Console.WriteLine($"{room}, {location}, {person}, {timespan}");


            Console.WriteLine("\n--- Gets all Future Bookings with Access key for a Key Responsible (Example: KeyResponsibleId = 1) ---\n");
            var allFutureBookings = query.GetFutureBookingsWithAccessKey(1);
            if (allFutureBookings != null)
                foreach (var (booking, accessKey) in allFutureBookings)
                    Console.WriteLine("{booking}, {accessKey}");
        }
    }
}

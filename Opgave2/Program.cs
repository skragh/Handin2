using System;
using System.IO;
using System.Linq;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new MuncipalityDbContext();
            Dataseed data = new Dataseed();
            if (!context.addresses.Any())
                data.SeedData();

            string input = "";

            Console.WriteLine("Welcome to DAB Handin 2!");
            while (input != "0")
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("[1] Query all Rooms in 8300, Odder.");
                Console.WriteLine("[2] Query all Societies with Activity = \"Skydning\".");
                Console.WriteLine("[3] Query all Rooms booked.");
                Console.WriteLine("[0] Quit the program.");

                Console.Write(">");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("\n--- All rooms in 8000, Odder ---\n");
                    var zipCode = 8000;
                    var roomsInOdder = from location in context.locations
                                       where location.municipality.zipCode == zipCode
                                       join room in context.rooms
                                       on location.locationId equals room.location.locationId
                                       join address in context.addresses
                                       on location.address equals address
                                       select new { room = room, address = address };
                    if (roomsInOdder != null)
                        foreach (var obj in roomsInOdder)
                            Console.WriteLine($"{obj.room}, {obj.address}");
                    else
                        Console.WriteLine("No results found.");
                }
                else if (input == "2")
                {

                    Console.WriteLine("\n--- All Societies with Activity = \"Skydning\" ---\n");
                    var activity = "Skydning";
                    var allSocieties = from society in context.societies
                                       where society.activity == activity
                                       join member in context.memberships
                                       on society.cvr equals member.society.cvr
                                       where member.isChairman
                                       join address in context.addresses
                                       on society.address equals address
                                       select new { society = society, member = member, address = address };

                    if (allSocieties != null)
                        foreach (var obj in allSocieties)
                            Console.WriteLine($"{obj.society}, {obj.member}, {obj.address}");
                    else
                        Console.WriteLine("No results found.");
                }
                else if (input == "3")
                {

                    Console.WriteLine("\n--- All Rooms booked ---\n");
                    var allRoomsBooked = from booking in context.roomBookings
                                         join room in context.rooms
                                         on booking.timespan.room equals room
                                         join member in context.memberships
                                         on booking.societie equals member.society
                                         where member.isChairman
                                         join location in context.locations
                                         on room.location equals location
                                         select new { room = room, location = location, person = member.person, timespan = booking.timespan };

                    if (allRoomsBooked != null)
                        foreach (var obj in allRoomsBooked)
                            Console.WriteLine($"{obj.room}, {obj.location}, {obj.person}, {obj.timespan}");
                    else
                        Console.WriteLine("No results found.");
                }
                else if (input == "0")
                    break;

                Console.WriteLine();
            }

            Console.WriteLine("\nProgram terminated.");
        }
    }
}

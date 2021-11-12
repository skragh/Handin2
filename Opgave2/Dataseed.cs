using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class Dataseed
    {
        public void SeedData()
        {
            using (var context = new MuncipalityDbContext())
            {
                context.Database.EnsureCreated();

                var address = context.addresses.FirstOrDefault(a => a.AddressId == 1);
                if (address == null)
                {
                    //addresses
                    var address1 = new Addresses { number = 1, postalCode = 8000, street = "Finlandsgade" };
                    var address2 = new Addresses { number = 5, postalCode = 8000, street = "Finlandsgade" };
                    var address3 = new Addresses { number = 17, postalCode = 8200, street = "Paludanen" };
                    var address4 = new Addresses { number = 23, postalCode = 8300, street = "Bisgaardsvej" };
                    var address5 = new Addresses { number = 38, postalCode = 8300, street = "Rosensgade" };
                    var address6 = new Addresses { number = 5, postalCode = 8300, street = "Rådhusgade" };
                    var address7 = new Addresses { number = 35, postalCode = 8660, street = "Gramvej" };
                    var address8 = new Addresses { number = 41, postalCode = 8660, street = "Morten Børupsvej" };
                    var address9 = new Addresses { number = 5, postalCode = 8660, street = "Oddervej" };
                    var address10 = new Addresses { number = 73, postalCode = 8660, street = "Finlandsgade" };
                    var address11 = new Addresses { number = 10, postalCode = 8000, street = "Skolegade" };
                    var address12 = new Addresses { number = 5, postalCode = 8300, street = "Parkvej" };
                    var address13 = new Addresses { number = 3, postalCode = 8660, street = "Morten Børupvej 3" };
                    var address14 = new Addresses { number = 15, postalCode = 8660, street = "Gramvej" };
                    var address15 = new Addresses { number = 14, postalCode = 8381, street = "Tilst Vestervej" };
                    var address16 = new Addresses { number = 11, postalCode = 8200, street = "Gøteborgalle" };
                    var address17 = new Addresses { number = 22, postalCode = 8200, street = "Finlandsgade" };
                    var address18 = new Addresses { number = 1, postalCode = 8000, street = "Gnu Street" };


                    context.addresses.Add(address1);
                    context.addresses.Add(address2);
                    context.addresses.Add(address3);
                    context.addresses.Add(address4);
                    context.addresses.Add(address5);
                    context.addresses.Add(address6);
                    context.addresses.Add(address7);
                    context.addresses.Add(address8);
                    context.addresses.Add(address9);
                    context.addresses.Add(address10);
                    context.addresses.Add(address11);
                    context.addresses.Add(address12);


                    //Persons
                    var person1 = new Persons { address = address4, cpr = "130780-1275", name = "James Doe" };
                    var person2 = new Persons { cpr = "270279-1342", name = "Sam Smith", address = address5 };
                    var person3 = new Persons { cpr = "230154-8909", name = "Donald Duck", address = address6 };
                    var person4 = new Persons { cpr = "011053-7623", name = "Mike Dingus", address = address7 };
                    var person5 = new Persons { cpr = "090999-5432", name = "Sabrina Smith", address = address8 };
                    var person6 = new Persons { cpr = "170895-3203", name = "Doug Johnson", address = address8 };
                    var person7 = new Persons { cpr = "180592-4201", name = "Jerry Ericson", address = address9 };
                    var person8 = new Persons { cpr = "110488-2399", name = "Jim Garry", address = address10 };
                    var person9 = new Persons { cpr = "251289-0173", name = "Eric Gould", address = address11 };
                    //    ('050396-2054', 'Anna Anderson', 'Fake Street 8, 8000 Aarhus C'),
                    //    ('040491-8221', 'George Callaghan', 'Fake Street 11, 8000 Aarhus C'),
                    //    ('160353-2317', 'Richard Matthew Stallman', 'GNU Street 1, 8000 Aarhus C');

                    context.persons.Add(person1);
                    context.persons.Add(person2);
                    context.persons.Add(person3);
                    context.persons.Add(person4);
                    context.persons.Add(person5);
                    context.persons.Add(person6);
                    context.persons.Add(person7);
                    context.persons.Add(person8);
                    context.persons.Add(person9);

                    //Municipalities
                    var municipality1 = new Municipalities { name = "Odder", zipCode = 8300 };
                    var municipality2 = new Municipalities { name = "Aarhus C", zipCode = 8000 };
                    var municipality3 = new Municipalities { name = "Skanderborg", zipCode = 8660 };
                    //    (8300, 'Odder'),
                    //    (8000, 'Aarhus C'),
                    //    (8660, 'Skanderborg');

                    //Societies
                    var society1 = new Societies { municipality = municipality1, activity = "Skydning", address = address12, cvr = "86732412", name = "OdderSkytteforening" };
                    var society2 = new Societies { activity = "Løb", name = "Odder Løbeklub", cvr = "73457219", address = address13, municipality = municipality1 };
                    var society3 = new Societies { activity = "Skydning", name = "Skanderborg Skytteforening", address = address14, municipality = municipality3 };
                    var society4 = new Societies { activity = "Karate", name = "Skanderborg Shotokan Karate", address = address15, municipality = municipality3 };
                    var society5 = new Societies { activity = "Skydning", name = "Aarhus Pistol Klub", address = address16, municipality = municipality2 };
                    var society6 = new Societies { activity = "Skydning", name = "Skytteklubben DSB/AGF", address = address17, municipality = municipality2 };
                    var society7 = new Societies { activity = "Computing", name = "Aarhus Software Society", address = address17, municipality = municipality2 };

                    municipality1.societies.Add(society1);
                    municipality1.societies.Add(society2);
                    municipality2.societies.Add(society5);
                    municipality2.societies.Add(society6);
                    municipality2.societies.Add(society7);
                    municipality3.societies.Add(society3);
                    municipality3.societies.Add(society4);

                    //Memberships
                    List<Memberships> memberships = new List<Memberships>();
                    memberships.Add(new Memberships { isChairman = true, society = society1, person = person1 });
                    memberships.Add(new Memberships { isChairman = false, society = society1, person = person2 });
                    memberships.Add(new Memberships { isChairman = true, society = society2, person = person3 });
                    memberships.Add(new Memberships { isChairman = true, society = society3, person = person4 });
                    memberships.Add(new Memberships { isChairman = false, society = society3, person = person5 });
                    memberships.Add(new Memberships { isChairman = true, society = society4, person = person6 });
                    memberships.Add(new Memberships { isChairman = true, society = society5, person = person7 });
                    memberships.Add(new Memberships { isChairman = false, society = society5, person = person8 });
                    memberships.Add(new Memberships { isChairman = false, society = society5, person = person9 });
                    memberships.Add(new Memberships { isChairman = true, society = society6, person = person1 });
                    memberships.Add(new Memberships { isChairman = false, society = society6, person = person2 });
                    memberships.Add(new Memberships { isChairman = true, society = society7, person = person3 });

                    society1.memberships.Add(memberships[0]);
                    society1.memberships.Add(memberships[1]);
                    society2.memberships.Add(memberships[2]);
                    society3.memberships.Add(memberships[3]);
                    society3.memberships.Add(memberships[4]);
                    society4.memberships.Add(memberships[5]);
                    society5.memberships.Add(memberships[6]);
                    society5.memberships.Add(memberships[7]);
                    society5.memberships.Add(memberships[8]);
                    society6.memberships.Add(memberships[9]);
                    society6.memberships.Add(memberships[10]);
                    society7.memberships.Add(memberships[11]);


                    //Locations
                    List<Locations> locations = new List<Locations>();
                    locations.Add(new Locations { address = address12, description = "Spektrum", municipality = municipality1 });
                    locations.Add(new Locations { address = address13, description = "Morten Børup Skolen", municipality = municipality3 });
                    locations.Add(new Locations { address = address14, description = "Stilling Skole", municipality = municipality3 });
                    locations.Add(new Locations { address = address16, description = "Skytternes Hus", municipality = municipality2 });
                    locations.Add(new Locations { address = address18, description = "The GNU cave", municipality = municipality2 });

                    municipality1.locations.Add(locations[0]);
                    municipality3.locations.Add(locations[1]);
                    municipality3.locations.Add(locations[2]);
                    municipality2.locations.Add(locations[3]);
                    municipality2.locations.Add(locations[4]);

                    //Rooms
                    List<Rooms> rooms = new List<Rooms>();
                    rooms.Add(new Rooms { capacity = 25, location = locations[0], name = "Skydebanen i Spektrum" });
                    rooms.Add(new Rooms { capacity = 300, location = locations[0], name = "Løbebanen ved Spektrum" });
                    rooms.Add(new Rooms { capacity = 25, location = locations[1], name = "Skydebanen ved Morten Børup" });
                    rooms.Add(new Rooms { capacity = 50, location = locations[1], name = "Gymnastiksalen ved Morten Børup" });
                    rooms.Add(new Rooms { capacity = 50, location = locations[2], name = "Gymnastiksalen ved Stilling skole" });
                    rooms.Add(new Rooms { capacity = 30, name = "15 meter skydebane i Skytternes Hus", location = locations[3] });
                    rooms.Add(new Rooms { capacity = 20, name = "10 meter skydebane i Skytterners hus", location = locations[3] });
                    rooms.Add(new Rooms { capacity = 500, name = "The GNU altar", location = locations[4] });

                    
                    //    (4, '15 meter skydebane i Skytternes hus', 30),
                    //    (4, '10 meter skydebane i Skytternes hus', 20),
                    //    (5, 'The GNU Alter', 500);

                }
                context.SaveChanges();
            }
        }
    }
}


//INSERT INTO dbo.Rooms
//VALUES

//GO

//INSERT INTO dbo.Properties
//VALUES
//    ('Omklædning 7', 1),
//    ('Stopur', 1),
//    ('Toilet ved Hovedindgangen', 2),
//    ('Omklædning B', 3),
//    ('Toilet på 1. sal', 3),
//    ('Banekikkerter', 4),
//    ('Kaffemaskine', 4),
//    ('ThinkPad X60 with GNU+Linux Guix', 5);
//GO

//INSERT INTO dbo.Timespans
//VALUES
//    (CONVERT(datetime, '30-09-21 07:00:00 PM', 5), CONVERT(datetime, '30-09-21 10:00:00 PM', 5), 1),
//    (CONVERT(datetime, '02-10-21 09:00:00 AM', 5), CONVERT(datetime, '02-10-21 12:00:00 AM', 5), 2),
//    (CONVERT(datetime, '05-10-21 07:00:00 PM', 5), CONVERT(datetime, '05-10-21 10:00:00 PM', 5), 3),
//    (CONVERT(datetime, '07-10-21 06:00:00 PM', 5), CONVERT(datetime, '07-10-21 07:30:00 PM', 5), 4),
//    (CONVERT(datetime, '05-10-21 06:00:00 PM', 5), CONVERT(datetime, '05-10-21 08:00:00 PM', 5), 5),
//    (CONVERT(datetime, '06-10-21 04:30:00 PM', 5), CONVERT(datetime, '06-10-21 10:00:00 PM', 5), 6),
//    (CONVERT(datetime, '08-10-21 05:00:00 PM', 5), CONVERT(datetime, '08-10-21 07:00:00 PM', 5), 7),
//    (CONVERT(datetime, '10-10-21 09:00:00 AM', 5), CONVERT(datetime, '10-10-21 10:00:00 AM', 5), 8);
//GO

//INSERT INTO dbo.RoomBookings
//VALUES
//    ('86732412', 2, 'Pistolskydning - træning'),
//    ('73457219', 3, 'Staffetløb'),
//    ('87345851', 4, 'Riffelskydning - Omegnsturnering'),
//    ('94652326', 5, 'Jiyu Kumite'),
//    ('85234124', 6, 'Grovpistol - træning'),
//    ('83623658', 7, 'Luftpistol - elitetræning');
//GO

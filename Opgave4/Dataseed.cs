using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class Dataseed
    {
        public void SeedData()
        {
            using (var context = new MuncipalityDbContext())
            {

                context.Database.EnsureCreated();
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
                context.addresses.Add(address13);
                context.addresses.Add(address14);
                context.addresses.Add(address15);
                context.addresses.Add(address16);
                context.addresses.Add(address17);
                context.addresses.Add(address18);


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
                var municipality1 = new Municipalities
                {
                    name = "Odder",
                    zipCode = 8300
                };
                var municipality2 = new Municipalities
                {
                    name = "Aarhus C",
                    zipCode = 8000
                };
                var municipality3 = new Municipalities
                {
                    name = "Skanderborg",
                    zipCode = 8660
                };
                //    (8300, 'Odder'),
                //    (8000, 'Aarhus C'),
                //    (8660, 'Skanderborg');

                // KeyResponsibles
                var keyResponsible1 = new KeyResponsible { person = person1, phone = "59237402", licenseNumber = "68720935" };
                var keyResponsible2 = new KeyResponsible { person = person2, phone = "12398043", licenseNumber = "24860212" };
                var keyResponsible3 = new KeyResponsible { person = person3, phone = "50281234", licenseNumber = "02840302" };
                var keyResponsible4 = new KeyResponsible { person = person4, phone = "10348564", licenseNumber = "65483024" };
                var keyResponsible5 = new KeyResponsible { person = person5, phone = "35840238", licenseNumber = "08340218" };
                var keyResponsible6 = new KeyResponsible { person = person6, phone = "39505830", licenseNumber = "27433493" };
                var keyResponsible7 = new KeyResponsible { person = person7, phone = "38395494", licenseNumber = "54583292" };

                context.keyResponsibles.Add(keyResponsible1);
                context.keyResponsibles.Add(keyResponsible2);
                context.keyResponsibles.Add(keyResponsible3);
                context.keyResponsibles.Add(keyResponsible4);
                context.keyResponsibles.Add(keyResponsible5);
                context.keyResponsibles.Add(keyResponsible6);
                context.keyResponsibles.Add(keyResponsible7);

                //Societies
                var society1 = new Societies { keyResponsible = keyResponsible1, municipality = municipality1, activity = "Skydning", address = address12, cvr = "86732412", name = "OdderSkytteforening" };
                var society2 = new Societies { keyResponsible = keyResponsible2, activity = "Løb", name = "Odder Løbeklub", cvr = "73457219", address = address13, municipality = municipality1 };
                var society3 = new Societies { keyResponsible = keyResponsible3, activity = "Skydning", name = "Skanderborg Skytteforening", cvr = "87345851", address = address14, municipality = municipality3 };
                var society4 = new Societies { keyResponsible = keyResponsible4, activity = "Karate", name = "Skanderborg Shotokan Karate", cvr = "94652326", address = address15, municipality = municipality3 };
                var society5 = new Societies { keyResponsible = keyResponsible5, activity = "Skydning", name = "Aarhus Pistol Klub", cvr = "85234124", address = address16, municipality = municipality2 };
                var society6 = new Societies { keyResponsible = keyResponsible6, activity = "Skydning", name = "Skytteklubben DSB/AGF", cvr = "83623658", address = address17, municipality = municipality2 };
                var society7 = new Societies { keyResponsible = keyResponsible7, activity = "Computing", name = "Aarhus Software Society", cvr = "84516402", address = address17, municipality = municipality2 };

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

                // AccessKeys
                var accessKey1 = new AccessKey { keyAddress = address12, pinCode = "12345213" };
                var accessKey2 = new AccessKey { keyAddress = address13, pinCode = "12456342" };
                var accessKey3 = new AccessKey { keyAddress = address14, pinCode = "83209452" };
                var accessKey4 = new AccessKey { keyAddress = address15, pinCode = "42538230" };
                var accessKey5 = new AccessKey { keyAddress = address11, pinCode = "42590053" };

                context.accessKeys.Add(accessKey1);
                context.accessKeys.Add(accessKey2);
                context.accessKeys.Add(accessKey3);
                context.accessKeys.Add(accessKey4);
                context.accessKeys.Add(accessKey5);

                //Locations
                List<Locations> locations = new List<Locations>();
                locations.Add(new Locations { address = address12, description = "Spektrum", municipality = municipality1, accessKey = accessKey1 });
                locations.Add(new Locations { address = address13, description = "Morten Børup Skolen", municipality = municipality3, accessKey = accessKey2 });
                locations.Add(new Locations { address = address14, description = "Stilling Skole", municipality = municipality3, accessKey = accessKey3 });
                locations.Add(new Locations { address = address16, description = "Skytternes Hus", municipality = municipality2, accessKey = accessKey4 });
                locations.Add(new Locations { address = address18, description = "The GNU cave", municipality = municipality2, accessKey = accessKey5 });

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
                locations[0].rooms.Add(rooms[0]);
                locations[0].rooms.Add(rooms[1]);
                locations[1].rooms.Add(rooms[2]);
                locations[1].rooms.Add(rooms[3]);
                locations[2].rooms.Add(rooms[4]);
                locations[3].rooms.Add(rooms[5]);
                locations[3].rooms.Add(rooms[6]);
                locations[4].rooms.Add(rooms[7]);

                //
                List<Properties> properties = new List<Properties>();
                properties.Add(new Properties { description = "Omklædning 7", location = locations[0] });
                properties.Add(new Properties { description = "Stopur", location = locations[0] });
                properties.Add(new Properties { description = "Toilet ved Hovedindgangen", location = locations[1] });
                properties.Add(new Properties { description = "Omklædning", location = locations[2] });
                properties.Add(new Properties { description = "Toilet på 1. sal", location = locations[2] });
                properties.Add(new Properties { description = "Banekikkerter", location = locations[3] });
                properties.Add(new Properties { description = "Kaffemaskine", location = locations[3] });
                properties.Add(new Properties { description = "Thinkpad x60 with GNU+Linux GUIX", location = locations[4] });
                locations[0].properties.Add(properties[0]);
                locations[0].properties.Add(properties[1]);
                locations[1].properties.Add(properties[2]);
                locations[2].properties.Add(properties[3]);
                locations[2].properties.Add(properties[4]);
                locations[3].properties.Add(properties[5]);
                locations[3].properties.Add(properties[6]);
                locations[4].properties.Add(properties[7]);

                //Timespans
                List<Timespans> timespans = new List<Timespans>();
                timespans.Add(new Timespans { room = rooms[0], openingTime = (new DateTime(2021, 09, 30, 07, 00, 00)), closingTime = (new DateTime(2021, 09, 30, 10, 00, 00)) });
                timespans.Add(new Timespans { room = rooms[1], openingTime = (new DateTime(2021, 10, 02, 09, 00, 00)), closingTime = (new DateTime(2021, 02, 10, 12, 00, 00)) });
                timespans.Add(new Timespans { room = rooms[2], openingTime = (new DateTime(2021, 10, 05, 07, 00, 00)), closingTime = (new DateTime(2021, 10, 05, 10, 00, 00)) });
                timespans.Add(new Timespans { room = rooms[3], openingTime = (new DateTime(2021, 10, 07, 06, 00, 00)), closingTime = (new DateTime(2021, 10, 07, 7, 30, 00)) });
                timespans.Add(new Timespans { room = rooms[4], openingTime = (new DateTime(2021, 10, 05, 06, 00, 00)), closingTime = (new DateTime(2021, 10, 05, 08, 00, 00)) });
                timespans.Add(new Timespans { room = rooms[5], openingTime = (new DateTime(2021, 10, 06, 16, 30, 00)), closingTime = (new DateTime(2021, 10, 06, 22, 00, 00)) });
                timespans.Add(new Timespans { room = rooms[6], openingTime = (new DateTime(2021, 10, 08, 17, 00, 00)), closingTime = (new DateTime(2021, 10, 08, 19, 00, 00)) });
                timespans.Add(new Timespans { room = rooms[7], openingTime = (new DateTime(2021, 10, 10, 09, 00, 00)), closingTime = (new DateTime(2021, 10, 10, 10, 00, 00)) });
                rooms[0].timespans.Add(timespans[0]);
                rooms[1].timespans.Add(timespans[1]);
                rooms[2].timespans.Add(timespans[2]);
                rooms[3].timespans.Add(timespans[3]);
                rooms[4].timespans.Add(timespans[4]);
                rooms[5].timespans.Add(timespans[5]);
                rooms[6].timespans.Add(timespans[6]);
                rooms[7].timespans.Add(timespans[7]);

                //RoomBookings
                List<RoomBookings> roomBookings = new List<RoomBookings>();
                roomBookings.Add(new RoomBookings { societie = society1, properties = properties.GetRange(1, 1), description = "Pistolskydning -træning", timespan = timespans[0] });
                roomBookings.Add(new RoomBookings { societie = society2, properties = properties.GetRange(2, 1), description = "Stafetløb", timespan = timespans[1] });
                roomBookings.Add(new RoomBookings { societie = society3, properties = properties.GetRange(3, 1), description = "Omegnsturnering", timespan = timespans[2] });
                roomBookings.Add(new RoomBookings { societie = society4, properties = properties.GetRange(4, 1), description = "Jiyu Kumite", timespan = timespans[3] });
                roomBookings.Add(new RoomBookings { societie = society5, properties = properties.GetRange(5, 1), description = "Grov Pistol", timespan = timespans[4] });
                roomBookings.Add(new RoomBookings { societie = society6, properties = properties.GetRange(6, 1), description = "Luftpistol Elitetræning", timespan = timespans[5] });
                society1.roomBookings.Add(roomBookings[0]);
                properties[1].roomBookings.Add(roomBookings[0]);
                society2.roomBookings.Add(roomBookings[1]);
                properties[2].roomBookings.Add(roomBookings[1]);
                society3.roomBookings.Add(roomBookings[2]);
                properties[3].roomBookings.Add(roomBookings[2]);
                society4.roomBookings.Add(roomBookings[3]);
                properties[4].roomBookings.Add(roomBookings[3]);
                society5.roomBookings.Add(roomBookings[4]);
                properties[5].roomBookings.Add(roomBookings[4]);
                society6.roomBookings.Add(roomBookings[5]);
                properties[6].roomBookings.Add(roomBookings[5]);

                context.municipalities.Add(municipality1);
                context.municipalities.Add(municipality2);
                context.municipalities.Add(municipality3);

                context.societies.Add(society1);
                context.societies.Add(society2);
                context.societies.Add(society3);
                context.societies.Add(society4);
                context.societies.Add(society5);
                context.societies.Add(society6);
                context.societies.Add(society7);

                foreach (var item in memberships)
                {
                    context.memberships.Add(item);
                }

                foreach (var item in properties)
                {
                    context.properties.Add(item);
                }

                foreach (var item in rooms)
                {
                    context.rooms.Add(item);
                }

                foreach (var item in timespans)
                {
                    context.timespans.Add(item);
                }

                foreach (var item in roomBookings)
                {
                    context.roomBookings.Add(item);
                }

                context.SaveChanges();
            }
        }
    }
}



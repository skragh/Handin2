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
                    context.addresses.Add(new Addresses { AddressId = 0, number = 1, postalCode = 8000, street = "Finlandsgade" });
                    context.addresses.Add(new Addresses { AddressId = 1, number = 5, postalCode = 8000, street = "Finlandsgade" });
                    context.addresses.Add(new Addresses { AddressId= 2,number = 17, postalCode = 8200, street = "Paludanen" });
                }
            }
        }
    }
}

//INSERT INTO dbo.Municipalities
//VALUES
//    (8300, 'Odder'),
//    (8000, 'Aarhus C'),
//    (8660, 'Skanderborg');
//GO

//INSERT INTO dbo.Societies
//VALUES
//    ('86732412', 'Odder Skytteforening', 'Parkvej 5, 8300 Odder', 'Skydning', 8300),
//    ('73457219', 'Odder Løbeklub', 'Bisgaardsvej 14, 8300 Odder', 'Løb', 8300),
//    ('87345851', 'Skanderborg Skytteforening', 'Morten Børupvej 3, 8660 Skanderborg', 'Skydning', 8660),
//    ('94652326', 'Skanderborg Shotokan Karate', 'Gramvej 15, 8660 Skanderborg', 'Karate', 8660),
//    ('85234124', 'Aarhus Pistol Klub', 'Tilst Vestervej 14B, 8381 Tilst', 'Skydning', 8000),
//    ('83623658', 'Skytteklubben DSB/ASF', 'Gøteborgalle 11, 8200 Aarhus Nord', 'Skydning', 8000),
//    ('84516402', 'Aarhus Software Society', 'Finlandsgade 22, 8200 Aarhus Nord', 'Computing', 8000);
//GO

//INSERT INTO dbo.Persons
//VALUES
//    ('130780-1275', 'James Doe', 'Bisgaardsvej 23, 8300 Odder'),
//    ('270279-1342', 'Sam Smith', 'Rosensgade 38, 8300 Odder'),
//    ('230154-8909', 'Donald Duck', 'Rådhusgade 5, 8300 Odder'),
//    ('011053-7623', 'Mike Dingus', 'Gramvej 35, 8660 Skanderborg'),
//    ('090999-5432', 'Sabrina Smith', 'Morten Børupsvej 41, 8660 Skanderborg'),
//    ('170895-3203', 'Doug Johnson', 'Oddervej 5, 8660 Skanderborg'),
//    ('180592-4201', 'Jerry Ericson', 'Finlandsgade 73, 8200 Aarhus Nord'),
//    ('110488-2399', 'Jim Garry', 'Skolegade 10, 8000 Aarhus C'),
//    ('251289-0173', 'Eric Gould', 'Finlandsgade 61, 8200 Aarhus Nord'),
//    ('050396-2054', 'Anna Anderson', 'Fake Street 8, 8000 Aarhus C'),
//    ('040491-8221', 'George Callaghan', 'Fake Street 11, 8000 Aarhus C'),
//    ('160353-2317', 'Richard Matthew Stallman', 'GNU Street 1, 8000 Aarhus C');
//GO

//INSERT INTO dbo.Memberships
//VALUES
//    ('86732412', '130780-1275', 1),
//    ('86732412', '130780-1275', 0),
//    ('73457219', '230154-8909', 1),
//    ('87345851', '011053-7623', 1),
//    ('87345851', '090999-5432', 0),
//    ('94652326', '170895-3203', 1),
//    ('85234124', '180592-4201', 1),
//    ('85234124', '110488-2399', 0),
//    ('85234124', '251289-0173', 0),
//    ('83623658', '040491-8221', 1),
//    ('83623658', '050396-2054', 0),
//    ('84516402', '160353-2317', 1);
//GO

//INSERT INTO dbo.Locations
//VALUES
//    (8300, 'Parkvej 5, 8300 Odder', 'Spektrum'),
//    (8660, 'Morten Børupvej 3, 8660 Skanderborg', 'Morten Børup Skolen'),
//    (8660, 'Gramvej 15, 8660 Skanderborg', 'Stilling Skole'),
//    (8000, 'Gøteborgalle 11, 8200 Aarhus Nord', 'Skytternes Hus'),
//    (8000, 'GNU Street 1, 8000 Aarhus C', 'The GNU Cave');
//GO

//INSERT INTO dbo.Rooms
//VALUES
//    (1, 'Skydebanen i Spektrum', 25),
//    (1, 'Løbebanen ved Spektrum', 300),
//    (2, 'Skydebanen ved Morten Børup', 25),
//    (2, 'Gymnastiksalen ved Morten Børup', 50),
//    (3, 'Gymnastiksalen ved Stilling Skole', 50),
//    (4, '15 meter skydebane i Skytternes hus', 30),
//    (4, '10 meter skydebane i Skytternes hus', 20),
//    (5, 'The GNU Alter', 500);
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

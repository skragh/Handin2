using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Opgave2
{
    class Queries
    {
        private MuncipalityDbContext context;

        public Queries(MuncipalityDbContext context)
        {
            this.context = context;
        }

        public ICollection<Rooms> GetRoomsInMunicipality(int zipCode)
        {
            return (ICollection<Rooms>)(from location in context.locations
                                        where location.municipality.zipCode == zipCode
                                        join room in context.rooms
                                        on location.locationId equals room.location.locationId
                                        select room).ToList();
        }

        public ICollection<(Societies, Memberships, Addresses)> GetSocietiesByActivity(string activity)
        {
            return (ICollection<(Societies, Memberships, Addresses)>)
                (from society in context.societies
                 where society.activity == activity
                 join member in context.memberships
                 on society.cvr equals member.society.cvr
                 where member.isChairman
                 join address in context.addresses
                 on society.address equals address
                 select new { society, member, address }).ToList();
        }

        public ICollection<(Rooms, Locations, Persons, Timespans)> GetAllBookedRooms()
        {
            return (ICollection<(Rooms, Locations, Persons, Timespans)>)
                (from booking in context.roomBookings
                 join room in context.rooms
                 on booking.timespan.room equals room
                 join member in context.memberships
                 on booking.societie equals member.society
                 where member.isChairman
                 join location in context.locations
                 on room.location equals location
                 select new { room, location, member.person, booking.timespan }).ToList();
        }

    }
}

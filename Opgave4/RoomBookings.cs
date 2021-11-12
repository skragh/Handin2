﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    public class RoomBookings
    {
        [Key]
        public int roomBookingId { get; set; }

        [Required]
        public Societies societie { get; set; }

        [Required]
        public Timespans timespan { get; set; }

        [Required]
        public ICollection<Properties> properties { get; set; }

        [MaxLength(100)]
        public string description { get; set; }

        public override string ToString()
        {
            return $"[RoomBookings] - Id: {roomBookingId}, Society: {societie.cvr}, Timespan: {timespan.timespanId}, Description: {description}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string societiecvr { get; set; }

        [Required]
        public Timespans timespan { get; set; }
        public int timespanId { get; set; }

        [Required]
        public List<Properties> properties { get; set; } = new List<Properties>();

        [MaxLength(100)]
        public string description { get; set; }

        public override string ToString()
        {
            return $"[RoomBookings] - Id: {roomBookingId}, Society: {societiecvr}, Timespan: {timespanId}, Description: {description}";
        }
    }
}

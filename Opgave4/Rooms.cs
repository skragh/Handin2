using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Opgave4
{
    public class Rooms
    {
        [Key]
        public int roomId { get; set; }
        [Required]
        public Locations location { get; set; }
        public int locationId { get; set; }

        [MaxLength(100)]
        public string name { get; set; }

        public int capacity { get; set; }

        public ICollection<Timespans> timespans { get; set; }

        public override string ToString() {
            return $"[Rooms] - Id: {roomId}, Location: {location.locationId}, Name: {name}, Capacity: {capacity}";
        }
    }
}

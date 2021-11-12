using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Opgave2
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

        public List<Timespans> timespans { get; } = new List<Timespans>();

        public override string ToString()
        {
            return $"[Rooms] - Id: {roomId}, Location: {locationId}";
            //", Name: {name}, Capacity: {capacity}";
        }
    }
}

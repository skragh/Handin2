using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Opgave2
{
    public class Locations
    {
        [Key]
        public int locationId { get; set; }

        public Municipalities municipality { get; set; }

        public Addresses address { get; set; }

        [MaxLength(255)]
        public string description { get; set; }

        public List<Rooms> rooms { get; set; } = new List<Rooms>();

        public List<Properties> properties { get; set; } = new List<Properties>();

        public override string ToString()
        {
            return $"[Locations] - Id: {locationId}, Municipality: {municipality}, Address: {address.ToString()}, Description: {description}";
        }
    }
}

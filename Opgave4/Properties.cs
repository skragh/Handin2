using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    public class Properties
    {
        [Key]
        public int propertyId { get; set; }

        [Required]
        public Locations location { get; set; }
        public int locationId { get; set; }

        [MaxLength(100)]
        public string description { get; set; }

        //[ForeignKey("RoomBookings")]
        public List<RoomBookings> roomBookings { get; } = new List<RoomBookings>();

        public override string ToString()
        {
            return $"[Properties] - Id: {propertyId}, Location: {locationId}, Description: {description}";
        }
    }
}

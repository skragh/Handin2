using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    public class Societies
    {
        [Key]
        [MaxLength(8)]
        public string cvr { get; set; }

        [Required]
        [MaxLength(100)]
        public string name { get; set; }

        [Required]
        [MaxLength(100)]
        public string activity { get; set; }

        [Required]
        public Addresses address { get; set; }
        [Required]
        public Municipalities municipality { get; set; }
        public ICollection<Memberships> memberships { get; set; }

        public ICollection<RoomBookings> roomBookings { get; set; }

        public override string ToString()
        {
            return $"[Societies] - CVR: {cvr}, Name: {name}, Activity: {activity}, Address {address}, Municipality: {municipality.zipCode}";
        }
    }
}

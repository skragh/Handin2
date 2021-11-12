using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int addressId { get; set; }

        [Required]
        public Municipalities municipality { get; set; }
        public int zipCode { get; set; }

        public List<Memberships> memberships { get; } = new List<Memberships>();

        public List<RoomBookings> roomBookings { get; } = new List<RoomBookings>();

        public override string ToString()
        {
            return $"[Societies] - CVR: {cvr}, Name: {name}, Activity: {activity}, Address {address}, Municipality: {zipCode}";
        }
    }
}

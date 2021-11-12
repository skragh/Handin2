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
        public Addresses adress { get; set; }

        [Required]
        public Municipalities municipality { get; set; }

        [Required]
        public KeyResponsible keyResponsible { get; set; }

        public ICollection<RoomBookings> roomBookings { get; set; }
    }
}

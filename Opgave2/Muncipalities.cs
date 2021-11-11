using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    public class Municipalities
    {
        [Key]
        public int zipCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string name { get; set; }
        public ICollection<Locations> locations { get; set; }
        public ICollection<Societies> societies { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public List<Locations> locations { get; } = new List<Locations>();

        public List<Societies> societies { get; } = new List<Societies>();

        public override string ToString()
        {
            return $"[Municipalities] - ZipCode: {zipCode}, Name: {name}";
        }
    }
}

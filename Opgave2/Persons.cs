using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    public class Persons
    {
        [Key]
        [Required]
        [MaxLength(11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string cpr { get; set; }

        [Required]
        [MaxLength(100)]
        public string name { get; set; }

        [Required]
        public Addresses address { get; set; }
        public int addressId { get; set; }

        public override string ToString()
        {
            return $"[Persons] - CPR: {cpr}, Name: {name}, Address: {addressId}";
        }
    }
}

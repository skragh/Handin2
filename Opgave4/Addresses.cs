using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Opgave4
{
    public class Addresses
    {
        [Key]
        public int addressId { get; set; }

        [Required]
        [MaxLength(100)]
        public string street { get; set; }

        [Required]
        public int number { get; set; }

        [Required]
        [MaxLength(4)]
        [MinLength(4)]
        public int postalCode { get; set; }

        public override string ToString()
        {
            return $"[Addresses] - Id: {addressId}, Street: {street}, Number: {number}, PostalCode: {postalCode}";
        }
    }
}

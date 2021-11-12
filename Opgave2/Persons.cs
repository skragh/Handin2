﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string cpr { get; set; }

        [Required]
        [MaxLength(100)]
        public string name { get; set; }

        [Required]
        public Addresses address { get; set; }

        public override string ToString() {
            return $"[Persons] - CPR: {cpr}, Name: {name}, Address: {address.addressId}";
        }
    }
}

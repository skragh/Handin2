﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
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

        public override string ToString()
        {
            return $"[Municipalities] - ZipCode: {zipCode}, Name: {name}";
        }
    }
}
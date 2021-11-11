﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class Municipalities
    {
        [Key]
        public int zipCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string name { get; set; }
        public List<Locations> locations { get; set; }
        public List Societies { get; set; }
    }
}

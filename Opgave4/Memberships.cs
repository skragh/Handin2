﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    public class Memberships
    {
        public int membershipId { get; set; }
        [Required]
        public Societies society { get; set; }
        [Required]
        public Persons person { get; set; }
        public bool isChairman { get; set; }
    }
}

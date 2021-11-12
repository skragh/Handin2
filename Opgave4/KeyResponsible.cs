using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Opgave4
{
    public class KeyResponsible
    {
        public Persons person { get; set; }

        [MaxLength(8)]
        [MinLength(8)]
        public string phone { get; set; }

        [MaxLength(8)]
        [MinLength(8)]
        public string licenseNumber { get; set; }
    }
}

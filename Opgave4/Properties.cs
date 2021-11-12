﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    public class Properties
    {
        [Key]
        public int propertyId { get; set; }
        
        [Required]
        public Locations location { get; set; }
        
        public int locationId { get; set; }
        
        [MaxLength(100)]
        public string description { get; set; }

        public override string ToString()
        {
            return $"[Properties] - Id: {propertyId}, Location: {location.locationId}, Description: {description}";
        }
    }
}

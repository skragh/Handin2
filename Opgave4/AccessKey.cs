using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Opgave4
{
    public class AccessKey
    {
        [Key]
        public int accessKeyId { get; set; }

        public Addresses keyAddress { get; set; }
        public int addressId { get; set; }

        [MaxLength(8)]
        public string pinCode { get; set; }
    }
}

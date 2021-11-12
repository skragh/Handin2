using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    public class Memberships
    {
        [Key]
        public int membershipId { get; set; }

        [Required]
        public Societies society { get; set; }
        public string societycvr { get; set; }

        [Required]
        public Persons person { get; set; }
        public string personcpr { get; set; }

        public bool isChairman { get; set; }

        public override string ToString()
        {
            return $"[Memberships] - Id: {membershipId}, Society: {societycvr}, Person: {personcpr}, isChairman: {isChairman}";
        }
    }
}

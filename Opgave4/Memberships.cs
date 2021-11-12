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
        public string cvr { get; set; }

        [Required]
        public Persons person { get; set; }
        public string cpr { get; set; }

        public bool isChairman { get; set; }

        public override string ToString()
        {
            return $"[Memberships] - Id: {membershipId}, Society: {cvr}, Person: {cpr}, isChairman: {isChairman}";
        }
    }
}

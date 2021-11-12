using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    public class Memberships
    {
        [Key]
        public int membershipId { get; set; }

        [Required]
        public Societies society { get; set; }

        [Required]
        public Persons person { get; set; }

        public bool isChairman { get; set; }

        public override string ToString()
        {
            return $"[Memberships] - Id: {membershipId}, Society: {society.cvr}, Person: {person.cpr}, isChairman: {isChairman}";
        }
    }
}

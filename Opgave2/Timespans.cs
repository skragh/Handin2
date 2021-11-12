using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Opgave2
{
    public class Timespans
    {
        [Key]
        public int timespanId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime openingTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime closingTime { get; set; }

        public Rooms room { get; set; }
        public int roomId { get; set; }

        public override string ToString()
        {
            return $"[Timespans] - Id: {timespanId}, OpeningTime: {openingTime.ToString()}, ClosingTime: {closingTime.ToString()}, Room: {roomId}";
        }
    }
}

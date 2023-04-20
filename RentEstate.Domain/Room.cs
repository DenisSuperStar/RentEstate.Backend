using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentEstate.Domain
{
    public class Room : Flat
    {
        public bool IsRampant { get; set; }
        public bool IsGarbageChute { get; set; }
        public string? Parking { get; set; }
    }
}

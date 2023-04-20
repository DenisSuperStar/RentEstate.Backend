using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentEstate.Domain
{
    public class House : Estate
    {
        public string? Address { get; set; }
        public string? LandPlotNumber { get; set; }
        public string? CottageVillageNumber { get; set; }
        public DateOnly? ConstructYear { get; set; }
        public string? HouseMaterial { get; set; }
        public int HouseArea { get; set; }
        public int FloorCount { get; set; }
        public int BedroomNumber { get; set; }
        public bool Outdoors { get; set; }
        public string? Heating { get; set; }
        public bool HasFurnitureInRooms { get; set; }
        public bool HasFurnitureKitchen { get; set; }
        public bool HasBathOutdoors { get; set; }
        public bool HasGarage { get; set; }
        public bool HasPool { get; set; }
    }
}

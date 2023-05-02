using MediatR;

namespace RentEstate.Application.Entities.Estate.PartOfHouse.Commands.UpdatePartOfHouse
{
    public class UpdatePartOfHouseCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid EstateId { get; set; }
        public DateTime? DatePublish { get; set; }
        public bool IsRent { get; set; }
        public bool IsSale { get; set; }
        public bool IsResident { get; set; }
        public bool IsCommercial { get; set; }
        public bool IsPet { get; set; }
        public bool IsChildren { get; set; }
        public bool IsKitchen { get; set; }
        public bool HasRepair { get; set; }
        public string? RepairType { get; set; }
        public string? VideoUrl { get; set; }
        public string? TitleAd { get; set; }
        public string? DescriptionAd { get; set; }
        public int Payment { get; set; }
        public int PaymentOwner { get; set; }
        public bool IsPaymentOwner { get; set; }
        public string? PaymentEarly { get; set; }
        public bool IsFridge { get; set; }
        public bool IsDishwasher { get; set; }
        public bool IsWashMachine { get; set; }
        public bool IsTV { get; set; }
        public bool IsTelephone { get; set; }
        public bool IsInternet { get; set; }
        public bool IsBathroom { get; set; }
        public bool IsShower { get; set; }
        public string? Address { get; set; }
        public string? LandPlotNumber { get; set; }
        public string? CottageVillageNumber { get; set; }
        public DateOnly? ConstructYear { get; set; }
        public string? HouseMaterial { get; set; }
        public int HouseArea { get; set; }
        public int FloorCount { get; set; }
        public int BedroomNumber { get; set; }
        public bool ToiletOutdoors { get; set; }
        public bool ShowerOutddors { get; set; }
        public string? Heating { get; set; }
        public bool HasFurnitureInRooms { get; set; }
        public bool HasFurnitureKitchen { get; set; }
        public bool HasGarage { get; set; }
        public bool HasPool { get; set; }
        public int PartForRent { get; set; }
        public bool HasSelfEmployed { get; set; }
    }
}

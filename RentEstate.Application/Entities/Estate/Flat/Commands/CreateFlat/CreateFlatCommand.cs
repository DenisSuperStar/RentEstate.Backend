using MediatR;

namespace RentEstate.Application.Entities.Estate.Flat.Commands.CreateFlat
{
    public class CreateFlatCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public Guid EstateId { get; set; }
        public DateTime? DatePublish { get; set; }
        public bool IsPublish { get; set; }
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
        public bool IsFlat { get; set; }
        public bool IsApartments { get; set; }
        public int CountRooms { get; set; }
        public bool IsPenthouse { get; set; }
        public bool IsElevator { get; set; }
        public int ElevatorsCount { get; set; }
        public int TotalArea { get; set; }
        public int Floor { get; set; }
        public int FloorsInHouse { get; set; }
        public bool IsFurniture { get; set; }
        public bool HasWindowToYard { get; set; }
        public bool HasWindowToStreet { get; set; }
        public bool IsBalcony { get; set; }
        public bool IsLoggia { get; set; }
        public bool IsSeparatedBathroom { get; set; }
    }
}


using AutoMapper;
using RentEstate.Application.Common.Mappings;
using RentEstate.Application.Entities.Estate.Tawnhouse.Queries;

namespace RentEstate.Application.Entities.Estate.PartOfHouse.Queries
{
    public class PartOfHouseListDto : IMapWith<Domain.PartOfHouse>
    {
        public Guid Id { get; set; } //*
        public DateTime? Publish { get; set; } //*
        public bool HasOwner { get; set; } //*
        public bool HasBuyer { get; set; } //*
        public bool HasLived { get; set; } //*
        public bool HasPrivate { get; set; } //*
        public bool AllowPet { get; set; } //*
        public bool AllowChildren { get; set; } //*
        public bool HasKitchen { get; set; }
        public bool Repair { get; set; }
        public string? Type { get; set; }
        public string? Video { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Payment { get; set; }
        public int PayOwner { get; set; }
        public bool IsPayment { get; set; }
        public string? PayEarly { get; set; }
        public bool HasFridge { get; set; }
        public bool HasDishwasher { get; set; }
        public bool HasWashmachine { get; set; }
        public bool HasTV { get; set; }
        public bool HasTelephone { get; set; }
        public bool HasInternet { get; set; }
        public bool HasBathroom { get; set; } //*
        public bool HasShower { get; set; } //*
        public string? Address { get; set; } //*
        public string? LandPlotNumber { get; set; }
        public string? CottageVillageNumber { get; set; }
        public DateOnly? BuildingYear { get; set; }
        public string? ConstructMaterial { get; set; }
        public int Area { get; set; }
        public int Floor { get; set; }
        public int Bedrooms { get; set; }
        public bool HasToiletRoom { get; set; } //*
        public bool HasShowerRoom { get; set; } //*
        public string? Heated { get; set; } //*
        public bool FurnitureRooms { get; set; } //*
        public bool FurnitureKitchen { get; set; } //*
        public bool Garage { get; set; }
        public bool Pool { get; set; }
        public bool PieceForRent { get; set; }
        public bool SelfEmployed { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.PartOfHouse, PartOfHouseListDto>()
                .ForMember(search => search.Id, option => option.MapFrom(src => src.EstateId))
                .ForMember(search => search.Publish, option => option.MapFrom(src => src.DatePublish))
                .ForMember(search => search.HasOwner, option => option.MapFrom(src => src.IsRent))
                .ForMember(search => search.HasBuyer, option => option.MapFrom(src => src.IsSale))
                .ForMember(search => search.HasLived, option => option.MapFrom(src => src.IsResident))
                .ForMember(search => search.HasPrivate, option => option.MapFrom(src => src.IsCommercial))
                .ForMember(search => search.AllowPet, option => option.MapFrom(src => src.IsPet))
                .ForMember(search => search.AllowChildren, option => option.MapFrom(src => src.IsChildren))
                .ForMember(search => search.HasKitchen, option => option.MapFrom(src => src.IsKitchen))
                .ForMember(search => search.Repair, option => option.MapFrom(src => src.HasRepair))
                .ForMember(search => search.Type, option => option.MapFrom(src => src.RepairType))
                .ForMember(search => search.Video, option => option.MapFrom(src => src.VideoUrl))
                .ForMember(search => search.Title, option => option.MapFrom(src => src.TitleAd))
                .ForMember(search => search.Description, option => option.MapFrom(src => src.DescriptionAd))
                .ForMember(search => search.Payment, option => option.MapFrom(src => src.Payment))
                .ForMember(search => search.PayOwner, option => option.MapFrom(src => src.PaymentOwner))
                .ForMember(search => search.IsPayment, option => option.MapFrom(src => src.IsPaymentOwner))
                .ForMember(search => search.PayEarly, option => option.MapFrom(src => src.PaymentEarly))
                .ForMember(search => search.HasFridge, option => option.MapFrom(src => src.IsFridge))
                .ForMember(search => search.HasDishwasher, option => option.MapFrom(src => src.IsDishwasher))
                .ForMember(search => search.HasWashmachine, option => option.MapFrom(src => src.IsWashMachine))
                .ForMember(search => search.HasTV, option => option.MapFrom(src => src.IsTV))
                .ForMember(search => search.HasTelephone, option => option.MapFrom(src => src.IsTelephone))
                .ForMember(search => search.HasInternet, option => option.MapFrom(src => src.IsInternet))
                .ForMember(search => search.HasBathroom, option => option.MapFrom(src => src.IsBathroom))
                .ForMember(search => search.HasShower, option => option.MapFrom(src => src.IsShower))
                .ForMember(search => search.Address, option => option.MapFrom(src => src.Address))
                .ForMember(search => search.LandPlotNumber, option => option.MapFrom(src => src.LandPlotNumber))
                .ForMember(search => search.CottageVillageNumber, option => option.MapFrom(src => src.CottageVillageNumber))
                .ForMember(search => search.BuildingYear, option => option.MapFrom(src => src.ConstructYear))
                .ForMember(search => search.ConstructMaterial, option => option.MapFrom(src => src.HouseMaterial))
                .ForMember(search => search.Area, option => option.MapFrom(src => src.HouseArea))
                .ForMember(search => search.Floor, option => option.MapFrom(src => src.FloorCount))
                .ForMember(search => search.Bedrooms, option => option.MapFrom(src => src.BedroomNumber))
                .ForMember(search => search.HasToiletRoom, option => option.MapFrom(src => src.ToiletOutdoors))
                .ForMember(search => search.HasShowerRoom, option => option.MapFrom(src => src.ShowerOutdoors))
                .ForMember(search => search.Heated, option => option.MapFrom(src => src.Heating))
                .ForMember(search => search.FurnitureRooms, option => option.MapFrom(src => src.HasFurnitureInRooms))
                .ForMember(search => search.FurnitureKitchen, option => option.MapFrom(src => src.HasFurnitureKitchen))
                .ForMember(search => search.Garage, option => option.MapFrom(src => src.HasGarage))
                .ForMember(search => search.Pool, option => option.MapFrom(src => src.HasPool))
                .ForMember(search => search.PieceForRent, option => option.MapFrom(src => src.PartForRent))
                .ForMember(search => search.SelfEmployed, option => option.MapFrom(src => src.HasSelfEmployed));
        }
    }
}

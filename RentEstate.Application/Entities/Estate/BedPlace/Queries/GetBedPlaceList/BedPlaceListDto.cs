using AutoMapper;
using RentEstate.Application.Common.Mappings;

namespace RentEstate.Application.Entities.Estate.BedPlace.Queries.GetBedPlaceList
{
    public class BedPlaceListDto : IMapWith<Domain.BedPlace>
    {
        public Guid Id { get; set; } //*
        public DateTime? Publish { get; set; } //*
        public bool HasOwner { get; set; } //*
        public bool HasBuyer { get; set; } //*
        public bool HasLived { get; set; } //*
        public bool HasPrivate { get; set; } //*
        public bool AllowPet { get; set; } //*
        public bool AllowChildren { get; set; } //*
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
        public bool HasFlat { get; set; }
        public bool HasApartments { get; set; }
        public int Rooms { get; set; } //*
        public bool HasPenthouse { get; set; }
        public bool HasElevator { get; set; } //*
        public int Elevators { get; set; }
        public int Area { get; set; }
        public int LivingFloor { get; set; } //*
        public int Floors { get; set; }
        public bool HasFurniture { get; set; } //*
        public bool HasViewToYard { get; set; }
        public bool HasViewToStreet { get; set; }
        public bool HasBalcony { get; set; } //*
        public bool HasLoggia { get; set; } //*
        public bool HasSeparateBathroom { get; set; }
        public bool HasRampant { get; set; }
        public bool HasChute { get; set; }
        public string? CarsParking { get; set; }


        public void Mapping(Profile profile) {
            profile.CreateMap<Domain.BedPlace, BedPlaceListDto>()
                .ForMember(search => search.Id, option => option.MapFrom(src => src.EstateId))
                .ForMember(search => search.Publish, option => option.MapFrom(src => src.DatePublish))
                .ForMember(search => search.HasOwner, option => option.MapFrom(src => src.IsRent))
                .ForMember(search => search.HasBuyer, option => option.MapFrom(src => src.IsSale))
                .ForMember(search => search.HasLived, option => option.MapFrom(src => src.IsResident))
                .ForMember(search => search.HasPrivate, option => option.MapFrom(src => src.IsCommercial))
                .ForMember(search => search.AllowPet, option => option.MapFrom(src => src.IsPet))
                .ForMember(search => search.AllowChildren, option => option.MapFrom(src => src.IsChildren))
                .ForMember(search => search.Repair, option => option.MapFrom(src => src.RepairType))
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
                .ForMember(search => search.HasFlat, option => option.MapFrom(src => src.IsFlat))
                .ForMember(search => search.HasApartments, option => option.MapFrom(src => src.IsApartments))
                .ForMember(search => search.Rooms, option => option.MapFrom(src => src.CountRooms))
                .ForMember(search => search.HasPenthouse, option => option.MapFrom(src => src.IsPenthouse))
                .ForMember(search => search.HasElevator, option => option.MapFrom(src => src.IsElevator))
                .ForMember(search => search.Elevators, option => option.MapFrom(src => src.ElevatorsCount))
                .ForMember(search => search.Area, option => option.MapFrom(src => src.TotalArea))
                .ForMember(search => search.LivingFloor, option => option.MapFrom(src => src.Floor))
                .ForMember(search => search.Floors, option => option.MapFrom(src => src.FloorsInHouse))
                .ForMember(search => search.HasFurniture, option => option.MapFrom(src => src.IsFurniture))
                .ForMember(search => search.HasViewToYard, option => option.MapFrom(src => src.HasWindowToYard))
                .ForMember(search => search.HasViewToStreet, option => option.MapFrom(src => src.HasWindowToStreet))
                .ForMember(search => search.HasBalcony, option => option.MapFrom(src => src.IsBalcony))
                .ForMember(search => search.HasLoggia, option => option.MapFrom(src => src.IsLoggia))
                .ForMember(search => search.HasSeparateBathroom, option => option.MapFrom(src => src.IsSeparatedBathroom))
                .ForMember(search => search.HasRampant, option => option.MapFrom(src => src.IsRampant))
                .ForMember(search => search.HasChute, option => option.MapFrom(src => src.IsGarbageChute))
                .ForMember(search => search.CarsParking, option => option.MapFrom(src => src.Parking));
        }
    }
}

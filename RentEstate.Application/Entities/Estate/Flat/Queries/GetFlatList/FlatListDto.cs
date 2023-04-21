using AutoMapper;
using RentEstate.Application.Common.Mappings;

namespace RentEstate.Application.Entities.Estate.Flat.Queries.GetFlatList
{
    public class FlatListDto : IMapWith<Domain.Flat>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public bool HasPlaced { get; set; }
        public bool HasOwner { get; set; }
        public bool HasBuyer { get; set; }
        public bool HasLived { get; set; }
        public bool HasPrivate { get; set; }
        public bool AllowPet { get; set; }
        public bool AllowChildren { get; set; }
        public bool HasBathroom { get; set; }
        public bool HasShowerRoom { get; set; }
        public string? Address { get; set; }
        public int Rooms { get; set; }
        public bool HasElevator { get; set; }
        public int LivingFloor { get; set; }
        public bool HasFurniture { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasLoggia { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<Domain.Flat, FlatListDto>()
                .ForMember(search => search.UserId, option => option.MapFrom(src => src.UserId))
                .ForMember(search => search.Id, option => option.MapFrom(src => src.EstateId))
                .ForMember(search => search.HasPlaced, option => option.MapFrom(src => src.IsPublish))
                .ForMember(search => search.HasOwner, option => option.MapFrom(src => src.IsRent))
                .ForMember(search => search.HasBuyer, option => option.MapFrom(src => src.IsSale))
                .ForMember(search => search.HasLived, option => option.MapFrom(src => src.IsResident))
                .ForMember(search => search.HasPrivate, option => option.MapFrom(src => src.IsCommercial))
                .ForMember(search => search.AllowPet, option => option.MapFrom(src => src.IsPet))
                .ForMember(search => search.AllowChildren, option => option.MapFrom(src => src.IsChildren))
                .ForMember(search => search.HasBathroom, option => option.MapFrom(src => src.IsBathroom))
                .ForMember(search => search.HasShowerRoom, option => option.MapFrom(src => src.IsShower))
                .ForMember(search => search.Address, option => option.MapFrom(src => src.Address))
                .ForMember(search => search.Rooms, option => option.MapFrom(src => src.CountRooms))
                .ForMember(search => search.HasElevator, option => option.MapFrom(src => src.IsElevator))
                .ForMember(search => search.LivingFloor, option => option.MapFrom(src => src.Floor))
                .ForMember(search => search.HasFurniture, option => option.MapFrom(src => src.IsFurniture))
                .ForMember(search => search.HasBalcony, option => option.MapFrom(src => src.IsBalcony))
                .ForMember(search => search.HasLoggia, option => option.MapFrom(src => src.IsLoggia));
        }
    }
}

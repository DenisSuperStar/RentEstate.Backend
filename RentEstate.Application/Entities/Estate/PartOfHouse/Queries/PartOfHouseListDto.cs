
using AutoMapper;
using RentEstate.Application.Common.Mappings;

namespace RentEstate.Application.Entities.Estate.PartOfHouse.Queries
{
    public class PartOfHouseListDto : IMapWith<Domain.PartOfHouse>
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
        public bool HasBathroomOut { get; set; }
        public bool HasShowerRoomOut { get; set; }
        public bool HasHitRoom { get; set; }
        public bool HasRoomFurniture { get; set; }
        public bool HasKitchenFurniture { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<Domain.PartOfHouse, PartOfHouseListDto>()
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
                .ForMember(search => search.HasBathroomOut, option => option.MapFrom(src => src.Outdoors))
                .ForMember(search => search.HasShowerRoomOut, option => option.MapFrom(src => src.HasBathOutdoors))
                .ForMember(search => search.HasHitRoom, option => option.MapFrom(src => src.Heating))
                .ForMember(search => search.HasRoomFurniture, option => option.MapFrom(src => src.HasFurnitureInRooms))
                .ForMember(search => search.HasKitchenFurniture, option => option.MapFrom(src => src.HasFurnitureKitchen));
        }
    }
}

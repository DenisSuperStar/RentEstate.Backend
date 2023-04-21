using AutoMapper;
using RentEstate.Application.Common.Mappings;

namespace RentEstate.Application.Entities.Estate.BedPlace.Queries.GetBedPlaceList
{
    public class BedPlaceListDto : IMapWith<Domain.BedPlace>
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
        public string? AllowParked { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<Domain.BedPlace, BedPlaceListDto>()
                .ForMember(map => map.UserId, option => option.MapFrom(src => src.UserId))
                .ForMember(map => map.Id, option => option.MapFrom(src => src.EstateId))
                .ForMember(map => map.HasPlaced, option => option.MapFrom(src => src.IsPublish))
                .ForMember(map => map.HasOwner, option => option.MapFrom(src => src.IsRent))
                .ForMember(map => map.HasBuyer, option => option.MapFrom(src => src.IsSale))
                .ForMember(map => map.HasLived, option => option.MapFrom(src => src.IsResident))
                .ForMember(map => map.HasPrivate, option => option.MapFrom(src => src.IsCommercial))
                .ForMember(map => map.AllowPet, option => option.MapFrom(src => src.IsPet))
                .ForMember(map => map.AllowChildren, option => option.MapFrom(src => src.IsChildren))
                .ForMember(map => map.HasBathroom, option => option.MapFrom(src => src.IsBathroom))
                .ForMember(map => map.HasShowerRoom, option => option.MapFrom(src => src.IsShower))
                .ForMember(map => map.AllowParked, option => option.MapFrom(src => src.Parking));
        }
    }
}

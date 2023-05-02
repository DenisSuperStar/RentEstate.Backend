using MediatR;

namespace RentEstate.Application.Entities.Estate.BedPlace.Queries.GetBedPlaceList
{
    public class GetBedPlaceListQuery : IRequest<BedPlaceListVm>
    {
        public Guid UserId { get; set; }
    }
}

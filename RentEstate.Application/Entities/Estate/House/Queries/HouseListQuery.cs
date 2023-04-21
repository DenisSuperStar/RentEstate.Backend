using MediatR;

namespace RentEstate.Application.Entities.Estate.House.Queries
{
    public class HouseListQuery : IRequest<HouseListVm>
    {
        public Guid UserId { get; set; }
    }
}

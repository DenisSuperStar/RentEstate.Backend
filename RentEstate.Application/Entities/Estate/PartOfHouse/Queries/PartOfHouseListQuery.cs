using MediatR;

namespace RentEstate.Application.Entities.Estate.PartOfHouse.Queries
{
    public class PartOfHouseListQuery : IRequest<PartOfHouseListVm>
    {
        public Guid UserId { get; set; }
    }
}

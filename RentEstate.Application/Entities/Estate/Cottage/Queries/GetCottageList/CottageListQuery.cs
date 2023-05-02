using MediatR;

namespace RentEstate.Application.Entities.Estate.Cottage.Queries.GetCottageList
{
    public class CottageListQuery : IRequest<CottageListVm>
    {
        public Guid UserId { get; set; }

    }
}

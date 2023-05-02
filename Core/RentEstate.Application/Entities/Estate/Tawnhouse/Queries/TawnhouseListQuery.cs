using MediatR;

namespace RentEstate.Application.Entities.Estate.Tawnhouse.Queries
{
    public class TawnhouseListQuery : IRequest<TawnhouseListVm>
    {
        public Guid UserId { get; set; }
    }
}

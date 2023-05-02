
using MediatR;

namespace RentEstate.Application.Entities.Estate.Flat.Queries.GetFlatList
{
    public class FlatListQuery : IRequest<FlatListVm>
    {
        public Guid UserId { get; set; }
    }
}

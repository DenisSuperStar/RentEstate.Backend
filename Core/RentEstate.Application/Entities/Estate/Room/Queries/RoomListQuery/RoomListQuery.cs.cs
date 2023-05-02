using MediatR;

namespace RentEstate.Application.Entities.Estate.Room.Queries.RoomListQuery
{
    public class RoomListQuery : IRequest<RoomListVm>
    {
        public Guid UserId { get; set; }
    }
}

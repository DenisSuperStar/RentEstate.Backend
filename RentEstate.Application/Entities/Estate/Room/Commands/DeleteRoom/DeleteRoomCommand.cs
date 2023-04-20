using MediatR;

namespace RentEstate.Application.Entities.Estate.Room.Commands.DeleteRoom
{
    public class DeleteRoomCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid EstateId { get; set; }

    }
}

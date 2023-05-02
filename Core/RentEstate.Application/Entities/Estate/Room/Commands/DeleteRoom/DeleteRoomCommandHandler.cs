using MediatR;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Room.Commands.DeleteRoom
{
    public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public DeleteRoomCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
        {
            var room = await _dbContext.Rooms.FindAsync(new object[] { request.EstateId }, cancellationToken);

            if (room is null || request.UserId != room.UserId) {
                throw new NotFoundException(nameof(Room), request.EstateId);
            }

            _dbContext.Rooms.Remove(room);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

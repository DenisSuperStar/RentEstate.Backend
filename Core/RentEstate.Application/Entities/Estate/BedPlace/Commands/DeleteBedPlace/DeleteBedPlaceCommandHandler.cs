using MediatR;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.BedPlace.Commands.DeleteBedPlace
{
    public class DeleteBedPlaceCommandHandler : IRequestHandler<DeleteBedPlaceCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public DeleteBedPlaceCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteBedPlaceCommand request, CancellationToken cancellationToken)
        {
            var bedPlace = await _dbContext.BedPlaces.FindAsync(new object[] { request.EstateId }, cancellationToken);

            if (bedPlace is null || request.UserId != bedPlace.UserId) {
                throw new NotFoundException(nameof(BedPlace), request.EstateId);
            }

            _dbContext.BedPlaces.Remove(bedPlace);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

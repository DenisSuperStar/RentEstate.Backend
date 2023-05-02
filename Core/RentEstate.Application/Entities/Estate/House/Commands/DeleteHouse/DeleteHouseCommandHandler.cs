using MediatR;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.House.Commands.DeleteHouse
{
    public class DeleteHouseCommandHandler : IRequestHandler<DeleteHouseCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public DeleteHouseCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteHouseCommand request, CancellationToken cancellationToken)
        {
            var house = await _dbContext.Houses.FindAsync(new object[] { request.EstateId }, cancellationToken);

            if (house is null || request.UserId != house.UserId) {
                throw new NotFoundException(nameof(House), request.EstateId);
            }

            _dbContext.Houses.Remove(house);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

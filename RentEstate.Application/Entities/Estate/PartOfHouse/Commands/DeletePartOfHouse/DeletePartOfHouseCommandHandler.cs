
using MediatR;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.PartOfHouse.Commands.DeletePartOfHouse
{
    public class DeletePartOfHouseCommandHandler : IRequestHandler<DeletePartOfHouseCommand,Unit>
    {

        private readonly IEstateDbContext _dbContext;

        public DeletePartOfHouseCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeletePartOfHouseCommand request, CancellationToken cancellationToken)
        {
            var partOfHouse = await _dbContext.PartOfHouses.FindAsync(new object[] { request.EstateId }, cancellationToken);

            if (partOfHouse is null || request.UserId != partOfHouse.UserId) {
                throw new NotFoundException(nameof(PartOfHouse), request.EstateId);
            }
            _dbContext.PartOfHouses.Remove(partOfHouse);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

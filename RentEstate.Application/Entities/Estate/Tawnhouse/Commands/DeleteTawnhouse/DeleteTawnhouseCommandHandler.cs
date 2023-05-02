using MediatR;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Tawnhouse.Commands.DeleteTawnhouse
{
    public class DeleteTawnhouseCommandHandler : IRequestHandler<DeleteTawnhouseCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public DeleteTawnhouseCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteTawnhouseCommand request, CancellationToken cancellationToken)
        {
            var tawnHouse = await _dbContext.Tawnhouses.FindAsync(new object[] { request.EstateId }, cancellationToken);

            if (tawnHouse is null || request.UserId != tawnHouse.UserId) {
                throw new NotFoundException(nameof(tawnHouse), request.EstateId);
            }

            _dbContext.Tawnhouses.Remove(tawnHouse);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

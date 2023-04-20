using MediatR;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Flat.Commands.DeleteFlat
{
    public class DeleteFlatCommandHandler : IRequestHandler<DeleteFlatCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public DeleteFlatCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteFlatCommand request, CancellationToken cancellationToken)
        {
            var flat = await _dbContext.Flats.FindAsync(new object[] { request.EstateId }, cancellationToken);

            if (flat is null || request.UserId != flat.UserId) {
                throw new NotFoundException(nameof(Flat), request.EstateId);
            }

            _dbContext.Flats.Remove(flat);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

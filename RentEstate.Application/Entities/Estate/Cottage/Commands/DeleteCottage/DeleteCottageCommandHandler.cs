using MediatR;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Cottage.Commands.DeleteCottage
{
    public class DeleteCottageCommandHandler : IRequestHandler<DeleteCottageCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public DeleteCottageCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteCottageCommand request, CancellationToken cancellationToken)
        {
            var cottage = await _dbContext.Cottages.FindAsync(new object[] { request.EstateId }, cancellationToken);

            if (cottage is null || request.UserId != cottage.UserId) {
                throw new NotFoundException(nameof(Cottage), request.EstateId);
            }

            _dbContext.Cottages.Remove(cottage);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

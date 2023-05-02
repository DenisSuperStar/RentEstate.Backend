using MediatR;

namespace RentEstate.Application.Entities.Estate.Cottage.Commands.DeleteCottage
{
    public class DeleteCottageCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid EstateId { get; set; }
    }
}

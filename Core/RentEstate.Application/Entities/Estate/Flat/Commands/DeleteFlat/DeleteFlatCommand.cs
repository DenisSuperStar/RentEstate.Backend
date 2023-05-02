using MediatR;

namespace RentEstate.Application.Entities.Estate.Flat.Commands.DeleteFlat
{
    public class DeleteFlatCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid EstateId { get; set; }
    }
}

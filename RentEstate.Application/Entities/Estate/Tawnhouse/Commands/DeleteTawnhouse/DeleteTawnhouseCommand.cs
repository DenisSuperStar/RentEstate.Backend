using MediatR;

namespace RentEstate.Application.Entities.Estate.Tawnhouse.Commands.DeleteTawnhouse
{
    public class DeleteTawnhouseCommand : IRequest<Unit> 
    {
        public Guid UserId { get; set; }
        public Guid EstateId { get; set; }
    }
}

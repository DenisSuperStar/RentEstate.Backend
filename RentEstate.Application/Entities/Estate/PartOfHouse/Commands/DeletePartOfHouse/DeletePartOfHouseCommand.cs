using MediatR;

namespace RentEstate.Application.Entities.Estate.PartOfHouse.Commands.DeletePartOfHouse
{
    public class DeletePartOfHouseCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid EstateId { get; set; }
    }
}

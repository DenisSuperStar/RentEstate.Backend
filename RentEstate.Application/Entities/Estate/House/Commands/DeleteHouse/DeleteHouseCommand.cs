using MediatR;

namespace RentEstate.Application.Entities.Estate.House.Commands.DeleteHouse
{
    public class DeleteHouseCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid EstateId { get; set; }

    }
}

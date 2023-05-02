using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.PartOfHouse.Queries
{
    public class PartOfHouseListQueryHandler : IRequestHandler<PartOfHouseListQuery, PartOfHouseListVm>
    {
        private readonly IEstateDbContext _dbContext;
        private readonly IMapper _mapper;

        public PartOfHouseListQueryHandler(IEstateDbContext dbContext, IMapper mapper) {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<PartOfHouseListVm> Handle(PartOfHouseListQuery request, CancellationToken cancellationToken)
        {
            var partOfHouseQuery = await _dbContext.PartOfHouses
                .Where(search => search.UserId == request.UserId)
                .ProjectTo<PartOfHouseListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new PartOfHouseListVm { PartOfHouseList = partOfHouseQuery };
        }
    }
}

using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.House.Queries
{
    public class HouseListQueryHandler : IRequestHandler<HouseListQuery, HouseListVm>
    {
        private readonly IEstateDbContext _dbContext;
        private readonly IMapper _mapper;

        public HouseListQueryHandler(IEstateDbContext dbContext, IMapper mapper) {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<HouseListVm> Handle(HouseListQuery request, CancellationToken cancellationToken)
        {
            var houseQuery = await _dbContext.Houses
                .Where(search => search.UserId == request.UserId)
                .ProjectTo<HouseListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new HouseListVm { HouseList = houseQuery };
        }
    }
}

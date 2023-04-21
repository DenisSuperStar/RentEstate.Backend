
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Cottage.Queries.GetCottageList
{
    public class CottageListQueryHandler : IRequestHandler<CottageListQuery, CottageListVm>
    {
        private readonly IEstateDbContext _dbContext;
        private readonly IMapper _mapper;

        public CottageListQueryHandler(IEstateDbContext dbContext, IMapper mapper) {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<CottageListVm> Handle(CottageListQuery request, CancellationToken cancellationToken)
        {
            var cottageQuery = await _dbContext.Cottages
                .Where(search => search.UserId == request.UserId)
                .ProjectTo<CottageListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new CottageListVm { CottageList = cottageQuery };
        }
    }
}

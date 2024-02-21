using AutoMapper;
using Internship.Business.ProductXSuppliers.Commands.Create;
using Internship.Controllers.ProductXSuppliers.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductXSuppliers.Queries.GetAll
{
    public class GetAllPsHandler: IRequestHandler<GetAllPsQuery, List<GetAllPsResult>>
    {
        public readonly EcomDbContext _dbContext;
        public readonly IMapper _mapper;

        public GetAllPsHandler(IMapper mapper, EcomDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetAllPsResult>> Handle(GetAllPsQuery request, CancellationToken cancellationToken)
        {
            var psList = await _dbContext.ProductXSuppliers.ToListAsync();
            var psListResult = _mapper.Map<List<GetAllPsResult>>(psList);
            return psListResult;
        } 
 
    }
}

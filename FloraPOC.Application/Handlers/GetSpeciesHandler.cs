using FloraPOC.Application.Contract.Service;
using FloraPOC.Application.Query;
using FloraPOC.Domain.Model.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraPOC.Application.Handlers
{
    public class GetSpeciesHandler : IRequestHandler<GetSpeciesQuery, SpeciesOutputDto>
    {
        private readonly ISpecieService _specieService;

        public GetSpeciesHandler(ISpecieService specieService)
        {
            _specieService = specieService;
        }

        public async Task<SpeciesOutputDto> Handle(GetSpeciesQuery query, CancellationToken cancellationToken)
        {
            return await _specieService.GetAll(query.searchDto);
        }
    }
}

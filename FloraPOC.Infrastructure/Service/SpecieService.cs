using Azure.Core;
using FloraPOC.Application.Contract.Repository;
using FloraPOC.Application.Contract.Service;
using FloraPOC.Domain.Model.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraPOC.Infrastructure.Service
{
    public class SpecieService : ISpecieService
    {
        private readonly ISpecieRepository _repository;

        public SpecieService(ISpecieRepository repository)
        {
            _repository = repository;
        }

        public async Task<SpeciesOutputDto> GetAll(SearchRequestDto input)
        {
            var query = _repository.GetAll(input); // will return IQueryable type

            var pageNumber = input.Page;
            var pageSize = input.ItemsRequested;
            var paginatedQuery = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            var count = query.Count();

            var list = await paginatedQuery.Select(x => new SpecieDTO(x)).ToListAsync(); // materialization only here

            return new SpeciesOutputDto() { 
                Category = input.Category,
                Count = count,
                ItemsRequested = pageSize,
                Species = list
            };
        }
    }
}

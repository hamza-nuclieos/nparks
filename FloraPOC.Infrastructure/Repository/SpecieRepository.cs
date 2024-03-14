using FloraPOC.Application.Contract.Repository;
using FloraPOC.Domain;
using FloraPOC.Domain.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FloraPOC.Infrastructure.Repository
{
    public class SpecieRepository : ISpecieRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SpecieRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<SpecieEntity> GetAll(SearchRequestDto input)
        {
            IQueryable<SpecieEntity> species = _dbContext.Species.AsQueryable();
            var tagsArray = input.Tags.Split(',');

            species.Where(e =>
            (string.IsNullOrWhiteSpace(input.Category) || e.Category == input.Category) &&
            (string.IsNullOrWhiteSpace(input.ProductTerm) || e.Name.Contains(input.ProductTerm) || e.Description.Contains(input.ProductTerm)) &&
                (string.IsNullOrWhiteSpace(input.Tags) || tagsArray.Any(tag => e.Tag.Contains(tag.Trim())))
            );
            return species;
        }
    }
}

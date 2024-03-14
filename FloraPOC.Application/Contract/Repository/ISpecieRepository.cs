using FloraPOC.Domain.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraPOC.Application.Contract.Repository
{
    public interface ISpecieRepository
    {
        public IQueryable<SpecieEntity> GetAll(SearchRequestDto input);
    }
}

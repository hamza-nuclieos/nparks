using FloraPOC.Domain.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraPOC.Application.Contract.Service
{
    public interface ISpecieService
    {
        Task<SpeciesOutputDto> GetAll(SearchRequestDto input);
    }
}

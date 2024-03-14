using FloraPOC.Domain.Model.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraPOC.Application.Query
{
    public class GetSpeciesQuery : IRequest<SpeciesOutputDto>
    {
        public SearchRequestDto searchDto { get; set; }

        public GetSpeciesQuery(SearchRequestDto input)
        {
            searchDto = input;

            //searchDto = new SearchRequestDto()
            //{
            //    Sort = input.Sort,
            //    Category = input.Category,
            //    ImageTag = input.ImageTag,
            //    ItemsRequested = input.ItemsRequested,
            //    Page = input.Page,
            //    ProductTerm = input.ProductTerm,
            //    Tags = input.Tags,
            //};
        }
    }
}

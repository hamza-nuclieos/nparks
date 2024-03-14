using FloraPOC.Domain.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraPOC.Domain.Model.DTO
{
    public class SpecieDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CommonName { get; set; } = string.Empty;
        public string Tag { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;

        public SpecieDTO()
        { }

        public SpecieDTO(SpecieEntity entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            CommonName = entity.CommonName;
            Tag = entity.Tag;
            Image = entity.Image;
            Description = entity.Description;
            Link = entity.Link;
        }
    }
}

using AutoMapper;
using Mantenimiento.EntityModels;
using Mantenimiento.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CrudBase, CrudBaseDTO>().ReverseMap();
        }
    }
}

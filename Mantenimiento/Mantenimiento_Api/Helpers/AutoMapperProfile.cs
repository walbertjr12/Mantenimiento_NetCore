using AutoMapper;
using Mantenimiento_Api.EntityModels;
using Mantenimiento_Api.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento_Api.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CrudBase, CrudBaseDTO>().ReverseMap();
        }
    }
}

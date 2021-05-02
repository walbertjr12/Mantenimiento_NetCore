using AutoMapper;
using Mantenimiento_Api.EntityModels;
using Mantenimiento_Api.Models;
using Mantenimiento_Api.Models.DTO;
using Mantenimiento_Api.Repositories;
using Mantenimiento_Api.Repositories.RepositoryCRUD;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MantenimientoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MantenimientoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("getcrudbases")]
        public List<CrudBaseDTO> GetCrudBases()
        {
            return _mapper.Map<List<CrudBaseDTO>>(_unitOfWork.CrudBase.GetCrudBases());
            //return Json(_unitOfWork.CrudBase.GetCrudBasesDTO());
            //return Json(_unitOfWork.CrudBase.GetAll());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("getcrudbase")]
        public async Task<CrudBaseDTO> GetCrudBase(int id)
        {
            return _mapper.Map<CrudBaseDTO>(await _unitOfWork.CrudBase.GetCrudBase(id));
            //return Json(_unitOfWork.CrudBase.GetCrudBasesDTO());
            //return Json(_unitOfWork.CrudBase.GetAll());
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("guardar")]
        public async Task<ResponseModel> Guardar(CrudBaseDTO model)
        {
            if (model.Id != 0)
            {
                return await _unitOfWork.CrudBase.Actualizar(model);
            }
            return await _unitOfWork.CrudBase.Guardar(_mapper.Map<CrudBase>(model));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("eliminar")]
        public async Task<ResponseModel> Eliminar(int id)
        {
            return await _unitOfWork.CrudBase.Eliminar(id);
        }
    }
}

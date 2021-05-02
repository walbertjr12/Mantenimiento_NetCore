using AutoMapper;
using Mantenimiento.EntityModels;
using Mantenimiento.Models.DTO;
using Mantenimiento.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento.Areas.Matenimiento.Controllers
{
    [Area("Mantenimiento")]
    public class MantenimientoController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MantenimientoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #region Vistas
        public IActionResult MantenimientoIndex()
        {
            return View();
        }

        public async Task<PartialViewResult> CrudBaseForm(int? id)
        {
            if (id != 0 && id != null)
            {
                var modelindb = _mapper.Map<CrudBaseDTO>(await _unitOfWork.CrudBase.GetCrudBase(id.Value));
                //var modelindb = _unitOfWork.CrudBase.GetCrudBaseDTO(id.Value);
                //var modelindb = _unitOfWork.CrudBase.GetFirstOrDefault(x=>x.Id == id.Value);

                return PartialView("_CrudBaseForm", modelindb);
            }

            return PartialView("_CrudBaseForm", new CrudBaseDTO());
        }

        public async Task<PartialViewResult> DetalleCrudBase(int id)
        {

            var modelindb = _mapper.Map<CrudBaseDTO>(await _unitOfWork.CrudBase.GetCrudBase(id));
            //var modelindb = _unitOfWork.CrudBase.GetCrudBaseDTO(id);
            //var modelindb = _unitOfWork.CrudBase.GetFirstOrDefault(x=>x.Id == id);

            return PartialView("_DetalleCrudBase", modelindb);
        }
        #endregion

        #region Datos
        public JsonResult GetCrudBases()
        {
            return Json(new { data = _unitOfWork.CrudBase.GetCrudBases() });
            //return Json(_unitOfWork.CrudBase.GetCrudBasesDTO());
            //return Json(_unitOfWork.CrudBase.GetAll());
        }

        public async Task<JsonResult> Guardar(CrudBaseDTO model)
        {
            if (model.Id != 0)
            {
                return Json(await _unitOfWork.CrudBase.Actualizar(model));
            }
            return Json(await _unitOfWork.CrudBase.Guardar(_mapper.Map<CrudBase>(model)));
        }

        public async Task<JsonResult> Eliminar(int id)
        {
            return Json(await _unitOfWork.CrudBase.Eliminar(id));
        }

        #endregion
    }
}

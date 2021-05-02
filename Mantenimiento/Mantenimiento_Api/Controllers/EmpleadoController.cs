using AutoMapper.Configuration;
using Mantenimiento_Api.EntityModels;
using Mantenimiento_Api.Models;
using Mantenimiento_Api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        public EmpleadoController(IUnitOfWork unitOfWork, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("getempleados")]
        public List<Empleado> GetEmpleados()
        {
            return _unitOfWork.Empleado.GetAll().ToList();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("guardar")]
        public ResponseModel Guardar(Empleado empleado)
        {
            //ResponseModel response = new ResponseModel();
            //try
            //{
            //    _unitOfWork.Empleado.Add(empleado);
            //    _unitOfWork.Save();

            //    response.result = true;
            //    response.message = "El empleado ha sido almacenado correctamente.";
            //}
            //catch (Exception)
            //{
            //    response.result = false;
            //    response.message = "El empleado no ha sido almacenado correctamente.";
            //}
            //return response;

            return _unitOfWork.Empleado.Guardar(empleado);

        }

        [AllowAnonymous]
        [HttpPut]
        [Route("actualizar")]
        public ResponseModel Actualizar(Empleado empleado)
        {
            //ResponseModel response = new ResponseModel();
            //try
            //{
            //    _unitOfWork.Empleado.Add(empleado);
            //    _unitOfWork.Save();

            //    response.result = true;
            //    response.message = "El empleado ha sido almacenado correctamente.";
            //}
            //catch (Exception)
            //{
            //    response.result = false;
            //    response.message = "El empleado no ha sido almacenado correctamente.";
            //}
            //return response;

            return _unitOfWork.Empleado.Actualizar(empleado);

        }
    }
}

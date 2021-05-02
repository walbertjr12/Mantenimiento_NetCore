using Mantenimiento_Api.EntityModels;
using Mantenimiento_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mantenimiento_Api.Repositories.RepositoryCRUD
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        private readonly MantenimientoContext _db;
        public EmpleadoRepository(MantenimientoContext db) : base(db)
        {
            _db = db;
        }

        public ResponseModel Actualizar(Empleado empleado)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                _db.Empleados.Update(empleado);
                _db.SaveChanges();

                response.result = true;
                response.message = "El empleado ha sido actualizada correctamente.";
            }
            catch (Exception)
            {
                response.result = false;
                response.message = "El empleado no ha sido actualizada correctamente.";
            }
            return response;
        }

        public ResponseModel Guardar(Empleado empleado)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                _db.Empleados.Add(empleado);
                _db.SaveChanges();

                response.result = true;
                response.message = "El empleado ha sido almacenado correctamente.";
            }
            catch (Exception)
            {
                response.result = false;
                response.message = "El empleado no ha sido almacenado correctamente.";
            }
            return response;
        }
    }
}

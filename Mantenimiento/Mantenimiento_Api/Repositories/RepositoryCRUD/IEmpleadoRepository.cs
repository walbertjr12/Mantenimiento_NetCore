using Mantenimiento_Api.EntityModels;
using Mantenimiento_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento_Api.Repositories.RepositoryCRUD
{
    public interface IEmpleadoRepository : IRepository<Empleado>
    {
        ResponseModel Guardar(Empleado empleado);
        ResponseModel Actualizar(Empleado empleado);
    }
}

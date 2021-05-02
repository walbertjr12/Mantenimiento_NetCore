using Mantenimiento.EntityModels;
using Mantenimiento.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento.Repositories.RepositoryCRUD
{
    public interface IEmpleadoRepository : IRepository<Empleado>
    {
        List<EmpleadoDTO> GetEmpleados();
    }
}

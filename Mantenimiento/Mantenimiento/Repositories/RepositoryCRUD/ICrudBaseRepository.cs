using Mantenimiento.EntityModels;
using Mantenimiento.Models;
using Mantenimiento.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento.Repositories.RepositoryCRUD
{
    public interface ICrudBaseRepository : IRepository<CrudBase>
    {
        List<CrudBaseDTO> GetCrudBasesDTO();
        CrudBaseDTO GetCrudBaseDTO(int id);
        List<CrudBase> GetCrudBases();
        Task<CrudBase> GetCrudBase(int id);
        Task<ResponseModel> Guardar(CrudBase model);
        Task<ResponseModel> Actualizar(CrudBaseDTO model);
        Task<ResponseModel> Eliminar(int id);
    }
}

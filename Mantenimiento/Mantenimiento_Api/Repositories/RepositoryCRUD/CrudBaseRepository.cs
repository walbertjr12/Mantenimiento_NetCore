using Mantenimiento_Api.EntityModels;
using Mantenimiento_Api.Models;
using Mantenimiento_Api.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento_Api.Repositories.RepositoryCRUD
{
    public class CrudBaseRepository : Repository<CrudBase>, ICrudBaseRepository
    {
        private readonly MantenimientoContext _db;
        public CrudBaseRepository(MantenimientoContext db) : base(db)
        {
            _db = db;
        }

        public async Task<ResponseModel> Actualizar(CrudBaseDTO model)
        {
            ResponseModel response = new ResponseModel() { result = true };
            try
            {
                var modelinDb = await _db.CrudBases.FindAsync(model.Id);

                modelinDb.Descripcioncorta = model.Descripcioncorta;
                modelinDb.Descripcionlarga = model.Descripcionlarga;
                modelinDb.Estado = model.Estado;
                modelinDb.Fechamodificacion = DateTime.Now;
                modelinDb.Usuariomodificacion = model.Usuariocreacion;

                await _db.SaveChangesAsync();

                response.message = "Registro actualizado correctamente.";

            }
            catch (Exception e)
            {
                response.result = false;
                response.message = e.Message;
            }

            return response;
        }

        public async Task<ResponseModel> Eliminar(int id)
        {
            ResponseModel response = new ResponseModel() { result = true };
            try
            {
                var modelinDb = await _db.CrudBases.FindAsync(id);

                modelinDb.Estado = false;
                await _db.SaveChangesAsync();

                response.message = "Registro eliminado correctamente.";

            }
            catch (Exception e)
            {
                response.result = false;
                response.message = e.Message;
            }
            return response;
        }

        public async Task<CrudBase> GetCrudBase(int id)
        {
            try
            {
                return await _db.CrudBases.FindAsync(id);
            }
            catch (Exception)
            {
                return new CrudBase();
            }
        }

        public CrudBaseDTO GetCrudBaseDTO(int id)
        {
            try
            {
                return (from cb in _db.CrudBases
                              where cb.Id == id
                              select new CrudBaseDTO
                              {
                                  Id = cb.Id,
                                  Codigo = cb.Codigo,
                                  Descripcioncorta = cb.Descripcioncorta,
                                  Descripcionlarga = cb.Descripcionlarga,
                                  Estado = cb.Estado,
                                  Fechacreacion = cb.Fechacreacion,
                                  Fechamodificacion = cb.Fechamodificacion,
                                  Usuariocreacion = cb.Usuariocreacion,
                                  Usuariomodificacion = cb.Usuariomodificacion
                              }).FirstOrDefault();
            }
            catch (Exception)
            {
                return new CrudBaseDTO();
            }
        }

        public List<CrudBase> GetCrudBases()
        {
            try
            {
                return _db.CrudBases.ToList();
            }
            catch (Exception)
            {
                return new List<CrudBase>();
            }
        }

        public List<CrudBaseDTO> GetCrudBasesDTO()
        {
            try
            {
                return (from cb in _db.CrudBases
                        select new CrudBaseDTO
                        {
                            Id = cb.Id,
                            Codigo = cb.Codigo,
                            Descripcioncorta = cb.Descripcioncorta,
                            Descripcionlarga = cb.Descripcionlarga,
                            Estado = cb.Estado,
                            Fechacreacion = cb.Fechacreacion,
                            Fechamodificacion = cb.Fechamodificacion,
                            Usuariocreacion = cb.Usuariocreacion,
                            Usuariomodificacion = cb.Usuariomodificacion
                        }).ToList();
            }
            catch (Exception)
            {
                return new List<CrudBaseDTO>();
            }
        }

        public async Task<ResponseModel> Guardar(CrudBase model)
        {
            ResponseModel response = new ResponseModel() { result = true };
            try
            {
                model.Estado = true;
                model.Fechacreacion = DateTime.Now;

                await _db.CrudBases.AddAsync(model);

                await _db.SaveChangesAsync();

                response.message = "Registro almacenado correctamente.";
            }
            catch (Exception e)
            {
                response.result = false;
                response.message = e.Message;
            }
            return response;
        }
    }
}

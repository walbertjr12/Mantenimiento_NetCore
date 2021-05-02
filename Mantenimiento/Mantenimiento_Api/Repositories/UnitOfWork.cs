using Mantenimiento_Api.EntityModels;
using Mantenimiento_Api.Repositories.RepositoryCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento_Api.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MantenimientoContext _db;
        public UnitOfWork(MantenimientoContext db)
        {
            _db = db;
            CrudBase = new CrudBaseRepository(_db);
            Empleado = new EmpleadoRepository(_db);
        }

        public ICrudBaseRepository CrudBase { get; private set; }
        public IEmpleadoRepository Empleado { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

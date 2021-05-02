using Mantenimiento.EntityModels;
using Mantenimiento.Repositories.RepositoryCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MantenimientoContext _db;
        public UnitOfWork(MantenimientoContext db)
        {
            _db = db;
            CrudBase = new CrudBaseRepository(_db);
        }

        public ICrudBaseRepository CrudBase { get; private set; }

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

using Mantenimiento.Repositories.RepositoryCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICrudBaseRepository CrudBase { get; }
        void Save();
    }
}

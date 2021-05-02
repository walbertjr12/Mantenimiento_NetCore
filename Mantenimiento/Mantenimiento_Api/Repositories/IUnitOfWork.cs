using Mantenimiento_Api.Repositories.RepositoryCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantenimiento_Api.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICrudBaseRepository CrudBase { get; }
        void Save();
    }
}

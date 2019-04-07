using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationPostgresTest.Repository
{
    public interface IBaseRepository<T>
    {
        Task Add(T entity);
        Task Add(IEnumerable<T> entities);
        Task<IEnumerable<T>> GetAll();
        Task Commit();
    }
}

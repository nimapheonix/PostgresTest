using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationPostgresTest.Data;
using WebApplicationPostgresTest.Models;

namespace WebApplicationPostgresTest.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T :class,IBaseEntity
    {
        protected DatabaseContext Context;
        private object databaseContext;
        private object db;

        public BaseRepository(DatabaseContext databaseContext)
        {
            this.Context = databaseContext;
        }
        public BaseRepository(object databaseContext, object db)
        {
            this.databaseContext = databaseContext;
            this.db = db;
        }
        public virtual async Task Add(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
        }
        public virtual async Task Add(IEnumerable<T> entities)
        {
            await Context.Set<T>().AddRangeAsync(entities);
        }
        public async virtual Task<IEnumerable<T>> GetAll()
        {
            var set = Context.Set<T>();
            return await set.ToListAsync();
        }

        public virtual async Task Commit()
        {
            await Context.SaveChangesAsync();
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}

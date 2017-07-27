using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal FrameworkDBContext context;
        internal DbSet<TEntity> dbSet;
        public GenericRepository(FrameworkDBContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        public IEnumerable<TEntity> SelectList()
        {
           return  dbSet.ToList();
        }

        public TEntity SelectByID(object id)
        {
            return dbSet.Find(id);
        }

        public void Insert(TEntity entity)
        {
             dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(object id)
        {
            
           TEntity entity=  dbSet.Find(id);
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void LogicDelete(object id)
        {
            TEntity entity = dbSet.Find(id);
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing) {
                    context.Dispose();
                }
                this.disposed = true;
            }
            else {

            }

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

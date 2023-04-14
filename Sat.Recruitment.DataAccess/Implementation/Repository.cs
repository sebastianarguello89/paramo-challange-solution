using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.DataAccess
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private SatRecruitmentContext context;

        public Repository(SatRecruitmentContext context)
        {
            this.context = context;
        }
        protected DbSet<T> DbSet
        {
            get
            {
                return context.Set<T>();
            }
        }

        public virtual async Task<IList<T>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<T> InsertAsync(T entity)
        {
            DbSet.Add(entity);
            await SaveAsync();
            return entity;
        }

        public virtual async Task SaveAsync()
        {
           await context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

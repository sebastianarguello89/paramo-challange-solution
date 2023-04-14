using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.DataAccess
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task<IList<T>> GetAllAsync();
        Task<T> InsertAsync(T entity);
    }
}

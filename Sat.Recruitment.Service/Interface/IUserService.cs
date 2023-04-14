using Sat.Recruitment.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Service
{
    public interface IUserService : IService
    {
        Task<IList<User>> GetAllAsync();
        Task<long> InsertAsync(User entity);
    }
}

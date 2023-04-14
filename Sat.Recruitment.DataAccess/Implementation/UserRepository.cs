using Sat.Recruitment.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.DataAccess
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SatRecruitmentContext context) : base(context)
        {

        }
    }
}

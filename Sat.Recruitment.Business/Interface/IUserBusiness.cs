using Sat.Recruitment.Model;
using System.Threading.Tasks;

namespace Sat.Recruitment.Business
{
    public interface IUserBusiness : IBusiness
    {
        Task<long> CreateAsync(UserInputDTO entity);
    }
}

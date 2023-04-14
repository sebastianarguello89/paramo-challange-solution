using Sat.Recruitment.Model;
using System.Threading.Tasks;

namespace Sat.Recruitment.Business
{
    public interface IUserValidatorBusiness : IBusiness
    {
        Task Duplicate(UserInputDTO entity);
    }
}

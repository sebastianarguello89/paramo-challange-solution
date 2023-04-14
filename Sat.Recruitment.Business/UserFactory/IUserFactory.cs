using Sat.Recruitment.Model;

namespace Sat.Recruitment.Business.UserFactory
{
    public interface IUserFactory : IBusiness
    {
        User CreateUser(UserInputDTO userInput);
    }
}

using Sat.Recruitment.Model;

namespace Sat.Recruitment.Business.UserFactory
{
    public interface IUserProduct
    {
        User Create(UserInputDTO userInput);
    }
}

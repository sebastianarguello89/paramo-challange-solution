using AutoMapper;
using Sat.Recruitment.Model;

namespace Sat.Recruitment.Business.UserFactory
{
    public class SuperUserProduct : IUserProduct
    {
        public User Create(UserInputDTO userInput)
        {
            return Mapper.Map<SuperUser>(userInput);
        }
    }
}

using AutoMapper;
using Sat.Recruitment.Model;

namespace Sat.Recruitment.Business.UserFactory
{
    public class NormalUserProduct : IUserProduct
    {
        public User Create(UserInputDTO userInput)
        {
            return Mapper.Map<NormalUser>(userInput);
        }
    }
}

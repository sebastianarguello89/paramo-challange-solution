using AutoMapper;
using Sat.Recruitment.Model;

namespace Sat.Recruitment.Business.UserFactory
{
    public  class PremiumUserProduct : IUserProduct
    {
        public  User Create(UserInputDTO userInput)
        {
            return Mapper.Map<PremiumUser>(userInput);
        }
    }
}

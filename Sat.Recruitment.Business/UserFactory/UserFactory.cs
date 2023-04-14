using Sat.Recruitment.Model;
using System;

namespace Sat.Recruitment.Business.UserFactory
{
    public class UserFactory : IUserFactory
    {
        public User CreateUser(UserInputDTO entity)
        {
            User user;

            switch (entity.UserType.ToLowerInvariant())
            {
                case "normal":
                    var normalUserProduct = new NormalUserProduct();
                    user = normalUserProduct.Create(entity);
                    break;
                case "premium":
                    var premiumUserProduct = new PremiumUserProduct();
                    user = premiumUserProduct.Create(entity);
                    break;
                case "superuser":
                    var superUserProduct = new SuperUserProduct();
                    user = superUserProduct.Create(entity);
                    break;
                default:
                    throw new Exception("UserType doesn't exists.");
            }

            return user;
        }

        #region Dispose
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}

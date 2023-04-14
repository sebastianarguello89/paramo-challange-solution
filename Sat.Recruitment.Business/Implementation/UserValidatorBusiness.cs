using Sat.Recruitment.Model;
using Sat.Recruitment.Service;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Sat.Recruitment.Business
{
    public class UserValidatorBusiness : IUserValidatorBusiness
    {
        #region Member

        private IUserService _userService;

        #endregion

        #region Constructor

        public UserValidatorBusiness(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        #endregion

        #region Method
        public async Task Duplicate(UserInputDTO entity)
        {
            var user = (await _userService.GetAllAsync()).FirstOrDefault(
                                              x => x.Email == entity.Email ||
                                              x.Phone == entity.Phone ||
                                              x.Name == entity.Name && x.Address == entity.Address);
            if (user != null)
                throw new Exception("User is duplicated");
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}

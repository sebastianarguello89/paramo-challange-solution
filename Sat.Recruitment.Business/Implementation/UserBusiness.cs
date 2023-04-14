using Sat.Recruitment.Business.UserFactory;
using Sat.Recruitment.Model;
using Sat.Recruitment.Service;
using System;
using System.Threading.Tasks;

namespace Sat.Recruitment.Business
{
    public class UserBusiness : IUserBusiness
    {
        #region Member

        private IUserService _userService;
        private IUserFactory _userFactory;
        private IEmailBusiness _email;
        private IUserValidatorBusiness _userValidatorBusiness;
        #endregion

        #region Constructor

        public UserBusiness(IUserService userService,
                            IUserFactory userFactory,
                            IEmailBusiness email,
                            IUserValidatorBusiness userValidatorBusiness)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _userFactory = userFactory ?? throw new ArgumentNullException(nameof(userFactory));
            _email = email ?? throw new ArgumentNullException(nameof(email));
            _userValidatorBusiness = userValidatorBusiness ?? throw new ArgumentNullException(nameof(userValidatorBusiness));
        }

        #endregion

        #region Methods
        public async Task<long> CreateAsync(UserInputDTO entity)
        {
            try
            {
                entity.Email = _email.Normalize(entity.Email);

                await _userValidatorBusiness.Duplicate(entity);

                var user = _userFactory.CreateUser(entity);

                return await _userService.InsertAsync(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_userService != null)
            {
                _userService.Dispose();
                _userService = null;
            }
            if (_userFactory != null)
            {
                _userFactory.Dispose();
                _userFactory = null;
            }
            if (_email != null)
            {
                _email.Dispose();
                _email = null;
            }
            if (_userValidatorBusiness != null)
            {
                _userValidatorBusiness.Dispose();
                _userValidatorBusiness = null;
            }
        }
        #endregion
    }
}

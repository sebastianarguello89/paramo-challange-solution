using Sat.Recruitment.DataAccess;
using Sat.Recruitment.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sat.Recruitment.Service
{
    public class UserService : IUserService
    {
        #region Member

        private IUserRepository _userRepository;

        #endregion

        #region Constructor

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        #endregion

        #region Methods


        public async Task<IList<User>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<long> InsertAsync(User entity)
        {
            var user = await _userRepository.InsertAsync(entity);
            return user.UserId;
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
            if (_userRepository != null)
            {
                _userRepository.Dispose();
                _userRepository = null;
            }
        }
        #endregion
    }
}

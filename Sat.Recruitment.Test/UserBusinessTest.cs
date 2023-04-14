using Moq;
using Sat.Recruitment.Business;
using Sat.Recruitment.Business.UserFactory;
using Sat.Recruitment.Model;
using Sat.Recruitment.Service;
using System.Collections.Generic;
using Xunit;

namespace Sat.Recruitment.Test
{
    [CollectionDefinition("Tests", DisableParallelization = true)]
    public class UserBusinessTest
    {
        [Fact]
        public async void CreateSuccessAsync()
        {
            #region Arrenge
            UserInputDTO request = new UserInputDTO
            {
                Name = "Mike",
                Email = "mike@gmail.com",
                Address = "Av. Juan G",
                Phone = "+349 1122354215",
                UserType = "Normal",
                Money = 124
            };

            User user = new NormalUser
            {
                Name = "Mike",
                Email = "mike@gmail.com",
                Address = "Av. Juan G",
                Phone = "+349 1122354215",
                UserId = 1,
                Money = 124
            };

            Mock<IEmailBusiness> emailBusiness = new Mock<IEmailBusiness>();
            emailBusiness.Setup(e => e.Normalize("mike@gmail.com")).Returns("mike@gmail.com");

            Mock<IUserValidatorBusiness> userValidatorBusiness = new Mock<IUserValidatorBusiness>();
            userValidatorBusiness.Setup(v => v.Duplicate(request));

            Mock<IUserFactory> userFactory = new Mock<IUserFactory>();
            userFactory.Setup(f => f.CreateUser(request)).Returns(user);

            Mock<IUserService> userService = new Mock<IUserService>();
            userService.Setup(x => x.GetAllAsync()).ReturnsAsync(new List<User>());
            userService.Setup(x => x.InsertAsync(user)).ReturnsAsync(1);

            UserBusiness business = new UserBusiness(userService.Object, userFactory.Object, emailBusiness.Object, userValidatorBusiness.Object);
            #endregion

            #region Act
            var response = await business.CreateAsync(request);
            #endregion

            #region Assert
            Assert.True(response > 0);
            #endregion
        }

        [Fact]
        public async void CreateFailedAsync()
        {
            #region Arrenge
            UserInputDTO request = new UserInputDTO
            {
                Name = "Agustina",
                Email = "Agustina@gmail.com",
                Address = "Av. Juan G",
                Phone = "+349 1122354215",
                UserType = "Normal",
                Money = 124
            };

            User user = new NormalUser
            {
                Name = "Mike",
                Email = "mike@gmail.com",
                Address = "Av. Juan G",
                Phone = "+349 1122354215",
                UserId = 1,
                Money = 124
            };

            List<User> usersList = new List<User>();
            usersList.Add(user);

            Mock<IEmailBusiness> emailBusiness = new Mock<IEmailBusiness>();
            emailBusiness.Setup(e => e.Normalize("Agustina@gmail.com")).Returns("Agustina@gmail.com");

            Mock<IUserValidatorBusiness> userValidatorBusiness = new Mock<IUserValidatorBusiness>();
            userValidatorBusiness.Setup(v => v.Duplicate(request));

            Mock<IUserFactory> userFactory = new Mock<IUserFactory>();
            userFactory.Setup(f => f.CreateUser(request)).Returns(user);

            Mock<IUserService> userService = new Mock<IUserService>();
            userService.Setup(x => x.GetAllAsync()).ReturnsAsync(usersList);
            userService.Setup(x => x.InsertAsync(user)).ReturnsAsync(0);

            UserBusiness business = new UserBusiness(userService.Object, userFactory.Object, emailBusiness.Object, userValidatorBusiness.Object);
            #endregion

            #region Act
            var response = await business.CreateAsync(request);
            #endregion

            #region Assert
            Assert.True(response > 0);
            #endregion
        }
    }
}

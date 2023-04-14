using Microsoft.Extensions.DependencyInjection;
using Sat.Recruitment.Business;
using Sat.Recruitment.Business.UserFactory;
using Sat.Recruitment.DataAccess;
using Sat.Recruitment.Service;

namespace Sat.Recruitment.Api.DI
{
    public static class ServiceCollectionExtension
    {
        public static void DependencyContainer(this IServiceCollection services)
        {
            //Business
            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<IUserFactory, UserFactory>();
            services.AddScoped<IEmailBusiness, EmailBusiness>();
            services.AddScoped<IUserValidatorBusiness, UserValidatorBusiness>();

            //Service
            services.AddScoped<IUserService, UserService>();

            //Repository
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}

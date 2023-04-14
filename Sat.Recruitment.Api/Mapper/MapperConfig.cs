using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Microsoft.AspNetCore.Builder;
using Sat.Recruitment.Model;

namespace Sat.Recruitment.Api.Mapper
{
    public static class MapperConfig
    {
        public static void RegisterMappings(IApplicationBuilder app)
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddCollectionMappers();
                cfg.AddProfile(new UserProfile());
            });
        }
    }

    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserInputDTO, User>().IncludeAllDerived();
            CreateMap<UserInputDTO, NormalUser>();
            CreateMap<UserInputDTO, SuperUser>();
            CreateMap<UserInputDTO, PremiumUser>();
                                                 
        }
    }
}

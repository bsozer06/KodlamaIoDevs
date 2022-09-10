using AutoMapper;
using Core.Security.JWT;
using KodlamaIoDevs.Application.Features.UserApp.Commands.RegisterUserApp;
using KodlamaIoDevs.Application.Features.UserApp.Dtos;

namespace KodlamaIoDevs.Application.Features.UserApp.Profiles
{
    public class MappingRules: Profile
    {
        public MappingRules()
        {
            CreateMap<Domain.Entities.UserApp, RegisterUserAppCommand>().ReverseMap();
            CreateMap<TokenDto, AccessToken>().ReverseMap();
        }
    }
}

using AutoMapper;
using Core.Persistence.Paging;
using KodlamaIoDevs.Application.Features.Technology.Dtos;
using KodlamaIoDevs.Application.Features.Technology.Models;

namespace KodlamaIoDevs.Application.Features.Technology.Profiles
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {

            // Query
            CreateMap<IPaginate<Domain.Entities.Technology>, TechnologyListModel>().ReverseMap();
            CreateMap<Domain.Entities.Technology, TechnologyListDto>()
                .ForMember(target => target.ProgrammingLanguageName, opt =>
                    opt.MapFrom(resource => resource.ProgrammingLanguage.Name)).ReverseMap();

        }
    }
}

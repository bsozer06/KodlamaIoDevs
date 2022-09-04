using AutoMapper;
using Core.Persistence.Paging;
using KodlamaIoDevs.Application.Features.ProgrammingLanguage.Commands.CreateProgramingLanguage;
using KodlamaIoDevs.Application.Features.ProgrammingLanguage.Commands.UpdateProgramingLanguage;
using KodlamaIoDevs.Application.Features.ProgrammingLanguage.Dtos;
using KodlamaIoDevs.Application.Features.ProgrammingLanguage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDevs.Application.Features.ProgrammingLanguage.Profiles
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Domain.Entities.ProgrammingLanguage, CreatedProgrammingLanguageDto>().ReverseMap();
            CreateMap<Domain.Entities.ProgrammingLanguage, CreateProgrammingLanguageCommand>().ReverseMap();

            CreateMap<Domain.Entities.ProgrammingLanguage, UpdatedProgrammingLanguageDto>().ReverseMap();
            CreateMap<Domain.Entities.ProgrammingLanguage, UpdateProgrammingLanguageCommand>().ReverseMap();

            CreateMap<IPaginate<Domain.Entities.ProgrammingLanguage>, ProgrammingLanguageListModel>();
            CreateMap<Domain.Entities.ProgrammingLanguage, ProgrammingLanguageDto>().ReverseMap();

            CreateMap<Domain.Entities.ProgrammingLanguage, ProgrammingLanguageGetByIdDto>().ReverseMap();

        }
    }
}

using AutoMapper;
using Core.Persistence.Paging;
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
            //CreateMap<Brand, CreatedBrandDto>().ReverseMap();
            //CreateMap<Brand, CreateBrandCommand>().ReverseMap();

            CreateMap<IPaginate<Domain.Entities.ProgrammingLanguage>, ProgrammingLanguageListModel>();
            CreateMap<Domain.Entities.ProgrammingLanguage, ProgrammingLanguageDto>().ReverseMap();

            //CreateMap<Brand, BrandGetByIdDto>().ReverseMap();

        }
    }
}

using Core.CrossCuttingConcerns.Exceptions;
using KodlamaIoDevs.Application.Services.Repositorties;

namespace KodlamaIoDevs.Application.Features.ProgrammingLanguage.Rules
{
    public class ProgramingLanguageBussinessRules
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

        public ProgramingLanguageBussinessRules(IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
        }

        public void ProgrammingLanguageExistWhenRequested(Domain.Entities.ProgrammingLanguage programmingLanguage)
        {
            if (programmingLanguage == null)
                throw new BusinessException("Requested programming language does not exist!");
        }
    }
}

using Core.CrossCuttingConcerns.Exceptions;
using KodlamaIoDevs.Application.Services.Repositorties;

namespace KodlamaIoDevs.Application.Features.SocialMedia.Rules
{
    public class SocialMediaBussinessRules
    {
        private readonly ISocialMediaRepository _socialMediaRepository;

        public SocialMediaBussinessRules(ISocialMediaRepository socialMediaRepository)
        {
            _socialMediaRepository = socialMediaRepository;
        }

        public async Task SocialMediaCanNotBeDuplicatedWhenInserted(int userId, string url)
        {
            var result = await _socialMediaRepository.GetAsync(b => b.UserId == userId && b.Url == url);
            if (result != null)
                throw new BusinessException("There is already same social media assigned");
        }

        public void SocialMediaShouldExistWhenUpdated(Domain.Entities.SocialMedia socialMedia)
        {
            if (socialMedia == null) 
                throw new BusinessException("Requested social media does not exist");
        }

        public void SocialMediaShouldExistWhenDeleted(Domain.Entities.SocialMedia socialMedia)
        {
            if (socialMedia == null)
                throw new BusinessException("Requested social media does not exist");
        }
    }
}

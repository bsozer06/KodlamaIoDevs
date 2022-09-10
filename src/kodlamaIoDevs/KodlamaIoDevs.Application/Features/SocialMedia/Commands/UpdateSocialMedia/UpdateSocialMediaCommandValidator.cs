using FluentValidation;

namespace KodlamaIoDevs.Application.Features.SocialMedia.Commands.UpdateSocialMedia
{
    public class UpdateSocialMediaCommandValidator : AbstractValidator<UpdateSocialMediaCommand>
    {
        public UpdateSocialMediaCommandValidator()
        {
            RuleFor(g => g.Id)
                .NotNull();

            RuleFor(g => g.Url)
                .NotNull()
                .NotEmpty();
        }
    }
}

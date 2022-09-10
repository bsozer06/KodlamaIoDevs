using Core.Security.Entities;
using Core.Security.Enums;

namespace KodlamaIoDevs.Domain.Entities
{
    public class UserApp: User
    {
        public virtual ICollection<SocialMedia> SocialMedias { get; set; }

        public UserApp()
        {
        }

        public UserApp(int id, string firstName, string lastName, string email, byte[] passwordSalt, 
            byte[] passwordHash, bool status, AuthenticatorType authenticatorType)
            : base(id, firstName, lastName, email, passwordSalt, passwordHash, status, authenticatorType)
        {
        }

    }
}

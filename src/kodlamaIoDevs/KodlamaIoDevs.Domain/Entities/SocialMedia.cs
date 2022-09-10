using Core.Persistence.Repositories;

namespace KodlamaIoDevs.Domain.Entities
{
    public class SocialMedia: Entity
    {
        public string Url { get; set; }
        public int UserId { get; set; }
        public virtual UserApp? UserApp { get; set; }

        public SocialMedia()
        {
        }

        public SocialMedia(int id, string url, int userId): this()
        {
            Id = id;
            Url = url;
            UserId = userId;
        }

    }
}

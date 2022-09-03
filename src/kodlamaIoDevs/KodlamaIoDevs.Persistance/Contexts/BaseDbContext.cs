using KodlamaIoDevs.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace KodlamaIoDevs.Persistance.Contexts
{
    public class BaseDbContext: DbContext
    {
        protected IConfiguration Configuration { get; set; }

        public BaseDbContext(IConfiguration configuration, DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            Configuration = configuration;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(a =>
            {
                a.ToTable("Brands").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");
            });

            /// Seeding data
            Brand[] brandEntitySeeds = {
                new(1, "Tofaş"),
                new(2, "Toros")
            };
            modelBuilder.Entity<Brand>().HasData(brandEntitySeeds);
        }


        public DbSet<Brand> Brands { get; set; }

    }
}

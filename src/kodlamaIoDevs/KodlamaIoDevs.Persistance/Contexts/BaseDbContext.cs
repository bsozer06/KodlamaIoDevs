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
            modelBuilder.Entity<ProgrammingLanguage>(a =>
            {
                a.ToTable("ProgrammingLanguages").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");
            });

            /// Seeding data
            ProgrammingLanguage[] brandEntitySeeds = {
                new(1, "Delphi"),
                new(2, "Pascal")
            };
            modelBuilder.Entity<ProgrammingLanguage>().HasData(brandEntitySeeds);
        }


        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

    }
}

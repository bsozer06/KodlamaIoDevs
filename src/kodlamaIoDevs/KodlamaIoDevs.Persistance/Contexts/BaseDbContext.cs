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
            #region Programminglanguage

            modelBuilder.Entity<ProgrammingLanguage>(a =>
            {
                a.ToTable("ProgrammingLanguages").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");
                a.HasMany(p => p.Technologies);
            });

            /// Seeding data
            ProgrammingLanguage[] programmingLanguageEntitySeeds = {
                new(1, "Javascript"),
                new(2, "C#")
            };
            modelBuilder.Entity<ProgrammingLanguage>().HasData(programmingLanguageEntitySeeds);

            #endregion


            #region Technology

            modelBuilder.Entity<Technology>(t =>
            {
                t.ToTable("Technologies").HasKey(k => k.Id);
                t.Property(p => p.Id).HasColumnName("Id");
                t.Property(p => p.Name).HasColumnName("Name");
                t.Property(p => p.ProgrammingLanguageId).HasColumnName("ProgrammingLanguageId");
                t.HasOne(p => p.ProgrammingLanguage);
            });

            Technology[] technologyEntitySeeds = {
                new(1, "Angular", 1),
                new(2, "ReactJS", 1),
                new(3, "EntityFramework", 2),
            };
            modelBuilder.Entity<Technology>().HasData(technologyEntitySeeds);

            #endregion

        }


        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public DbSet<Technology> Technologies { get; set; }

    }
}

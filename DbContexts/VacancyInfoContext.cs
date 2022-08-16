using Microsoft.EntityFrameworkCore;
using Noticeboard.Entities;

namespace Noticeboard.DbContexts
{
    public class VacancyInfoContext : DbContext
    {
        public DbSet<Vacancy> vacancies { get; set; } = null!;

        
        public VacancyInfoContext(DbContextOptions<VacancyInfoContext> options)
            : base(options)
        {

        }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Vacancy>()
               .HasData(
               new Vacancy("Software developer")
               {
                   Id = 1,
                   Description = "fsdfkmswedfmkles sdffsdfdasfswde."
               },
               new Vacancy("Software Analyst")
               {
                   Id = 2,
                   Description = "asfklnafnaejklf vsdnfgvdlskfcav ."
               },
               new Vacancy("Business Analyst")
               {
                   Id = 3,
                   Description = " Taasfafn ijafnbead asdashfa."
               });

            base.OnModelCreating(modelBuilder);

        }
        /**protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite();
            base.OnConfiguring(optionsBuilder);
        } **/
    }
}

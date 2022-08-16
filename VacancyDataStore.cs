using Noticeboard.Models;

namespace Noticeboard
{
    public class VacancyDataStore
    {
        public List<VacanciesDto> Vacancies { get; set; }
        public static VacancyDataStore Current { get; } = new VacancyDataStore();

        public VacancyDataStore()
        {
            Vacancies = new List<VacanciesDto>()
            {
                new VacanciesDto()
                {
                    Id = 1,
                    Name = "software analyst",
                    Description = "analyse application within the company."
                },
                new VacanciesDto()
                {
                    Id=2,
                    Name = "Business Analyst",
                    Description="bsdfjsklfkdn sdfsfsef"
                }

            };
        }
    }
}

using AutoMapper;

namespace Noticeboard.Profiles
{
    public class vacancyProfile : Profile
    {
        public vacancyProfile()
        {
            CreateMap<Entities.Vacancy, Models.VacanciesDto>();
        }
    }
    
}

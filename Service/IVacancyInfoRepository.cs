using Noticeboard.Entities;

namespace Noticeboard.Service
{
    public interface IVacancyInfoRepository
    {
        Task<IEnumerable<Vacancy>> GetVacanciesAsync();
        Task<Vacancy?> GetVacancyAsync(int vacancyId);
    }
}

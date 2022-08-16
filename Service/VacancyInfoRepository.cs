using Microsoft.EntityFrameworkCore;
using Noticeboard.DbContexts;
using Noticeboard.Entities;

namespace Noticeboard.Service
{
    public class VacancyInfoRepository : IVacancyInfoRepository
    {
        private readonly VacancyInfoContext _context;

        public VacancyInfoRepository(VacancyInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Vacancy>> GetVacanciesAsync()
        {
            return await _context.vacancies.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<Vacancy?> GetVacancyAsync(int vacancyId)
        {
            return await _context.vacancies.Where(c => c.Id == vacancyId).FirstOrDefaultAsync();
        }
    }
}

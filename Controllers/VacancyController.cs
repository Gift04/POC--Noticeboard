using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Noticeboard.Models;
using Noticeboard.Service;

namespace Noticeboard.Controllers
{
    [ApiController]
    [Route("api/Vacancies")]
    public class VacancyController : Controller
    {

        private IVacancyInfoRepository _vacancyInfoRepository;
        private IMapper _mapper;

        public VacancyController(IVacancyInfoRepository vacancyInfoRepository, IMapper mapper)
        {
            _vacancyInfoRepository = vacancyInfoRepository ?? throw new ArgumentNullException(nameof(_vacancyInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }


         [HttpGet]
        public async Task<ActionResult<IEnumerable<VacanciesDto>>> GetVacancies()
        {
            var vacancyEntities = await _vacancyInfoRepository.GetVacanciesAsync();
            return Ok(_mapper.Map<IEnumerable<VacanciesDto>>(vacancyEntities));

          
            //return Ok(VacancyDataStore.Current.Vacancies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVacancy(int id)
        {
            var vacancy = await _vacancyInfoRepository.GetVacancyAsync(id);

            if (vacancy == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<VacanciesDto>(vacancy));
        }
    }
}

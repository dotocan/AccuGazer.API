using System.Threading.Tasks;
using AccuGazer.API.Dtos;
using AccuGazer.API.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccuGazer.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingsRepository _repo;
        private readonly IMapper _mapper;

        public SettingsController(ISettingsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetSettings()
        {
            var settings = await _repo.GetSettings();
            var settingsToReturn = _mapper.Map<SettingsDto>(settings);
            return Ok(settingsToReturn);
        }
    }
}
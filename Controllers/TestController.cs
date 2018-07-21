using System.Security.Claims;
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
    public class TestController : Controller
    {
        private readonly ITestRepository _repo;
        private readonly IMapper _mapper;

        public TestController(ITestRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTestsForCurrentUser() {
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var tasksToReturn = await _repo.GetTestsForUser(currentUserId);
            return Ok(tasksToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> SaveTest([FromBody] TestForSaveDto testForSaveDto) {
            var testResult = testForSaveDto.TestResult;
            var measurements = testResult.Measurements;
            
            foreach(var measurement in measurements) {
                
            }


            return StatusCode(201);
        }
    }
}
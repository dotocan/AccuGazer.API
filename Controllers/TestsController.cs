using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AccuGazer.API.Dtos;
using AccuGazer.API.Models;
using AccuGazer.API.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccuGazer.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly ITestRepository _repo;
        private readonly IMapper _mapper;

        public TestsController(ITestRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTestsForCurrentUser() {
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var tests = await _repo.GetTestsForUser(currentUserId);

            var testsToReturn = new List<TestDto>();

            foreach (var test in tests) {
                var testToReturn = _mapper.Map<TestDto>(test);
                testsToReturn.Add(testToReturn);
            }

            return Ok(testsToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> SaveTest(TestDto testForSaveDto) {            
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var testForSave = _mapper.Map<Test>(testForSaveDto);
            var savedTest = await _repo.SaveTest(currentUserId, testForSave);

            var testToReturn = _mapper.Map<TestDto>(savedTest);

            return Ok(testToReturn);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccuGazer.API.Data;
using AccuGazer.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AccuGazer.API.Repositories
{
    public class TestRepository : ITestRepository
    {
        private readonly DataContext _context;

        public TestRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Test>> GetTestsForUser(int userId)
        {
            var tests = await _context.Tests.Where(u => u.UserId == userId)
                .Include(t => t.TestResult)
                .Include(t => t.TestResult.Measurements)
                .ThenInclude(m => m.Rectangle)
                .Include(t => t.TestResult.Measurements)
                .ThenInclude(m => m.GazePoint)
                .ToListAsync();

            return tests;
        }

        public async Task<Test> SaveTest(int userId, Test testForSave)
        {
            testForSave.UserId = userId;
            await _context.Tests.AddAsync(testForSave);
            await _context.SaveChangesAsync();
            return testForSave;
        }
    }
}
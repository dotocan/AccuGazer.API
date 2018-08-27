using System.Collections.Generic;
using System.Threading.Tasks;
using AccuGazer.API.Models;

namespace AccuGazer.API.Repositories
{
    public interface ITestRepository
    {
         Task<List<Test>> GetTestsForUser(int userId);
         Task<Test> SaveTest(int userId, Test testForSave);
    }
}
using System.Threading.Tasks;
using AccuGazer.API.Data;
using AccuGazer.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AccuGazer.API.Repositories
{
    public class SettingsRepository : ISettingsRepository
    {
        private readonly DataContext _context;

        public SettingsRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Settings> GetSettings()
        {
            return await _context.Settings.FirstOrDefaultAsync();
        }
    }
}
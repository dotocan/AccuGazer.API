using System.Threading.Tasks;
using AccuGazer.API.Models;

namespace AccuGazer.API.Repositories
{
    public interface ISettingsRepository
    {
         Task<Settings> GetSettings();
    }
}
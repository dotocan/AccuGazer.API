using AccuGazer.API.Models;
using AccuGazer.API.Repositories;
using Newtonsoft.Json;

namespace AccuGazer.API.Data
{
    public class Seed
    {
        private readonly DataContext _context;
        private readonly ISettingsRepository _repo;

        public Seed(DataContext context, ISettingsRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        public async void SeedSettings()
        {
            var settingsToDelete = await _repo.GetSettings();
            if(settingsToDelete != null)
                _context.Settings.Remove(settingsToDelete);

            var settingsData =
                System.IO.File.ReadAllText("Data/SettingsSeedData.json");
            var settings = JsonConvert.DeserializeObject<Settings>(settingsData);

            _context.Settings.Add(settings);

            _context.SaveChanges();
        }
    }
}
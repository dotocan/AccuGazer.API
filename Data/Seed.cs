using AccuGazer.API.Models;
using Newtonsoft.Json;

namespace AccuGazer.API.Data
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedSettings()
        {
            var settingsData =
                System.IO.File.ReadAllText("Data/SettingsSeedData.json");
            var settings = JsonConvert.DeserializeObject<Settings>(settingsData);

            _context.Settings.Add(settings);

            _context.SaveChanges();
        }
    }
}
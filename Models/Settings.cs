namespace AccuGazer.API.Models
{
    public class Settings
    {
        public long Id { get; set; }
        public long TestDurationInSeconds { get; set; }
        public int NumberOfTests { get; set; }
        public bool Shuffle { get; set; }
    }
}
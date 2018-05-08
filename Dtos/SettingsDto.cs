namespace AccuGazer.API.Dtos
{
    public class SettingsDto
    {
        public long Id { get; set; }
        public long TestDurationInSeconds { get; set; }
        public int NumberOfTests { get; set; }
        public bool Shuffle { get; set; }
    }
}
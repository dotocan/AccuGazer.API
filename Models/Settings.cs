namespace AccuGazer.API.Models
{
    public class Settings
    {
        public long Id { get; set; }
        public long RectangleDuration { get; set; }
        public int NumberOfRectanglesInTest { get; set; }
        public bool Shuffle { get; set; }
    }
}
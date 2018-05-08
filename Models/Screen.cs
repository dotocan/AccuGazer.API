namespace AccuGazer.API.Models
{
    public class Screen
    {
        public long Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int TestSessionId { get; set; }
        public TestSession TestSession { get; set; }
    }
}
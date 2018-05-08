namespace AccuGazer.API.Models
{
    public class TestMeasurement
    {
        public int Id { get; set; }
        public long Start { get; set; }
        public long End { get; set; }
        public bool Hit { get; set; }
        public GazePoint GazePoint { get; set; }

        public int TestId { get; set; }
        public Test Test { get; set; }
    }
}
namespace AccuGazer.API.Models
{
    public class GazePoint
    {
        public long Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public long MeasurementId { get; set; }
        public Measurement Measurement { get; set; }
    }
}
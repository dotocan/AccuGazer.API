namespace AccuGazer.API.Models
{
    public class GazePoint
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public int MeasurementId { get; set; }
        public Measurement Measurement { get; set; }
    }
}
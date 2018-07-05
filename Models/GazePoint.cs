namespace AccuGazer.API.Models
{
    public class GazePoint
    {
        public int Id { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }

        public int MeasurementId { get; set; }
        public Measurement Measurement { get; set; }
    }
}
namespace AccuGazer.API.Models
{
    public class Rectangle
    {
        public long Id { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int MeasurementId { get; set; }
        public Measurement Measurement { get; set; }
    }
}
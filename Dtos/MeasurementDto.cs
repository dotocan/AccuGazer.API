namespace AccuGazer.API.Dtos
{
    public class MeasurementDto
    {
        public long MeasuredAt { get; set; }
        public bool IsHit { get; set; }

        public RectangleDto Rectangle { get; set; }

        public GazePointDto GazePoint { get; set; }
    }
}
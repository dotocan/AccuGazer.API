namespace AccuGazer.API.Models
{
    public class GazePoint
    {
        public int Id { get; set; }
        public int XOffsetPercent { get; set; }
        public int YOffsetPercent { get; set; }

        public int TestMeasurementId { get; set; }
        public TestMeasurement TestMeasurement { get; set; }
    }
}
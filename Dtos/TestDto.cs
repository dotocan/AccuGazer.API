using System.Collections.Generic;

namespace AccuGazer.API.Dtos
{
    public class TestDto
    {
        public long StartTime { get; set; }
        public long EndTime { get; set; }
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }

        public List<MeasurementDto> measurements;
    }
}
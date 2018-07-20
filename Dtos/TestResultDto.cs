using System.Collections.Generic;

namespace AccuGazer.API.Dtos
{
    public class TestResultDto
    {
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }

        public List<MeasurementDto> Measurements { get; set; }
    }
}
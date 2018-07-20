using System.Collections.Generic;

namespace AccuGazer.API.Models
{
    public class TestResult
    {
        public long Id { get; set; }

        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }

        public List<Measurement> Measurements { get; set; }

        public long TestId { get; set; }
        public Test Test { get; set; }
    }
}
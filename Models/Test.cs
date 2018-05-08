using System.Collections.Generic;

namespace AccuGazer.API.Models
{
    public class Test
    {
        public long Id { get; set; }
        public int TestNumber { get; set; }
        public long Start { get; set; }
        public long End { get; set; }

        public Rectangle Rectangle { get; set; }
        public List<TestMeasurement> TestMeasurements { get; set; }

        public int TestSessionId { get; set; }
        public TestSession TestSession { get; set; }
    }
}
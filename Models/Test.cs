using System;
using System.Collections.Generic;

namespace AccuGazer.API.Models
{
    public class Test
    {
        public long Id { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public List<Measurement> Measurements { get; set; }
    }
}
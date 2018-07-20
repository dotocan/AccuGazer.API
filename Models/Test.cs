using System;
using System.Collections.Generic;

namespace AccuGazer.API.Models
{
    public class Test
    {
        public long Id { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }
        public TestResult TestResult { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }
    }
}
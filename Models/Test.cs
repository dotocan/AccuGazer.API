using System;
using System.Collections.Generic;

namespace AccuGazer.API.Models
{
    public class Test
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }
        public TestResult TestResult { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
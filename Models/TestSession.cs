using System;
using System.Collections.Generic;

namespace AccuGazer.API.Models
{
    public class TestSession
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public long Start { get; set; }
        public long End { get; set; }
        public List<Test> Tests { get; set; }
        public Screen Screen { get; set; }
        public User User { get; set; }
    }
}
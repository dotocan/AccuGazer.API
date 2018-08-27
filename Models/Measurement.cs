using System;

namespace AccuGazer.API.Models
{
    public class Measurement
    {
        public long Id { get; set; }
        public long MeasuredAt { get; set; }
        public bool IsHit { get; set; }

        public long RectangleId { get; set; }
        public Rectangle Rectangle { get; set; }

        public long GazePointId { get; set; }
        public GazePoint GazePoint { get; set; }
    }
}
namespace AccuGazer.API.Models
{
    public class Rectangle
    {
        public long Id { get; set; }
        public int XOffsetPercent { get; set; }
        public int YOffsetPercent { get; set; }
        public int WidthPercent { get; set; }
        public int HeightPercent { get; set; }

        public int TestId { get; set; }
        public Test Test { get; set; }
    }
}
namespace lab04
{
    public class FinalGrade
    {
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public FinalGrade(Subject sub, double v, DateTime date)
        {
            Subject = sub;
            Value = v;
            Date = date;
        }
    }
}

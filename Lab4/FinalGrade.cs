namespace Lab4
{
    public class FinalGrade : IContainer, IDisplayable
    {
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public FinalGrade(Subject subject, double value, DateTime date)
        {
            Subject = subject;
            Value = value;
            Date = date;
        }
        public override string ToString()
        {
            return $"FinalGrade | {Subject}, {Value},  {Date}\n"; 
        }
    }
}

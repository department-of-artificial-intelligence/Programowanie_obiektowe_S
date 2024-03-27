namespace lab4
{
    public class FinalGrade
    {
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }

        FinalGrade(Subject subject, DateTime date, double value)
        {
            Subject = subject;
            Date = date;
            Value = value;
        }
        public override string ToString()
        {
            return $"Subject: {Subject}, Date: {Date}, Value: {Value}";
        }
    }
}

namespace PO.Lab4.Classes
{
    public class FinalGrade
    {
        public Subject Subject { get; set; }

        public DateTime Date { get; set; }

        public double Value { get; set; }

        public FinalGrade(Subject subject, double value, DateTime date)
        {
            Subject = subject;
            Date = date;
            Value = value;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Subject}, {Date}, {Value}";
        }
    }


}

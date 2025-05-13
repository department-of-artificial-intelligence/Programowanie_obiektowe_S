namespace Lab8.WpfApp
{
    public class Grade
    {
        public float Value { get; set; }

        public string Subject { get; set; }

        public Grade(float value, string subject)
        {
            Value = value;
            Subject = subject;
        }

        public override string ToString()
        {
            return Subject + "-" + Value;
        }
    }
}

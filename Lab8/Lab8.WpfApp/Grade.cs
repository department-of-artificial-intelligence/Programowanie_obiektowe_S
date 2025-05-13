namespace Lab8.WpfApp
{
    public class Grade
    {
        public float GradeValue { get; set; }

        public Grade()
        {
            GradeValue = 3.0f;
        }

        public Grade(float gradeValue)
        {
            GradeValue = gradeValue;
        }

        public override string ToString()
        {
            return $"{GradeValue}; ";
        }
    }
}


namespace Lab8.BLL
{
    public class Student
    {
        public string FirstName {  get; set; }
        public string SurName { get; set; }
        public string Faculty { get; set; }
        public int StudentNo { get; set; }
        public IList<Grade> Grades { get; set; } = new List<Grade>();
        public Student()
        {
            FirstName = "Pusto";
            SurName = "Pusto";
            Faculty = "Pusto";
            StudentNo = 0000;
        }
       public Student(string firstName, string surName, string faculty, int studentNo)
        {
            FirstName = firstName;
            SurName = surName;
            Faculty = faculty;
            StudentNo = studentNo;
        }
    }
    public class Grade
    {
        public float Value { get; set; }
        public string SubjectName { get; set; }
        public Grade()
        {
            Value = 0;
            SubjectName = "Brak";
        }
        public Grade(float value, string subjectName)
        {
            Value = value;
            SubjectName = subjectName;
        }
    }
}

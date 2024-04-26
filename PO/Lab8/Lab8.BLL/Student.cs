
namespace Lab8.BLL
{
    public class Student
    {
        public string FirstName { get; set; }= string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ulong StudentNo {  get; set; }
        public string Faculty { get; set; } = string.Empty;
        public List<Grade> Grades { get; set; }
        public string GradesText { get =>GetGradesText();}

        public Student() { }

        public Student(string firstName, string lastName, ulong studentNo, string faculty)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentNo = studentNo;
            Faculty = faculty;
        }

        public string GetGradesText()
        {
            var result = "";
            foreach (var grade in Grades)
            {
                result += $"#{grade.Id}: {grade.Value}, {grade.ClassName} ";
            }
            return result;
        }
    }

}

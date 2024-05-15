
namespace Lab8.BLL
{
    public class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int StudentNo { get; set; }
        public string Faculty { get; set;}

        public Student()
        {
            StudentNo = 0;
            FirstName = string.Empty;
            SurName = string.Empty;
            Faculty = string.Empty;
        }
    }

}

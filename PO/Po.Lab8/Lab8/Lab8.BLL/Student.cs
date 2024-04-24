namespace Lab8.BLL
{
    public class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Faculty { get; set; }
        public int StudentNo { get; set; }

        public Student()
        {
            FirstName = "nieznane";
            SurName = "nieznane";
            Faculty = "nieznane";
            StudentNo = 0;
        }
        public Student(string firstName, string surName, string factility, int number)
        {
            FirstName = firstName;
            SurName = surName;
            Faculty = factility;
            StudentNo = number;
        }
    }
}

namespace Lab08.App
{
    public class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Faculty { get; set; }
        public int StudentNo { get; set; }

        public Student() { }
        public Student(string fn, string sn, string f, int no)
        {
            FirstName = fn;
            SurName = sn;
            Faculty = f;
            StudentNo = no;
        }
    }
}

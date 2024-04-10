
namespace Lab8.BLL
{
    public class Student
    {
        public string FirstName { get; set; }= string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ulong StudentNo {  get; set; }
        public string Faculty { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{FirstName} {LastName}, id {StudentNo}, wydzial {Faculty}";
        }
    }

}

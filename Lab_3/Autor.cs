namespace Lab_3
{
    public class Autor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        Autor() { }
        Autor(string firstName, string lastName, string nationality)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }
        public override string ToString()
        {
            return $"FirstName:{FirstName},LastName{LastName},Nationality:{Nationality}";
        }
    }
}

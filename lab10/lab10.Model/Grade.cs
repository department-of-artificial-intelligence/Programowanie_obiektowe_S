using System.Globalization;
namespace lab10.Model;
public class Grade
{
    //[Key] // Adnotacja klucza g�ownego.
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string Subject { get; set; } = null!;
    public double Value { get; set; }
    //// Dawniej wymagana adnotacja klucza obcego,
    //// parametr name musi by� zgodna z nazw� w�asciwo�ci nawigacyjnej
    //[ForeignKey("Student")]
    //public int StudentId { get; set; } // w�a�ciwo�� klucza obcego
    public Student Student { get; set; } = null!; //w�a�ciwo�� nawigacyjna
    public override string ToString()
    {
        return Value.ToString(CultureInfo.InvariantCulture);
    }
}
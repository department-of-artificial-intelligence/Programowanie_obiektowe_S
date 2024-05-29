using System.Globalization;
namespace lab10.Model;
public class Grade
{
    //[Key] // Adnotacja klucza g³ownego.
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string Subject { get; set; } = null!;
    public double Value { get; set; }
    //// Dawniej wymagana adnotacja klucza obcego,
    //// parametr name musi byæ zgodna z nazw¹ w³asciwoœci nawigacyjnej
    //[ForeignKey("Student")]
    //public int StudentId { get; set; } // w³aœciwoœæ klucza obcego
    public Student Student { get; set; } = null!; //w³aœciwoœæ nawigacyjna
    public override string ToString()
    {
        return Value.ToString(CultureInfo.InvariantCulture);
    }
}
using System.Globalization;
namespace Lab10.Model.Entities;
public class Grade
{
    //[Key] // Adnotacja klucza głownego.
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string Subject { get; set; } = null!;
    public double Value { get; set; }
    //// Dawniej wymagana adnotacja klucza obcego,
    //// parametr name musi być zgodna z nazwą własciwości nawigacyjnej
    //[ForeignKey("Student")]
    //public int StudentId { get; set; } // właściwość klucza obcego
    public Student Student { get; set; } = null!; //właściwość nawigacyjna
    public override string ToString()
    {
        return Value.ToString(CultureInfo.InvariantCulture);
    }
}

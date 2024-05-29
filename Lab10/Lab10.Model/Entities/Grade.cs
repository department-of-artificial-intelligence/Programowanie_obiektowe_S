using Lab10.Model.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
namespace Lab10.Model.Entities;
public class Grade
{
    [Key]
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string Subject { get; set; } = null!;
    public double Value { get; set; }
    [ForeignKey("Student")]
    public int StudentId { get; set; }
    [Hide]
    public Student Student { get; set; } = null!;
    public override string ToString()
    {
        return Value.ToString(CultureInfo.InvariantCulture);
    }
}
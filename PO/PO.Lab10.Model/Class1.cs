using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace PO.Lab10.Model
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Subject { get; set; } = null!;
        public double Value { get; set; }
        [ForeignKey("Student")]
        public Student student { get; set; } = null!;
        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }
        object a = 5;
    }

    public class Student
    {

    }

}

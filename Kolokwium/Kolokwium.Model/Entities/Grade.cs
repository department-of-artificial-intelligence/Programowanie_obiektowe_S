using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Model.Entities
{
    public class Grade
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Subject { get; set; } = null!;
        public double Value { get; set; }
        public Student Student { get; set; } = null!; //właściwość nawigacyjna
        public int StudentId { get; set; }
        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }
    }
}

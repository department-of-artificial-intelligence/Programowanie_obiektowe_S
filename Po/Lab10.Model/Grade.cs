using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab10.Model
{
    public class Grade
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Subject { get; set; } = null;
        public double Value { get; set; }

        public Student Student { get; set; } = null!;

        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }
    }
}

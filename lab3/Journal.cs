using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3 {
    public class Journal : Item {
        public int Number { get; set; }

        public Journal() {
        }

        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(title, id, publisher, dateOfIssue) {
            Number = number;
        }

        public override string ToString() {
            return base.ToString() +
                   $", {this.Number}";
        }

        public override string GenerateBarCode() {
            string napis = "";
            for (int i = 0; i < 14; i++) {
                Random random = new Random();
                napis += random.Next(10);
            }
            return napis;
        }
    }
}

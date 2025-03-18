using System.Runtime.CompilerServices;

namespace Lab3
{
    internal class Journal : Item
    {
        public int Number
        {
            get;
            set;
        }
        public Journal() : base()
        {
            Number = 0;
        }
        public Journal(int id, string title, string publisher, DateTime dateOfIssue ,int number) : base(id, title, publisher, dateOfIssue)
        {
            number = Number;
        }
        public override string ToString()
        {
            return $"Journal | {base.ToString()}, number: {Number}";
        }
        public override string GenerateBarCode()
        {
            return "1 5 8 2 1 5 8 2 1 0 4 1 9";
        }
        //fake shid
    }
}

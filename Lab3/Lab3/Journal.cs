

namespace Lab3
{
    public class Journal : Item
    {
        public int Number { get; set; }
        public Journal() : base()
        {
            Number = 0;
        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue ,int number) : base(id, title, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return $"Journal | {base.ToString()}, numer: {Number}";
        }
        public override string GenerateBarCode()
        {
            return "1 5 8 2 1 5 8 2 1 0 4 1 9";
        }
        //fake shid
    }
}


namespace lab3
{
    internal class Journal : Item
    {
        public int Number { get; set; }
        public Journal() : base()
        {
            Number = 0;
        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue,int number) 
            : base(title, id, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Number | {Number}";
        }

        public override string GenerateBarCode()
        {
            return " ";
        }
    }
}

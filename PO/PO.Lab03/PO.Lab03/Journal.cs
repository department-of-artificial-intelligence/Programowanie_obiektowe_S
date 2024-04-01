namespace PO.Lab03
{
    internal class Journal : Item
    {
        public int Number { get; set; }

        public Journal() : base()
        {
            Number = 0;
        }

        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
            : base(title, id, publisher, dateOfIssue)
        {
            Number = number;
        }

        public override string ToString()
        {
            return $"Journal | {base.ToString()}, Number: {Number}";
        }

        public override string GenerateBarCode()
        {
            Random random = new Random();
            string str = "";
            for (int i = 0; i < 12; i++)
            {
                str += random.Next(10);
            }
            return str;
        }
    }
}

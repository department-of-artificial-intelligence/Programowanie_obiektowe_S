namespace PO.Lab3.Classes
{
    public class Journal : Item
    {
        public int Number
        {
            get; set;
        }

        public Journal()
        {

        }

        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(id, title, publisher, dateOfIssue)
        {
            Number = number;
        }

        public override string ToString()
        {
            return base.ToString() + $"Number:{Number}";
        }
        private static Random random = new Random();
        public override string GenerateBarCode()
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int length = 13;
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }

}


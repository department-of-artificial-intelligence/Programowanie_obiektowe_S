namespace Lab_3
{
    public class Journal : Item
    {
        public int Number { get; set; }
        public Journal()
        {
            Number = 0;
        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
            : base(id, title, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return $"Jornal | {base.ToString()},Number{Number}";
        }

        public override string GenerateBarCode()
        {
            Random rand = new Random();
            string result = "";
            for (int i = 0; i < 8; i++)
            {
                result += rand.Next(10);
            }
            return result; //póżniej zrób generator
        }
    }
}

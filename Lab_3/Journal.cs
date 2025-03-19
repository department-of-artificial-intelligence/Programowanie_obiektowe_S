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
            return $"Item | {base.ToString()},Number{Number}";
        }

        public override string GenerateBarCode()
        {
            return "test"; //póżniej zrób generator
        }
    }
}

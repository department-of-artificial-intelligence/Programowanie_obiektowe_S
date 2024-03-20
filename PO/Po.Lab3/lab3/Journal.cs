namespace lab3
{
    public class Journal : Item
    {
        int Number { get; set; }
        Journal()
         : base()
        {
            Number = 0;
        }
        Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
        : base(title, id, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return $"Id: {_id}, Title: {_title}, Publisher: {_publisher},Date time: {_dateOfIssue}, Number {Number}";
        }
        public override string GenerateBarCode()
        {
            Random rnd = new Random();
            return (rnd.Next(100, 999)).ToString();
        }
    }
}

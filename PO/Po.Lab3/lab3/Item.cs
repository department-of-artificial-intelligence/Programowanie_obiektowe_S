namespace lab3
{
    public abstract class Item
    {
        protected int _id;
        protected string? _title = null!;
        protected string? _publisher = null!;
        protected DateTime _dateOfIssue;

        public int Id { get => _id; set => _id = value; }
        public string? Title { get => _title; set => _title = value; }
        public string? Publisher { get => _publisher; set => _publisher = value; }
        public DateTime DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }

        public Item()
        {
            _id = 0;
            _title = "nieznany";
            _publisher = "nieznany";
            _dateOfIssue = DateTime.MinValue;
        }
        public Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            _id = id;
            _title = title;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
        }
        public override string ToString()
        {
            return $"Id: {_id}, Title: {_title}, Publisher: {_publisher},Date time: {_dateOfIssue}";
        }
        public virtual void Details()
        {
            Console.WriteLine(this.ToString());
        }
        public abstract string GenerateBarCode();

    }
}

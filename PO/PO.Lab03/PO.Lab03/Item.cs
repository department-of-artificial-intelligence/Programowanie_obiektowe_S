namespace PO.Lab03
{
    internal abstract class Item
    {
        protected string _title;
        protected int _id;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Publisher { get => _publisher; set => _publisher = value; }
        public DateTime DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }

        public Item()
        {
            _title = "";
            _id = 0;
            _publisher = "";
            _dateOfIssue = DateTime.MinValue;
        }

        protected Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            _id = id;
            _title = title;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            return $"Item | ID: {_id}, Title:{_title}, Publisher:{_publisher}, Date Of Issue:{_dateOfIssue}.";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string GenerateBarCode();

    }
}

namespace Lab_3
{
    public abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        public DateTime DateOfIssue
        {
            get { return _dateOfIssue; }
            set { _dateOfIssue = value; }
        }
        public Item()
        {
            _id = 0;
            _title = "none";
            _publisher = "none";
            _dateOfIssue = DateTime.MinValue;
        }
        public Item(int id, string title, string publisher, DateTime dateOfIssue)
        {
            _id = id;
            _title = title;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;

        }
        public override string ToString()
        {
            return $"Id:{_id},Title:{_title},Publisher:{_publisher},DateOfIssue{_dateOfIssue}";
        }
        public void Details()
        {
            Console.WriteLine(ToString());
        }
        public abstract string GenerateBarCode();
    }
}

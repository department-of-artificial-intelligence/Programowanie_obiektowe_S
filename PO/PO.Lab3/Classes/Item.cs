namespace PO.Lab3.Classes
{
    public abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateofIssue;

        public int Id { get { return _id; } set { _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }

        public string Publisher { get { return _publisher; } set { _publisher = value; } }

        public DateTime DateOfIssue { get { return _dateofIssue; } set { _dateofIssue = value; } }

        public Item()
        {
            _id = 0;
            _title = "nie znany";
            _publisher = "nie znany";
            _dateofIssue = DateTime.MinValue;
        }
        public Item(int id, string title, string publisher, DateTime dateOfIssue)
        {
            _id = id;
            _title = title;
            _publisher = publisher;
            _dateofIssue = dateOfIssue;

        }

        public override string ToString()
        {
            return $"Item | ID: {_id}, Title: {_title}, Publisher:{_publisher}, DateOfIssue:{_dateofIssue}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string GenerateBarCode();


    }

}


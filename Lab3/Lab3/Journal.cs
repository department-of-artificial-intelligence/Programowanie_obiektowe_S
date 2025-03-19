namespace Lab3
{
    public class Journal: Item
    {
        public int Number { get; set; }
        public Journal() {
            Number = 0;
        }

        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(id, title, publisher, dateOfIssue) {
            Number = number;
        }

        public override string ToString()
        {
            return $"Journal | {base.ToString()}, number = {Number}";
        }
        public override string GenerateBarCode()
        {
            Random random = new Random();
            StringBuilder result = new StringBuilder();


            for (int i = 0; i < 8; i++)
            {
                result.Append(random.Next(0, 10)); 
            }
            Console.WriteLine(result.ToString());
        }
    }
}

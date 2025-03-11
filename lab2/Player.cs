namespace lab2
{
    internal class Player : Person
    {
        private string _position;
        private string _club;
        private int _scoredGoals;

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string Club
        {
            get { return _club; }
            set { _club = value; }
        }
        public int ScoredGoals
        {
            get { return _scoredGoals; }
            set { _scoredGoals = value; }
        }

        public Player() : base()
        {
            Position = "brak";
            Club = "brak";
            ScoredGoals = 0;
        }

        public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            Club = club;
            ScoredGoals = scoredGoals;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, DateOfBirth: {DateOfBirth}, Position: {Position}, Club: {Club},ScoredGoals: {ScoredGoals}";
        }

        public void ScoreGoal()
        {
            ScoredGoals++;
            Console.WriteLine($"Player {FirstName} {LastName} scored a goal!");
        }
    }
}

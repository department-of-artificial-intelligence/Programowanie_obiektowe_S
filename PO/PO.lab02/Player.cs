namespace PO.lab02
{
    internal class Player : Person
    {
        private string _position = null!;
        private string _club = null!;
        private int _scoredGoals;

        public string Position { get { return _position; } set { _position = value; } }
        public string Club { get { return _club; } set { _club = value; } }
        public int ScoredGoals { get { return _scoredGoals; } set { _scoredGoals = value; } }

        public Player()
        {
            _position = string.Empty;
            _club = string.Empty;
            _scoredGoals = 0;
        }

        public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            Club = club;
            ScoredGoals = scoredGoals;
        }
        public override string ToString()
        {
            return $"Student | FirstName: {FirstName}, LastName: {LastName}, Date of Birth: {DateOfBirth}, Position: {Position}, Club: {Club}, Scored Goals: {ScoredGoals}.";
        }

        public virtual void ScoreGoal()
        {
            ScoredGoals++;
        }



    }
}

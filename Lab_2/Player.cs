namespace Lab_2
{
    public class Player : Person
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
        public Player()
        {
            _position = "none";
            _club = "none";
            _scoredGoals = 0;
        }
        public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
            : base(firstName, lastName, dateOfBirth)
        {
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }
        public override string ToString()
        {
            return $"Student | {base.ToString()},Position:{_position},Club:{_club},SroredGoals{_scoredGoals}";
        }
        public void ScoreGoal()
        {
            _scoredGoals++;
        }
    }
}

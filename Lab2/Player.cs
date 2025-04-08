namespace Lab2
{
    class Player : Person
    {
        private string? _position;
        private string? _club;
        private int? _scoredGoals;

        public string? Position { get; set; }
        public string? Club { get; set; }
        public string? ScoredGoals { get; set; }

        public Player()
        {
            _position = "";
            _club = "";
            _scoredGoals = 0;
        }

        public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth)
        {
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }

        public virtual void ScoreGoal()
        {
            _scoredGoals++;
        }

        public override string ToString()
        {
            return base.ToString() + $"Position: {_position}, Club: {_club}, Scored Goals: {_scoredGoals}\n";
        }
    }
}

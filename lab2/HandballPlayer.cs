using lab2;

namespace Lab2
{
    internal class HandballPlayer : Player
    {
        

        public HandballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth, position, club, scoredGoals)
        {
            
        }

        public override void ScoreGoal()
        {
            ScoredGoals++;
            Console.WriteLine($"HandballPlayer {FirstName} {LastName} scored a goal!");
        }
    }
}
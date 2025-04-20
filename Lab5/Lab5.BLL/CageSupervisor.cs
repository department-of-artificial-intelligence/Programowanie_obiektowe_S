
using Generic.Extensions;

namespace Lab5.BLL
{
    public class CageSupervisor : Employee, IContainer, IDisplayable
    {
        public IList<Cage> Cages { get; set; }
        public DateTime Time { get; set; }

        public CageSupervisor(string firstName, string lastName, DateTime dateOfBirth, DateTime time, IList<Cage> cages)
            : base(firstName, lastName, dateOfBirth)
        {
            Time = time;
            Cages = cages ?? new List<Cage>();
        }

        public override string ToString()
        {
            return $"{base.ToString()} Time: {Time}\nSupervised Cages:\n{string.Join("\n", Cages.Select(c => c.ToString()))}";
        }
    }
}
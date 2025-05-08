using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium5
{
    public class Zoo
    {
        private string _zooName;
        private IList<Animal> _allAnimals;
        private IList<Cage> _allCages;
        private IList<Guardian> _allGuardians;

        public Zoo(string name, IList<Animal> animals, IList<Cage> cages, IList<Guardian> guardians)
        {
            _zooName = name;
            _allAnimals = animals;
            _allCages = cages;
            _allGuardians = guardians;
        }

        public Cage BuildCage(int cap, bool needCleaning)
        {

            var animals = new List<Animal>();

            var cage = new Cage(cap, needCleaning, animals);
            _allCages.Add(cage);
            return cage;
        }

        public void ExpandCage(Cage cage, int num)
        {
            cage.expandCage(num);
        }

        

        public override string ToString()
        {
            return $"at zoo {_zooName} are {_allAnimals.Count()} animals, in {_allCages.Count()} cages, and {_allGuardians.Count()} working guardians";
        }
    }
}

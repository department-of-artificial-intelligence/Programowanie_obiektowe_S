using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gosha
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public List<Cage> AssignedCages { get; set; } = new List<Cage>();

        public Zoo Zoo
        {
            get => default;
            set
            {
            }
        }

        public Employee(int id, string name, string role)
        {
            Id = id;
            Name = name;
            Role = role;

        }
        public void AssignCage(Cage cage)
        {
            if (!AssignedCages.Contains(cage))
            {
                AssignedCages.Add(cage);
                Console.WriteLine($"Employee {Name} has been assigned to cage {cage.Capacity}");
            }
            else
            {
                Console.WriteLine($"Employee {Name} is already assigned to this cage");
            }
        }
        public void CleanAssignedCages()
        {
            foreach (var cage in AssignedCages)
            {
                if (cage.NeedCleaning)
                {
                    cage.NeedCleaning = false;
                    Console.WriteLine($"Cage {cage.Capacity} cleaned by {Name}");
                }
            }
        }
        public override string ToString()
        {
            return $"Employee {Name} (Id: {Id}, Name: {Name}, Role: {Role}, Assigned Cage: {AssignedCages.Count}";
        }
    }
}
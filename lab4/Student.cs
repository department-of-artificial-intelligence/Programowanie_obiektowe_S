using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace lab4
{
    internal class Student: Person 
    {
        private int _id;
        private IList<FinalGrade> _grades;
        private int _semester;
        private int _group;
        private int _indexId;
        private string _specalization;


        public IList<FinalGrade> Grades
        {
            get => _grades;
            set => _grades.Add((FinalGrade)value);
        }

        public int Semester
        {
            get => _semester;
            set => _semester = value;
        }

        public int Group
        {
            get => _group;
            set => _group = value;
        }

        public int IndexId
        {
            get => _indexId;
            set => _indexId = value;
        }

        public string Specialization
        {
            get => _specalization;
            set => _specalization = value;
        }

        /*public double AverageGrades
        {
            
        }*/

        public Student(string firstName, string lastName,DateTime dateOfBirth,
            string specialization, int group, int semester=1):base(firstName,lastName,dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
        }

        public override string ToString()
        {
            return base.ToString()+$" Specalization: {Specialization}, Group: {Group}, Semester: {Semester} ";
        }
    }
}

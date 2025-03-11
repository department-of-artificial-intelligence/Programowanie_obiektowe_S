using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;

        public Student() { 
            _year = 0;
            _group = 0;
            _indexId = 0;

        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int year,
            int group, int indexId)
        { 
            _firstName = firstName;
            _lastName = lastName;  
            _dateOfBirth = dateOfBirth;
            _year = year;  
            _group = group;    
            _indexId = indexId;
               
        
        }
        public int Group
        {
            get { return _group; }
            set { _group = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public int IndexId
        {
            get { return _indexId; }
            set { _indexId = value; }
        }

        public override string ToString()
        {
            return $"Person | Imie: {_firstName}, Nazwisko: {_lastName}, Data_urodzenia {_dateOfBirth}, Rok: {_year}, Grupa: {_group}, IndexId: {_indexId}";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public int Group
        {
            get { return _group; }
            set { _group = value; }
        }
        public int IndexId
        {
            get { return _indexId; }
            set { _indexId = value; }
        }

        public Student()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
        }

    }

}

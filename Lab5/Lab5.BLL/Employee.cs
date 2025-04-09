using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class Employee : Animal
    {
        protected string _firstName;
        protected string _lastName;
        protected System.DateTime _dateOfBirth;
        protected System.DateTime _hireDate;
        protected IList<Cage> _cages;
    }
}
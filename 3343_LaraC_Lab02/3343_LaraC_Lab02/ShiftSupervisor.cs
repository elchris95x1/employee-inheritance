using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3343_LaraC_Lab02
{
    class ShiftSupervisor : EmployeeClass
    {
        private double _salary;
        private double _bonus;

        public ShiftSupervisor()
        {
            _salary = 0;
            _bonus = 0;
        }
        

        //Salary property
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        //Bonus property
        public double Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
    }
}

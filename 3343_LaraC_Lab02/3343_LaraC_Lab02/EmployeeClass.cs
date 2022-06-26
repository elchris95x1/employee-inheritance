using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3343_LaraC_Lab02
{
    abstract class EmployeeClass
    {
        // fields
        private string _name;
        private int _number;
        
        

        //constructor paramertless
        public EmployeeClass()
        {
            _name = "";
            _number = 0;
        }

        //constructor parameterized
        public EmployeeClass(string name, int number)
        {
            _name = name;
            _number = number;
        }



        //Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Number property
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        

    }
}

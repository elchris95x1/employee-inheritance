using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3343_LaraC_Lab02
{
    class ProductionWorker : EmployeeClass
    {
        private int _shift;
        private double _payRate;

        public ProductionWorker()
        {
            _shift = 0;
            _payRate = 0;
        }
        

        //Shift property
        public int Shift
        {
            get { return _shift; }
            set { _shift = value; }
        }

        //PayRate property
        public double PayRate
        {
            get { return _payRate; }
            set { _payRate = value; }
        }
    }
}

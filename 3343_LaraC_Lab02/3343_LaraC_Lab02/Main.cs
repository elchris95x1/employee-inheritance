//Christian Lara
//000983220
//3/2/2020
//3/2/2020
/*This application uses inheritence to manege the data of an employee, there are two types of employees maneged in this program:
 *Production worker, the production worker class inherits the variables from employee class, and it is used in the production worker form.
 *ShiftSupervisor, the shift supervisor class inherits the varables form the employee class, and it is used in the shift supervisor form.
 The employee class is an abtract class used as the base class.
 The program has data validation to prevent the program to crash when erroneus data is entered by the user.*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3343_LaraC_Lab02
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void productionWorkerButton_Click(object sender, EventArgs e)
        {
            //create an item of the production list form
            ProductionWorkerForm productionWorkerForm = new ProductionWorkerForm();
            productionWorkerForm.Show();
        }

        private void shiftSupervisorButton_Click(object sender, EventArgs e)
        {
            //create an item of the supervisor list form
            ShiftSupervisorForm supervisorForm = new ShiftSupervisorForm();
            supervisorForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

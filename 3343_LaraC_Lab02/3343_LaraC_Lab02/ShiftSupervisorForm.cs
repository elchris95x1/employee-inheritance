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
    public partial class ShiftSupervisorForm : Form
    {
        public ShiftSupervisorForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isNotBlank(nameTextbox, "Name") == true &&
                    isValidInt(numberTextbox, "Number") != -1 &&
                    isValidDouble(salaryTextBox, "Salary") != -1 &&
                    isValidDouble(bonusTextBox, "Bonus") != -1)
                {
                    //create an object of the employee class
                    ShiftSupervisor shiftSupervisor = new ShiftSupervisor();
                    shiftSupervisor.Name = nameTextbox.Text;
                    shiftSupervisor.Number = int.Parse(numberTextbox.Text);
                    shiftSupervisor.Salary = double.Parse(salaryTextBox.Text);
                    shiftSupervisor.Bonus = double.Parse(bonusTextBox.Text);


                    //Display Results
                    nameLabel.Text = shiftSupervisor.Name;
                    numberLabel.Text = shiftSupervisor.Number.ToString();
                    salaryLabel.Text = shiftSupervisor.Salary.ToString();
                    bonusLabel.Text = shiftSupervisor.Bonus.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Invalid input(s)");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextbox.Text = "";
            numberTextbox.Text = "";
            salaryTextBox.Text = "";
            bonusTextBox.Text = "";

            nameLabel.Text = "";
            numberLabel.Text = "";
            salaryLabel.Text = "";
            bonusLabel.Text = "";
            nameTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int isValidInt(Control ctrl, string controlName)
        {
            int output;
            if (int.TryParse(ctrl.Text, out output))
            {
                if (output > 0)
                {
                    //valid input
                    return output;
                }
                else
                {
                    MessageBox.Show(controlName + " must be grater than 0");
                    ctrl.Text = "";
                    ctrl.Focus();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show(controlName + " must be a whole number.");
                ctrl.Text = "";
                ctrl.Focus();
                return -1;
            }
        }

        private double isValidDouble(Control ctrl, string controlName)
        {
            double output;
            if (double.TryParse(ctrl.Text, out output))
            {
                if (output > 0)
                {
                    //valid input
                    return output;
                }
                else
                {
                    MessageBox.Show(controlName + " must be grater than 0");
                    ctrl.Text = "";
                    ctrl.Focus();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show(controlName + " must be a number.");
                ctrl.Text = "";
                ctrl.Focus();
                return -1;
            }
        }

        private bool isNotBlank(Control ctrl, string controlName)
        {
            if (ctrl.Text != "")
            {
                //valid input
                return true;
            }
            else
            {
                MessageBox.Show(controlName + " cannot be blank.");
                ctrl.Text = "";
                ctrl.Focus();
                return false;
            }
        }

    }
}

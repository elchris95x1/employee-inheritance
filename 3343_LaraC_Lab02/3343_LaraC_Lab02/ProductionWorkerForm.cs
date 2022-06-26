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
    public partial class ProductionWorkerForm : Form
    {
        public ProductionWorkerForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isNotBlank(nameTextbox, "Name") == true &&
                    isValidInt(numberTextbox, "Number") != -1 &&
                    isValidShift(shiftTextBox, "Shift") != -1 &&
                    isValidDouble(payRateTextBox, "Pay Rate") != -1)
                {
                    //create an object of the employee class
                    ProductionWorker productionWorker = new ProductionWorker();
                    productionWorker.Name = nameTextbox.Text;
                    productionWorker.Number = int.Parse(numberTextbox.Text);
                    productionWorker.Shift = int.Parse(shiftTextBox.Text);
                    productionWorker.PayRate = double.Parse(payRateTextBox.Text);


                    //Display Results
                    nameLabel.Text = productionWorker.Name;
                    numberLabel.Text = productionWorker.Number.ToString();
                    shiftLabel.Text = productionWorker.Shift.ToString();
                    payRateLabel.Text = productionWorker.PayRate.ToString();
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
            shiftTextBox.Text = "";
            payRateTextBox.Text = "";

            nameLabel.Text = "";
            numberLabel.Text = "";
            shiftLabel.Text = "";
            payRateLabel.Text = "";
            nameTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int isValidShift(Control ctrl, string controlName)
        {
            int output;
            if (int.TryParse(ctrl.Text, out output))
            {
                if (output >= 1 && output <= 2)
                {
                    //valid input
                    return output;
                }
                else
                {
                    MessageBox.Show(controlName + " must be a 1 or 2");
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

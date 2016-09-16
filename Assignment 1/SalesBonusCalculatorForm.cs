using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class SalesBonusCalculatorForm : Form
    {
        public SalesBonusCalculatorForm()
        {
            InitializeComponent();
        }

        //Variables
        const double TotalHoursWorked = 160;
        double HoursWorked;
        double TotalSales;


        /// <summary>
        /// Called when the form Loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Start up code
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Exit the application
            Application.Exit();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear the form
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //Pop up dialog informing user of the print job
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Calculate 
            //Verify all fields are correct values
            if (VerifyFields())
            {

            }
            //Verify Total Hours Worked does not exceed 160
            //
        }

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Change language to english
        }

        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //change language to french
        }

        /// <summary>
        /// Will verify every field at once for valid length and values
        /// </summary>
        /// <returns></returns>
        private Boolean VerifyFields()
        {
            if(EmployeeNameTextbox.TextLength == 0)
            {
                return false;
            }
            if(EmployeeIDTextbox.TextLength == 0)
            {
                if(EmployeeIDTextbox.GetType() == int)
                {

                }
                return false;
            }
            if(HoursWorkedTextbox.TextLength == 0)
            {
                return false;
            }else
            {
                try
                {
                    if (Convert.ToInt16(HoursWorkedTextbox.Text) > 160)
                    {
                        return false;
                    }
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);
                    MessageBox.Show("Invalid data entered", "Input Error");
                    HoursWorkedTextbox.Focus();
                    return false;
                }
            }
            if(TotalSalesTextbox.TextLength == 0)
            {
                return false;
            }

            return true;
        }
    }
}

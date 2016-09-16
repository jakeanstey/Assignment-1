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
        const double MaxTotalHoursWorked = 160;
        double HoursWorked;
        double TotalSales;
        string EmployeeName;
        int EmployeeID;


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
            if (VerifyAndAssignValues())
            {
                MessageBox.Show("Success","Success");
            }else
            {
                MessageBox.Show("Invalid data entry", "Input Error");
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
        private Boolean VerifyAndAssignValues()
        {
            if(EmployeeNameTextbox.TextLength == 0)
            {
                Debug.WriteLine("Employee name too short");
                return false;
            }

            EmployeeName = EmployeeNameTextbox.Text;

            if(EmployeeIDTextbox.TextLength > 0)
            {
                try
                {
                    EmployeeID = Convert.ToInt16(EmployeeIDTextbox.Text);
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception);
                    return false;
                }
            }else
            {
                Debug.WriteLine("EmployeeID is too short");
                return false;
            }

            if(HoursWorkedTextbox.TextLength > 0)
            {
                try
                {
                    if (Convert.ToInt16(HoursWorkedTextbox.Text) > MaxTotalHoursWorked)
                    {
                        Debug.WriteLine("Hours worked is greater than 160");
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
            else
            {
                Debug.WriteLine("Hours worked too short");
                return false;
            }

            HoursWorked = Convert.ToInt16(HoursWorkedTextbox.Text);

            if(TotalSalesTextbox.TextLength > 0)
            {
                try
                {
                    TotalSales = Convert.ToInt16(TotalSalesTextbox.Text);
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception);
                    return false;
                }
            }else
            {
                Debug.WriteLine("Total sales is empty");
                return false;
            }

            return true;
        }
    }
}

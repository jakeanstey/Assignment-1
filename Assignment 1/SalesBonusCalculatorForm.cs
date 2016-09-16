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
                EmployeeNameTextbox.Focus();
                InputError("Employee name must not be blank.");
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
                    FocusAndClear(EmployeeIDTextbox);
                    InputError("EmployeeID is not a number.");
                    return false;
                }
            }else
            {
                EmployeeIDTextbox.Focus();
                InputError("Employee ID must not be blank.");
                return false;
            }

            if(HoursWorkedTextbox.TextLength > 0)
            {
                try
                {
                    if (Convert.ToInt16(HoursWorkedTextbox.Text) > MaxTotalHoursWorked)
                    {
                        FocusAndClear(HoursWorkedTextbox);
                        InputError("Hours worked is greater than the limit: " + MaxTotalHoursWorked);
                        return false;
                    }
                }
                catch (Exception exception)
                {
                    FocusAndClear(HoursWorkedTextbox);
                    InputError("Hours worked field must be a number.");
                    return false;
                }
            }
            else
            {
                HoursWorkedTextbox.Focus();
                InputError("Hours worked must not be blank.");
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
                    FocusAndClear(TotalSalesTextbox);
                    InputError("Total sales must be a number.");
                    return false;
                }
            }else
            {
                TotalSalesTextbox.Focus();
                InputError("Total sales must not be blank.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Will set focus on the text box and set the value to 0
        /// </summary>
        /// <param name="box"></param>
        private void FocusAndClear(TextBox Box)
        {
            Box.Text = "0";
            Box.Focus();
            Box.SelectAll();
        }

        /// <summary>
        /// Easier way to show message dialog for Input Error(s)
        /// </summary>
        /// <param name="Message"></param>
        private void InputError(string Message)
        {
            MessageBox.Show(Message, "Input Error");
        }
    }
}

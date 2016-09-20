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

    public enum Language { English, French };
    public partial class MailOrderForm : Form
    {
        public MailOrderForm()
        {
            InitializeComponent();
        }

        //Variables
        private const double _MaxTotalHoursWorked = 160;
        private double _HoursWorked;
        private double _TotalSales;
        private string _EmployeeName;
        private int _EmployeeID;
        private double _SalesBonus;


        /// <summary>
        /// Called when the form Loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Start up code
            Language English;
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
                _SalesBonus = Calculate();
                SalesBonusTextbox.Text = _SalesBonus.ToString("C2");
            }
            //Verify Total Hours Worked does not exceed 160
            //
        }

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Change language to english
            ChangeLanguage("english");
        }

        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //change language to french
            ChangeLanguage("french");
        }

        private void ChangeLanguage(string Language)
        {
            if(Language == "french")
            {
                EmployeeNameLabel.Text = "Le nom de l'employé";
                HoursWorkedLabel.Text = "Heures travaillées";
                TotalSalesLabel.Text = "Ventes totales";
                SalesBonusLabel.Text = "Bonus de vente";
                CalculateButton.Text = "Calculer";
                PrintButton.Text = "Impression";
                ExitButton.Text = "Sortie";
                NextButton.Text = "Prochain";
                FrenchRadioButton.Text = "français";
                EnglishRadioButton.Text = "Anglais";
                LanguageGroupBox.Text = "La langue";
            }
            else if (Language == "english")
            {
                EmployeeNameLabel.Text = "Employee's Name";
                HoursWorkedLabel.Text = "Hours Worked";
                TotalSalesLabel.Text = "Total Sales";
                SalesBonusLabel.Text = "Sales Bonus";
                CalculateButton.Text = "Calculate";
                PrintButton.Text = "Print";
                ExitButton.Text = "Exit";
                NextButton.Text = "Next";
                FrenchRadioButton.Text = "French";
                EnglishRadioButton.Text = "English";
                LanguageGroupBox.Text = "Language";
            }
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

            _EmployeeName = EmployeeNameTextbox.Text;

            if(EmployeeIDTextbox.TextLength > 0)
            {
                try
                {
                    _EmployeeID = Convert.ToInt16(EmployeeIDTextbox.Text);
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
                    if (Convert.ToInt16(HoursWorkedTextbox.Text) > _MaxTotalHoursWorked)
                    {
                        FocusAndClear(HoursWorkedTextbox);
                        InputError("Hours worked is greater than the limit: " + _MaxTotalHoursWorked);
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

            _HoursWorked = Convert.ToInt16(HoursWorkedTextbox.Text);

            if(TotalSalesTextbox.TextLength > 0)
            {
                try
                {
                    _TotalSales = Convert.ToInt32(TotalSalesTextbox.Text);
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

        private double Calculate()
        {
            double PercentageOfHoursWorked = _HoursWorked / _MaxTotalHoursWorked;
            double TotalBonusAmount = _TotalSales * 0.02;
            return PercentageOfHoursWorked * TotalBonusAmount;
        }
    }
}

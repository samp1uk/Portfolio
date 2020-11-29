//Sohal Patel
//CIS-411-75-4202
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortgage_Calculator
{
    public partial class MortgageCalculator : Form
    {

        public MortgageCalculator()
        {
            InitializeComponent();
            //Preset values
            principalTxt.Text = $"{100000}";
            interestRateTxt.Text = $"{0.06}"; //This can be 6% or 0.06. Both value are evulated to make sure it doesn't affect the formula.
            monthsTxt.Text = $"{120}";
        }
        //Calls the MortgageLibrary.
        MortgageLibrary.Mortgage mortgageLoan = new MortgageLibrary.Mortgage();
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            //Make sure all the values are not string.
            if (double.TryParse(principalTxt.Text, out double principal) && double.TryParse(interestRateTxt.Text, out double interestRate) && int.TryParse(monthsTxt.Text, out int months))
            {
                //values are send to the Mortgagelibrary from the textbox.
                mortgageLoan.principal = principal;
                mortgageLoan.interestRate = interestRate;
                mortgageLoan.months = months;
                monthlyPaymentTxt.Text = $"{mortgageLoan.monthlyPayment:C}"; //value retured from the Mortgagelibrary.
                viewBtn.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Values. Values cannot be string.");
            }

        }

        //popup second form and send a data table to the class library to get the schedule. 
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            DataGridView temp = new DataGridView();
            Amortization_Schedule asv = new Amortization_Schedule(mortgageLoan.scheduleTable(temp), mortgageLoan.monthlyPayment, mortgageLoan.months, mortgageLoan.TotalPayment, mortgageLoan.TotalInterestPaid, mortgageLoan.PayOffDate);
            asv.ShowDialog();
        }

    }
}

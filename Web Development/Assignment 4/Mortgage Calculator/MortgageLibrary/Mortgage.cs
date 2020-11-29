//Sohal Patel
//CIS-411-75-4202
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageLibrary
{
    public class Mortgage
    {
        //private values for the property.
        private double _principal, _rate;
        private int _month;
        int hundred = 100;
        int rateDivide = 1200;
        //values from the form are stored to the property.
        public double principal { get { return _principal; } set { _principal = value; } }
        public double interestRate { get { return _rate; } set { _rate = value; } }
        public int months { get { return _month; } set { _month = value; } }
        //output property that will be called by the second form.
        public double TotalPayment { get { return totalPayment; } }
        public double TotalInterestPaid { get { return totalInterestPaid; } }
        public string PayOffDate { get { return payOffDate; } }
        //calulates the rate and checks if the value is decimal or an int. so if its 6 then its an int and if its 0.06 then its a decimal.
        public double rate
        {
            get
            {
                double rateCal;
                //Checks if the value is a decimal or an int.   
                if ((interestRate % 1) > 0)
                {
                    rateCal = (interestRate * hundred) / rateDivide;
                    return rateCal;
                }
                else
                {
                    rateCal = interestRate / rateDivide;
                    return rateCal;
                }
            }

        }
        //Calulation for montlypayment.
        public double monthlyPayment
        {
            get
            {
                double monthlyPaymentCal = (rate * principal) / (1 - Math.Pow(1 + rate, months * -1));
                return monthlyPaymentCal;
            }
        }
        //Final Cal variable for output textbox
        double totalPayment = 0;
        double totalInterestPaid = 0;
        string payOffDate = "";
        //Datatable to outputs schedule.
        public DataTable scheduleTable(DataGridView temp)
        {
            var view = new DataTable();
            //Arrays
            string[] dateArray = new string[months];
            double[] startBalance = new double[months];
            double[] youpaid = new double[months];
            double[] interest = new double[months];
            double[] principalPaid = new double[months];
            double[] endBalance = new double[months];
            double[] totalInterest = new double[months];

            for (int i = 0; i < dateArray.Length; i++)
            {
                //Date calulations and adding to array.
                string dates = DateTime.Today.AddMonths(i).ToString("MMM, yyyy");
                dateArray[i] += dates;

                //------------------------------------------------------------//
                //Starting Balance calulations and adding to array.
                double balance = 0;
                if (i >= 1)
                {
                    balance = endBalance[i - 1];
                }
                else
                {
                    balance = principal;
                }
                startBalance[i] += balance;

                //------------------------------------------------------------//
                //montly payments calulations and adding to array.

                double paid = monthlyPayment;
                youpaid[i] += paid;

                //------------------------------------------------------------//
                //Interest calulations and adding to array.

                double Rate = startBalance[i] * rate;
                interest[i] += Rate;

                //------------------------------------------------------------//
                //Principal Paid calulations and adding to array.

                double principalPay = youpaid[i] - interest[i];
                principalPaid[i] += principalPay;

                //------------------------------------------------------------//
                //Ending Balance calulations and adding to array.

                double endBal = startBalance[i] - principalPaid[i];
                endBalance[i] += endBal;

                //------------------------------------------------------------//
                //Total Interest calulations and adding to array.
                double totInterest = 0;
                if (i >= 1)
                {
                    totInterest = totalInterest[i - 1] + interest[i];
                }
                else
                {
                    totInterest = interest[i];
                }
                totalInterest[i] += totInterest;
                //------------------------------------------------------------//
            }

            for (int i = 0; i < dateArray.Length - 1; i++)
            {
                totalInterestPaid = totalInterest[i + 1];
                totalPayment = totalInterest[i + 1] + principal;
                payOffDate = dateArray[i + 1];
            }

            //data view title
            view.Columns.Add("Month");
            view.Columns.Add("Starting Balance");
            view.Columns.Add("You Paid");
            view.Columns.Add("Interest");
            view.Columns.Add("Principal");
            view.Columns.Add("Ending Balance");
            view.Columns.Add("Total Interest");

            //Add values to the data view for the schedule
            for (int i = 0; i < dateArray.Length; i++)
            {
                if (dateArray[i] != null)
                {
                    view.Rows.Add(new object[] { dateArray[i], startBalance[i].ToString("C"), youpaid[i].ToString("C"), interest[i].ToString("C"), principalPaid[i].ToString("C"), endBalance[i].ToString("C"), totalInterest[i].ToString("C") }); ;
                }
            }
            return view; //returns the table.
        }

    }

}



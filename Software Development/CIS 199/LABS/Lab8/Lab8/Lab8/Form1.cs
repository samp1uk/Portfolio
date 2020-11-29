//ID: M2564
//Lab: 87
//Class: CIS 199
//Course Section: 1
//Due Date: 03-31-19
//This program let user calculate how much money they need to put up in order to reach their desired value from amount of numYear.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    //Load the Form
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Event handler starts when the button is activated.
        private void calButton_Click(object sender, EventArgs e)
        {
            double money; //double value for money to use for output
            double future; //This store value of future value that the user input for "Future value" to be calculated.
            double interest; //This store value of interest value to be calculated.
            int year; //This store value of year the user inputs to be calculated.

            //Reads the input and stores the value to thier variables. 
            double.TryParse(futureTxt.Text, out future);
            int.TryParse(yearTxt.Text, out year);
            double.TryParse(intrestTxt.Text, out interest);

            //The money variable returns the calcuation that the "CalcPresentValue" method return and it also provides the stored variable to the argument given that correspond to the required formal parameter.    
            money = CalcPresentValue(future, interest, year);


            //output the value of money in currency.
            valueTxt.Text = $"{money:C}";
        }

        //precondition - the CalPresentValue is a double method and only works if the value are double or int. The variable of the argument given that correspond to the required formal parameter. 
        //postcondition - When all the parameter are meet for the method then the value are inputed to the equation and stored in the "p" variable. 
        public static double CalcPresentValue(double futureValue, double interestRate, int numYear)
        {
            double p; //use to store the final calculation
            //Calculation to find the Present value 
            p = (futureValue) / Math.Pow((1 + interestRate), numYear);
            return p; //end the method and return the value of the calculation
        }
    }
}

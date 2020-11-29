//ID: M2564
//Program: Program 2
//Class: CIS 199
//Course Section: 1
//Due Date: 03-05-19
//This program check user marriage status and their income to find which tax bracket they fall in for the 2019 tax year.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //This event handler is activated when the person click on the calculate button. 
        private void taxButton_Click(object sender, EventArgs e)
        {
            int income; //initialize income that will be used to store the user income input. 

            double pay = 0; //This variable will be used to store the value that needs to be displayed to show how much they owe.
            double marginal = 0; //This variable will have the value of how much they actually owe in percentage instead of their basic tax bracket 

            //Each bracket highest amount are given a variable. 
            const int single1 = 9700; //single1 = Highest amount for the first category in the single bracket 
            const int single2 = 39475; //single2 = Highest amount for the second category in the single bracket 
            const int single3 = 84200; //single3 = Highest amount for the third category in the single bracket 
            const int single4 = 160725; //single4 = Highest amount for the fourth category in the single bracket 
            const int single5 = 204100; //single5 = Highest amount for the fifth category in the single bracket 
            const int single6 = 510300; //single6 = Highest amount for the sixth category in the single bracket 

            const int mFJ1 = 19400; // mFJ1 = Highest amount for the first category in the Married Filing Jointly bracket 
            const int mFJ2 = 78950; // mFJ2 = Highest amount for the second category in the Married Filing Jointly bracket 
            const int mFJ3 = 168400; // mFJ3 = Highest amount for the third category in the Married Filing Jointly bracket 
            const int mFJ4 = 321450; // mFJ4 = Highest amount for the fourth category in the Married Filing Jointly bracket 
            const int mFJ5 = 408200; // mFJ5 = Highest amount for the fifth category in the Married Filing Jointly bracket 
            const int mFJ6 = 612350; // mFJ6 = Highest amount for the sixth category in the Filing Jointly bracket 

            const int hOH1 = 13850; // hOH1 = Highest amount for the first category in the Head of Household bracket 
            const int hOH2 = 52850; // hOH2 = Highest amount for the second category in the Head of Household bracket 
            const int hOH3 = 84200; // hOH3 = Highest amount for the third category in the Head of Household bracket 
            const int hOH4 = 160700; // hOH4 = Highest amount for the fourth category in the Head of Household bracket 
            const int hOH5 = 204100; // hOH5 = Highest amount for the fifth category in the Head of Household bracket 
            const int hOH6 = 510300; // hOH6 = Highest amount for the sixth category in the Head of Household bracket 

            const int mFS1 = 9700; // mFS1 = Highest amount for the first category in the Married Filing Separately bracket 
            const int mFS2 = 39475; // mFS2 = Highest amount for the second category in the Married Filing Separately bracket 
            const int mFS3 = 84200; // mFS3 = Highest amount for the third category in the Married Filing Separately bracket 
            const int mFS4 = 160725; // mFS4 = Highest amount for the fourth category in the Married Filing Separately bracket 
            const int mFS5 = 204100; // mFS5 = Highest amount for the fifth category in the Married Filing Separately bracket 
            const int mFS6 = 306175; // mFS6 = Highest amount for the sixth category in the Married Filing Separately bracket 

            //percent variable given for each bracket. Percent start from the lower bracket to higher bracket.
            const double percent1 = 0.10; //The percentage for the first bracket that the tax income would fall in.
            const double percent2 = 0.12; //The percentage for the second bracket that the tax income would fall in.
            const double percent3 = 0.22; //The percentage for the third bracket that the tax income would fall in.
            const double percent4 = 0.24; //The percentage for the fourth bracket that the tax income would fall in.
            const double percent5 = 0.32; //The percentage for the fifth bracket that the tax income would fall in.
            const double percent6 = 0.35; //The percentage for the sixth bracket that the tax income would fall in.
            const double percent7 = 0.37; //The percentage for the seventh bracket that the tax income would fall in.


            //There is no "bracket1" because bracket1 will not be needed for the calcaution for the first bracket witch is ten percent.
            double bracket2; //This variable will be used to calculate how much they actually owe if they fall in the tweleve percent bracket
            double bracket3; //This variable will be used to calculate how much they actually owe if they fall in the twenty wo percent bracket
            double bracket4; //This variable will be used to calculate how much they actually owe if they fall in the twenty four percent bracket
            double bracket5; //This variable will be used to calculate how much they actually owe if they fall in the thirty two percent bracket
            double bracket6; //This variable will be used to calculate how much they actually owe if they fall in the thirty five percent bracket
            double bracket7; //This variable will be used to calculate how much they actually owe if they fall in the thirty seven percent bracket

            //single bracket calculation for each bracket. Each bracket main cost that can be added for the final "pay" variable.
            double singleCal1 = (single1) * percent1;                        
            double singleCal2 = (single2 - single1) * percent2;           
            double singleCal3 = (single3 - single2) * percent3;             
            double singleCal4 = (single4 - single3) * percent4;                 
            double singleCal5 = (single5 - single4) * percent5;
            double singleCal6 = (single6 - single5) * percent6;

            //Married Filing Jointly bracket calculation for each bracket. Each bracket main cost that can be added for the final "pay" variable.
            double mFJCal1 = (mFJ1) * percent1;
            double mFJCal2 = (mFJ2 - mFJ1) * percent2;
            double mFJCal3 = (mFJ3 - mFJ2) * percent3;
            double mFJCal4 = (mFJ4 - mFJ3) * percent4;
            double mFJCal5 = (mFJ5 - mFJ4) * percent5;
            double mFJCal6 = (mFJ6 - mFJ5) * percent6;

            //Head of Household bracket calculation for each bracket. Each bracket main cost that can be added for the final "pay" variable.
            double hOHCal1 = (hOH1) * percent1;
            double hOHCal2 = (hOH2 - hOH1) * percent2;
            double hOHCal3 = (hOH3 - hOH2) * percent3;
            double hOHCal4 = (hOH4 - hOH3) * percent4;
            double hOHCal5 = (hOH5 - hOH4) * percent5;
            double hOHCal6 = (hOH6 - hOH5) * percent6;

            //Married Filing Separately bracket calculation for each bracket. Each bracket main cost that can be added for the final "pay" variable.
            double mFSCal1 = (mFS1) * percent1;
            double mFSCal2 = (mFS2 - mFS1) * percent2;
            double mFSCal3 = (mFS3 - mFS2) * percent3;
            double mFSCal4 = (mFS4 - mFS3) * percent4;
            double mFSCal5 = (mFS5 - mFS4) * percent5;
            double mFSCal6 = (mFS6 - mFS5) * percent6;      
            
            //Reads the amount to income variable and the if stsatements check which category they are in and calculate how much they owe. 
            if (int.TryParse(incomeTxt.Text, out income))
            {
                if (singleRadio.Checked)
                {
                    //single bracket calculation for each bracket depending on thier income and assign what bracket they are in.
                    if (income <= single1)
                    {
                        pay = income * percent1;
                        marginal = percent1;
                    }
                    else
                    if (income <= single2)
                    {
                        bracket2 = (income - single1) * percent2;
                        pay = bracket2 + singleCal1;
                        marginal = percent2;
                    }
                    else
                    if (income <= single3)
                    {
                        bracket3 = (income - single2) * percent3;
                        pay = bracket3 + singleCal1 + singleCal2;
                        marginal = percent3;
                     }
                    else
                    if (income <= single4)
                    {
                        bracket4 = (income - single3) * percent4;
                        pay = bracket4 + singleCal1 + singleCal2 + singleCal3;
                        marginal = percent4;
                    }
                    else
                    if (income <= single5)
                    {
                        bracket5 = (income - single4) * percent5;
                        pay = bracket5 + singleCal1 + singleCal2 + singleCal3 + singleCal4;
                        marginal = percent5;
                    }
                    else
                    if (income <= single6)
                    {
                        bracket6 = (income - single5) * percent6;
                        pay = bracket6 + singleCal1 + singleCal2 + singleCal3 + singleCal4 + singleCal5;
                        marginal = percent6;
                    }
                    else
                    if (income > single6)
                    {
                        bracket7 = (income - single6) * percent7;
                        pay = bracket7 + singleCal1 + singleCal2 + singleCal3 + singleCal4 + singleCal5 + singleCal6;
                        marginal = percent7;
                    }
                }
                else
                //Married Filing Jointly bracket calculation for each bracket depending on thier income and assign what bracket they are in.
                if (marriedFilingJointlyRadio.Checked)
                {
                    if (income <= mFJ1)
                    {
                        pay = income * percent1;
                        marginal = percent1;
                    }
                    else
                    if (income <= mFJ2)
                    {
                        bracket2 = (income - mFJ1) * percent2;
                        pay = bracket2 + mFJCal1;
                        marginal = percent2;
                    }
                    else
                    if (income <= mFJ3)
                    {
                        bracket3 = (income - mFJ2) * percent3;
                        pay = bracket3 + mFJCal1 + mFJCal2;
                        marginal = percent3;
                    }
                    else
                    if (income <= mFJ4)
                    {
                        bracket4 = (income - mFJ3) * percent4;
                        pay = bracket4 + mFJCal1 + mFJCal2 + mFJCal3;
                        marginal = percent4;
                    }
                    else
                    if (income <= mFJ5)
                    {
                        bracket5 = (income - mFJ4) * percent5;
                        pay = bracket5 + mFJCal1 + mFJCal2 + mFJCal3 + mFJCal4;
                        marginal = percent5;
                    }
                    else
                    if (income <= mFJ6)
                    {
                        bracket6 = (income - mFJ5) * percent6;
                        pay = bracket6 + mFJCal1 + mFJCal2 + mFJCal3 + mFJCal4 + mFJCal5;
                        marginal = percent6;
                    }
                    else
                    if (income > mFJ6)
                    {
                        bracket7 = (income - mFJ6) * percent7;
                        pay = bracket7 + mFJCal1 + mFJCal2 + mFJCal3 + mFJCal4 + mFJCal5 + mFJCal6;
                        marginal = percent7;
                    }
                }
                else
                if (headOfHouseholdRadio.Checked)
                {
                    //Head of Household bracket calculation for each bracket depending on thier income and assign what bracket they are in.
                    if (income <= hOH1)
                    {
                        pay = income * percent1;
                        marginal = percent1;
                    }
                    else
                   if (income <= hOH2)
                    {
                        bracket2 = (income - hOH1) * percent2;
                        pay = bracket2 + hOHCal1;
                        marginal = percent2;
                    }
                    else
                    if (income <= hOH3)
                    {
                        bracket3 = (income - hOH2) * percent3;
                        pay = bracket3 + hOHCal1 + hOHCal2;
                        marginal = percent3;
                    }
                    else
                    if (income <= hOH4)
                    {
                        bracket4 = (income - hOH3) * percent4;
                        pay = bracket4 + hOHCal1 + hOHCal2 + hOHCal3;
                        marginal = percent4;
                    }
                    else
                    if (income <= hOH5)
                    {
                        bracket5 = (income - hOH4) * percent5;
                        pay = bracket5 + hOHCal1 + hOHCal2 + hOHCal3 + hOHCal4;
                        marginal = percent5;
                    }
                    else
                    if (income <= hOH6)
                    {
                        bracket6 = (income - hOH5) * percent6;
                        pay = bracket6 + hOHCal1 + hOHCal2 + hOHCal3 + hOHCal4 + hOHCal5;
                        marginal = percent6;
                    }
                    else
                    if (income > hOH6)
                    {
                        bracket7 = (income - hOH6) * percent7;
                        pay = bracket7 + hOHCal1 + hOHCal2 + hOHCal3 + hOHCal4 + hOHCal5 + hOHCal6;
                        marginal = percent7;
                    }
                }
                else
                if (marriedFilingSeparatelyRadio.Checked)
                {
                    //Married Filing Separately bracket calculation for each bracket depending on thier income and assign what bracket they are in.
                    if (income <= mFS1)
                    {
                        pay = income * percent1;
                        marginal = percent1;
                    }
                    else
                    if (income <= mFS2)
                    {
                        bracket2 = (income - mFS1) * percent2;
                        pay = bracket2 + mFSCal1;
                        marginal = percent2;
                    }
                    else
                    if (income <= mFS3)
                    {
                        bracket3 = (income - mFS2) * percent3;
                        pay = bracket3 + mFSCal1 + mFSCal2;
                        marginal = percent3;
                    }
                    else
                    if (income <= mFS4)
                    {
                        bracket4 = (income - mFS3) * percent4;
                        pay = bracket4 + mFSCal1 + mFSCal2 + mFSCal3;
                        marginal = percent4;
                    }
                    else
                    if (income <= mFS5)
                    {
                        bracket5 = (income - mFS4) * percent5;
                        pay = bracket5 + mFSCal1 + mFSCal2 + mFSCal3 + mFSCal4;
                        marginal = percent5;
                    }
                    else
                    if (income <= mFS6)
                    {
                        bracket6 = (income - mFS5) * percent6;
                        pay = bracket6 + mFSCal1 + mFSCal2 + mFSCal3 + mFSCal4 + mFSCal5;
                        marginal = percent6;
                    }
                    else
                    if (income > mFS6)
                    {
                        bracket7 = (income - mFS6) * percent7;
                        pay = bracket7 + mFSCal1 + mFSCal2 + mFSCal3 + mFSCal4 + mFSCal5 + mFSCal6;
                        marginal = percent7;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Amount!"); //shows message if they enter anything but number or leave it blank.
            }

            //Outputs that calcuation to the textbox and to the label
            amountBox.Text = $"{pay:C}";
            outputlabel.Text = $"You are in the {marginal:P0} marginal tax rate.";
           
        }

    //This event handler is activated when the person click on the clear button. 
    private void clearButton_Click(object sender, EventArgs e)
        {
            //The text, label and radio button get cleared and unselected. 
            incomeTxt.Clear();
            outputlabel.Text = "";
            amountBox.Clear();
            singleRadio.Checked = true;
            marriedFilingJointlyRadio.Checked = false;
            headOfHouseholdRadio.Checked = false;
            marriedFilingSeparatelyRadio.Checked = false;
        }
    }
}

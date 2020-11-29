//ID: M2564
//Lab: Lab 4
//Class: CIS 199-01
//Due Date: 02-17-19
//This program check if the applicants are accepted or rejected into the school. It also keeps count on how many are accepted and rejected.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4 : Form
    {
        //Sets all the total counts as a value of 0, which allows the click event to increase 0 by 1 each time when the criteria is met. 
        int acceptedCount = 0;
        int rejectedCount = 0;
        bool accepted = false;


        public Lab4()
        {
            InitializeComponent();
        }

        //This event handler is activated when the user clicks on qualification button.
        private void qualificationbutton_Click(object sender, EventArgs e)
        {
            //This If statement make sure any value is not left empty and if it is then it gives them an error to show them what they need to do.
            if (gpatxt.Text.Trim() == string.Empty || testtxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter a valid Test Score and GPA");
                return; // return because we don't want to run the normal code when the string is empty. 
            }

            const double minimumgpa = 3.0; //The gpa requirement
            const double minimumscore = 60; //The lowest score to be accepted if gpa is 3.0 or higher
            const double maxscore = 80; //The highest score to be accepted if gpa is less then 3.0
            int score; // The score recieved on admissions test
            float gpa; // The gpa recieved from their high school 

            //Input
            //takes user input as variables to later be input into if statement
            if (float.TryParse(gpatxt.Text, out gpa) && (gpa >= 0))
            {
                if (int.TryParse(testtxt.Text, out score) && (score >= 0))
                {
                    //IF statement to determine admission acceptance or rejection based on user input test scores and gpa
                    if ((gpa >= minimumgpa && score >= minimumscore) || (gpa <= minimumgpa && score >= maxscore))
                    {
                        Admissiontxt.Text = "Accept"; //Shows text if the if statement is true.
                        accepted = true;
                    }
                    else
                    {
                        Admissiontxt2.Text = "Reject"; //Shows text if the if statement is false
                        accepted = false;
                    }
                    // Running total of accepted and rejected applicants
                    if (accepted)
                    {
                        acceptedCount++;
                        accepttxt.Text = acceptedCount.ToString();
                    }
                    else
                    {
                        rejectedCount++;
                        rejecttxt.Text = rejectedCount.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid Test Score");
                }

            }
            else
            {
                MessageBox.Show("Enter a valid GPA");
            }
        }

        //This event handler is activated when the user clicks on clear
        private void Clearbutton_Click(object sender, EventArgs e)
        {
            //This clear all text box except the total count textbox
            gpatxt.Clear(); 
            testtxt.Clear();
            Admissiontxt.Text = string.Empty;
            Admissiontxt2.Text = string.Empty;
        }
    }
}

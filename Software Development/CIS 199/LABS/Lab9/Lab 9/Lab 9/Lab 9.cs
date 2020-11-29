//ID: M2564
//Lab: 9
//Class: CIS 199
//Course Section: 1
//Due Date: 04-21-19
//This program let user update the display date to the user requirement. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Form1 : Form
    {
        // Sets default date to January 1st, 2000
        private Date defaultDate = new Date(1, 1, 2000);

        public Form1()
        {
            InitializeComponent();
        }

        // Precondition: Valid month, day, or year must be entered in respected text box, and button is pushed
        // Postcondition: Date Label will be updated
        private void Form1_Load(object sender, EventArgs e)
        {
            dateOutputTxt.Text = defaultDate.ToString();
        }

        // Precondition: Int value entered in monthTxt
        // Postcondition: User input is sent through Date class
        private void monthButton_Click(object sender, EventArgs e)
        {
            int month;
            if (int.TryParse(monthInputTxt.Text, out month))
            {
                defaultDate.Month = month;
                dateOutputTxt.Text = defaultDate.ToString();
            }
            else // Displays message is valid integer isn't entered
            {
                MessageBox.Show("Enter a valid month.");
            }
        }

        // Precondition: Int value entered in datTxt
        // Postcondition: User input is sent through Date class
        private void dayButton_Click(object sender, EventArgs e)
        {
            int day;
            if (int.TryParse(dayInputTxt.Text, out day))
            {
                defaultDate.Day = day;
                dateOutputTxt.Text = defaultDate.ToString();
            }
            else // Displays message is valid integer isn't entered
            {
                MessageBox.Show("Enter a valid Day.");
            }
        }

        // Precondition: Int value entered in yearTxt
        // Postcondition: User input is sent through Date class
        private void yearButton_Click(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse(yearInputTxt.Text, out year))
            {
                defaultDate.Year = year;
                dateOutputTxt.Text = defaultDate.ToString();
            }
            else // Displays message is valid integer isn't entered
            {
                MessageBox.Show("Enter a valid month.");
            }
        }

        
    }
}

//ID: M2564
//Lab: Lab 2
//Class: CIS 199-01
//Due Date: 02-03-19
//This program is about how to calcuate the tip from the amount you like to give 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price, fifteen, eighteen, twenty; // This line is to initialize these variable that will be used later on.

            price = double.Parse(mealtext.Text); // This give the price variable to be assigned what the user inputs in the mealtext box.
            fifteen = 0.15 * price; // the fifteen variable is then multipled by fifteen percent from the input that the user did for "price".
            fifteentext.Text = $"{fifteen:C}"; // The text box that is assigned for displaying 15% of the value that is given from the value of "fifteen" to be displayed in that specific text box and it also is being converted to currency.
            eighteen = 0.18 * price; //The eighteen variable is then multipled by eighteen percent from the input that the user did for "price".
            eighteentext.Text = $"{eighteen:C}"; // The text box that is assigned for displaying 18% of the value that is given from the value of "eighteen" to be displayed in that specific text box and it also is being converted to currency.
            twenty = 0.20 * price; // The twenty variable is then multipled by twenty percent from the input that the user did for "price".
            twentytext.Text = $"{twenty:C}"; // The text box that is assigned for displaying 20% of the value that is given from the value of "twenty" to be displayed in that specific text box and it also is being converted to currency.
        }
    }
}

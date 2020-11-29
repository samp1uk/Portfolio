//ID: M2564
//Lab: 7
//Class: CIS 199
//Course Section: 1
//Due Date: 03-24-19
//This program takes the number the user input based on thier typed speed and gives them a grade they deserve for that speed amount.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Event start when they click on the button to check their grade. 
        private void checkButton_Click(object sender, EventArgs e)
        {
            int[] speedNumber = {0, 16, 31, 51, 76 }; //This array has the value of the lower limit of the words typed per minute 
            String[] grade = {"F", "D", "C", "B", "A"}; //This array has the string value of grades that earned based on the lower limit.
            bool found = false; //boolean statement to check if the number is found.
            int input; //The "input" variable is stored the user value they have inputed.

            //Check if the input is number or it gives an error message
            if (int.TryParse(inputTxt.Text, out input))
            {
                int index = speedNumber.Length - 1; //the index variable starts from the last array.

                while (index >= 0 && !found) //while loop to indexing until the value is not found
                {
                    if (input >= speedNumber[index]) //checks the lower limit array and the user input. If the value is found then the loop ends. else the indexing is continuted.
                    {
                        found = true;
                    }
                    else
                    {
                        --index;
                    }
                }

                //when the boolean is true then the text box is outputed the grade subscript array.
                if (found)
                {
                    gradeTxt.Text = $"{grade[index]}";
                }
            }
            else
            MessageBox.Show("Please Input A Valid Number!");
        }
    }
}

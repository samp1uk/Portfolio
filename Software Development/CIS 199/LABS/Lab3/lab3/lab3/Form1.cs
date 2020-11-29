//ID: M2564
//Lab: Lab 3
//Class: CIS 199-01
//Due Date: 02-10-19
//This program takes the radius and converst it into three different values: "Diameter", "Surface Area", and "Volume".
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This event handler get turned on when the person click on the calcuate button. 
        private void calbutton_Click(object sender, EventArgs e)
        {
            double d, a, v, value; //This activate the variables that will be used for the calcutation.

            value = double.Parse(spherevalue.Text); //This takes what value that person inputs and that value is stored for the "value" variable.
            d = 2 * value; //This thake the "value" variable and multiple it 2 times and stores that answer to the "d" variable.
            diameteroutput.Text = $"{d:F2}"; //This outputs the value that is stored for the "d" variable and the decimale is floated 2 places.
            a = 4 * Math.PI * value * value; //This thake the "value" variable and is multiplied by 4 and π and the "value" is squared. That answer is stored for the "a" variable.
            areaoutput.Text = $"{a:F2}"; //This outputs the value that is stored for the "a" variable and the decimale is floated 2 places.
            v = 4 * Math.PI * Math.Pow(value, 3) / 3; //This thake the "value" variable and multiple by 4 and π and the "value" is cubed then that answer is divided by 3. That answer is stored in the "d" variable.
            volumeoutput.Text = $"{v:F2}"; //This outputs the value that is stored for the "v" variable and the decimale is floated 2 places.

        }
    }
}

//ID: M2564
//Program: Program 1
//Class: CIS 199-01
//Due Date: 02-12-19
//This program takes your house measurements information and show you how much it will cost to have the carpet installed. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Program1 : Form

    {
        public Program1()
        {
            InitializeComponent();
        }

        //The program event handler is activated when the user clicks on the calculate button.
        private void button1_Click(object sender, EventArgs e)
        {
            //This If statement make sure any value is not left empty and if it is then it gives them an error to show them what they need to do.
            if (widthbox.Text.Trim() == string.Empty || lengthbox.Text.Trim() == string.Empty || carpetpricebox.Text.Trim() == string.Empty || paddingbox.Text.Trim() == string.Empty || firstroombox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter all your measurement and options to be able to calculate the total carpet installation!");
                return; // return because we don't want to run the normal code when the buton clicked
            }
            /*  ____________________________________________________________________________________________________________
                |                                                    legends:                                               |
                |-----------------------------------------------------------------------------------------------------------|
                | YN = Yards Needed                      |  PC = Padding Cost   LC = Labor Cost  | TC = Total Cost          |
                | wasteCC = 10% waste of Carpet Cost     |  wastePC = 10% waste of Padding Cost  | WR = Width of Rooms      |
                | LR = Length of Rooms                   |  CP = Carpet Price                    | LP = Layer of Padding    |                 
                | FR = First Room                        |  CC = Carpet Cost                     | padding = 2.75           |
                | baselaborprice = 4.50                  |  squareyard = 9                       | waste = 0.10             |
                |-----------------------------------------------------------------------------------------------------------|
                | laborextra = Checks if it the first floor or not and will they be charged or not                          |
                | pad = If user select 2 the padding is multiplied by 2 or if they select 1 the price remains the same      |  
                ‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾    */
            double YN, CC, PC, LC, TC, wasteCC, wastePC, WR, LR, CP, pad, laborextra; //These variables are activated
            int LP, FR;                                                               //These variables are initialized

            //The variable is given a value that is consistent
            const double waste = 0.10;                                                
            const double padding = 2.75;
            const double baselaborprice = 4.50;
            const int squareyard = 9;


            //input
            //The variable is given a value that the user inputs from the TextBox and stored in the system to calculate for Output
            WR = double.Parse(widthbox.Text);
            LR = double.Parse(lengthbox.Text);
            CP = double.Parse(carpetpricebox.Text);
            LP = int.Parse(paddingbox.Text);
            FR = int.Parse(firstroombox.Text);

            //If Statements
            //Check if the layer padding value is 1 or 2. If any other number that is input, it will give them an instruction message
            if (LP > 2 || LP == 0)
            {
                MessageBox.Show("Please enter only '1' or '2' value for the padding.");
            }

            //Check if the Floor Room value is 1 or 2. If any other number that is input, it will give them an instruction message
            if (FR > 1)
            {
                MessageBox.Show("Please enter '1' if this is your first room or '0' if this is your second room.");
            }

            /*This IF statement checks if the layer of padding is 1 then the variable "pad" is given the value of "padding." 
            If the value is 2 then the variable "padding is multiplied by Two and then the value for "pad" is stored the multiplied value. */
            if (LP > 1)
            {
                pad = padding * 2;
            }
            else
            {
                pad = padding;
            }

            /*This IF statement checks if Floor Room value is 1 or 0. If the value is "1" then the "laborextra" is given the value of 100.
             If the value is "0" then the value of "laborextra" is 0 */
            if (FR > 0)
            {
                laborextra = 100;
            }
            else
            {
                laborextra = 0;
            }

            /* ____________________________________________________________________________________________________________
               |                                                    legends:                                               |
               |-----------------------------------------------------------------------------------------------------------|
               | YN = Yards Needed                      |  PC = Padding Cost   LC = Labor Cost  | TC = Total Cost          |
               | wasteCC = 10% waste of Carpet Cost     |  wastePC = 10% waste of Padding Cost  | WR = Width of Rooms      |
               | LR = Length of Rooms                   |  CP = Carpet Price                    | LP = Layer of Padding    |                 
               | FR = First Room                        |  CC = Carpet Cost                     | padding = 2.75           |
               | baselaborprice = 4.50                  |  squareyard = 9                       | waste = 0.10             |
               |-----------------------------------------------------------------------------------------------------------|
               | laborextra = Checks if it the first floor or not and will they be charged or not                          |
               | pad = If user select 2 the padding is multiplied by 2 or if they select 1 the price remains the same      |  
               ‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾    */
            //calculations
            //Use the legend to understand the calculation formulas
            YN = WR * LR / squareyard;
            wasteCC = YN * CP * waste;
            CC = YN * CP + wasteCC;
            wastePC = YN * pad * waste;
            PC = YN * pad + wastePC;
            LC = YN * baselaborprice + laborextra;
            TC = CC + PC + LC;

            //output
            //The calculations are output to their respected TextBox 
            yardsneeded.Text = $"{YN:F1}";  //The value is one decimal precision
            costofcarpet.Text = $"{CC:C}";  //The value is outputed in currency
            costofpadding.Text = $"{PC:C}"; //The value is outputed in currency
            costoflabor.Text = $"{LC:C}";   //The value is outputed in currency
            totalcost.Text = $"{TC:C}";     //The value is outputed in currency


        }

        //This program event handler is activated when the user clicks on the clear button.
        private void clearbutton_Click(object sender, EventArgs e)
        {
            /*This program looks into the form controls and clears all the TextBox when the user click on the clear button. 
            The foreach function looks for each TextBox and clear them. */
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    { 
                    (control as TextBox).Clear();
                    }
                }
             };
             func(Controls);

        }
    }
}

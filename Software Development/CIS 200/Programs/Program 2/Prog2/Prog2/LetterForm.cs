// Program 2
// CIS 200-01
// Fall 2019
// Due: 10/21/2019
// By: M3838

// File: LetterForm.cs

// Holds the letter form class. You will be able to add previously stored origin address and desitination address with the fixed cost to letter. You will also need to enter a fixed cost.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class LetterForm : Form
    {
        //Precondition: Must have address list.
        //Postcondition: Constructs the letter form and populates the combo boxes with names from addresses.
        public LetterForm(List<Address> AddressList)
        {
            InitializeComponent();

            foreach (Address item in AddressList)
            {
                originCombo.Items.Add(item.Name);
                destCombo.Items.Add(item.Name);
            }
        }

        //Precondition: None
        //Postcondition: The letter form is closed.
        private void cancelLetterButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Precondition: Must select an origin address and origin and destination can not be the same.
        //Postcondition: Provides correct error message on error provider.
        private void originCombo_Validating(object sender, CancelEventArgs e)
        {
            if (originCombo.SelectedIndex < 0)
            {
                e.Cancel = true;
                originCombo.Focus();
                originErrorProvider.SetError(originCombo, "Must select an origin address.");
            }
           
        }

        //Precondition: None
        //Postcondition: Error is cleared and origin combo is validated.
        private void originCombo_Validated(object sender, EventArgs e)
        {
            originErrorProvider.SetError(originCombo, "");
        }

        //Precondition: Must select a destination address. Destination address and origin address can not be the same.
        //Postcondition: Correct error message is provided on destErrorProvider.
        private void destCombo_Validating(object sender, CancelEventArgs e)
        {
            if (destCombo.SelectedIndex < 0)
            {
                e.Cancel = true;
                destCombo.Focus();
                destErrorProvider.SetError(destCombo, "Must select an Destination address.");
            }
            else if (originCombo.SelectedIndex == destCombo.SelectedIndex)
            {
                e.Cancel = true;
                destCombo.Focus();
                destErrorProvider.SetError(destCombo, "Origin and destination address can not be the same.");
            }
        }

        //Precondition: None
        //Postcondition: Error message is cleared and destination address is validated.
        private void destCombo_Validated(object sender, EventArgs e)
        {
            destErrorProvider.SetError(destCombo, "");
        }

        //Precondition: Fixed cost must parse into decimal and be greater than or equal to zero.
        //Postcondition: If not correct error message is shown on error provider.
        private void fixedCostTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal number; //Variable to hold fixed cost

            if (!decimal.TryParse(fixedCostTextBox.Text, out number))
            {
                e.Cancel = true;
                fixedCostTextBox.SelectAll();
                costErrorProvider.SetError(fixedCostTextBox, "Please enter a valid cost.");
            }
            else if (number < 0)
            {
                e.Cancel = true;
                fixedCostTextBox.SelectAll();
                costErrorProvider.SetError(fixedCostTextBox, "Fixed cost must be greater than or equal to zero.");
            }
        }

        //Precondition: None
        //Postcondition: Error message is cleared and fixed cost is validated.
        private void fixedCostTextBox_Validated(object sender, EventArgs e)
        {
            costErrorProvider.SetError(fixedCostTextBox, "");
        }

        //Precondition: None
        //Postcondition: Origin address is returned or set to the value
        public int OriginIndex
        {
            //Precondition: None
            //Postcondition: Origin Address is returned.
            get { return originCombo.SelectedIndex; }

            //Precondition: None
            //Postcondition: Origin Address is set to value.
            set { originCombo.SelectedIndex = value; }

        }

        //Precondition: None
        //Postcondition: Destination Address is returned or set to value.
        public int DestIndex
        {
            //Precondition: None
            //Postcondition: Destination Address is returned
            get { return destCombo.SelectedIndex; }

            //Precondition: None
            //Postcondition: Destination address is set to value
            set { destCombo.SelectedIndex = value; }
        }

        //Precondition: None
        //Postcondition: Fixed cost is returned or set to value.
        public string LetterFixedCost
        {
            //Precondition: None
            //Postcondition: Fixed cost is returned
            get { return fixedCostTextBox.Text; }

            //Precondition: None
            //Postcondition: Fixed cost is set to value.
            set { fixedCostTextBox.Text = value; }
        }

        //Precondition: All error providers must be validated.
        //Postcondition: Dialog box closes.
        private void addLetterButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void LetterForm_Load(object sender, EventArgs e)
        {

        }
    }
}

// Program 2
// CIS 200-01
// Fall 2019
// Due: 10/21/2019
// By: M3838

// File: AddressForm.cs
//Users will be able to add in a custom address using this Address form. Validation is enforced so Name, Address One, City, State and Zip Code are mandatory to save an address while Address Two is optional.

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
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }
        const int MIN_ZIP = 00000;
        const int MAX_ZIP = 99999;

        private void AddressForm_Load(object sender, EventArgs e)
        {
            //Populate state combobox
            stateCombo.Items.Add("KY");
            stateCombo.Items.Add("FL");
            stateCombo.Items.Add("CA");
            stateCombo.Items.Add("PA");
        }
        //Precondition: Name text box can not be null or empty.
        //Postcondition: Error message is displayed if textbox is empty.
        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            //Name validation
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                e.Cancel = true;
                nameTextBox.Focus();
                nameErrorProvider.SetError(nameTextBox, "Name can not be blank.");
                nameTextBox.SelectAll();
            }
        }

        //Precondition: None
        //Postcondition: Error provider is cleared and name is validated.
        private void nameTextBox_Validated(object sender, EventArgs e)
        {
            nameErrorProvider.SetError(nameTextBox, "");
        }

        //Precondition: Address 1 can not be null of empty.
        //Postcondition: Correct error is displayed if error is required
        private void address1TextBox_Validating(object sender, CancelEventArgs e)
        {
            //Address validation
            if (string.IsNullOrEmpty(address1TextBox.Text) || string.IsNullOrWhiteSpace(address1TextBox.Text))
            {
                e.Cancel = true;
                address1TextBox.Focus();
                addressErrorProvider.SetError(address1TextBox, "Address can not be blank.");
                address1TextBox.SelectAll();   
            }
        }

        //Precondition: None
        //Poscondition: Address1 error is cleared and address is validated
        private void address1TextBox_Validated(object sender, EventArgs e)
        {
            addressErrorProvider.SetError(address1TextBox, "");
        }

        //Precondition: city can't be blank
        //Poscondition: City error is displayed if blank
        private void cityTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool resultChar = cityTextBox.Text.All(Char.IsLetter);
            if (string.IsNullOrEmpty(cityTextBox.Text) || string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                e.Cancel = true;
                cityTextBox.Focus();
                cityErrorProvider.SetError(cityTextBox, "City can not be blank.");
                cityTextBox.SelectAll();
            }
            if (!resultChar)
            {
                e.Cancel = true;
                cityTextBox.Focus();
                cityErrorProvider.SetError(cityTextBox, "City can not have an integer number.");
                cityTextBox.SelectAll();
            }

        }

        //Precondition: None
        //Postcondition: City error is cleared and city is validated
        private void cityTextBox_Validated(object sender, EventArgs e)
        {
            cityErrorProvider.SetError(cityTextBox, "");
        }

        //Precondition: state combo box selected index can't be less than zero
        //Poscondition: Error message is displayed if it is less than zero
        private void stateCombo_Validating(object sender, CancelEventArgs e)
        {
            if (stateCombo.SelectedIndex < 0)
            {
                e.Cancel = true;
                stateCombo.Focus();
                stateErrorProvider.SetError(stateCombo, "Must select a state.");
            }
        }

        //Precondition: None
        //Poscondition: State error is cleared and state is validated
        private void stateCombo_Validated(object sender, EventArgs e)
        {
            stateErrorProvider.SetError(stateCombo, "");
        }

        //Precondition: Zip must be an int and between 00000 and 99999
        //Postcondition: Correct error is show if needed
        private void zipTextBox_Validating(object sender, CancelEventArgs e)
        {
            int number; //Variable to hold zip

            if (!int.TryParse(zipTextBox.Text, out number))
            {
                e.Cancel = true;
                zipTextBox.SelectAll();
                zipErrorProvider.SetError(zipTextBox, "Please enter an integer.");
                zipTextBox.SelectAll();
            }
            else if (number <= MIN_ZIP || number >= MAX_ZIP)
            {
                e.Cancel = true;
                zipTextBox.SelectAll();
                zipErrorProvider.SetError(zipTextBox, "Zip must be between 00000 and 99999");
                zipTextBox.SelectAll();
            }
        }

        //Precondition: None
        //Postcondition: Zip error is cleared and zip is validated
        private void zipTextBox_Validated(object sender, EventArgs e)
        {
            zipErrorProvider.SetError(zipTextBox, "");
        }

        //Precondition: All error providers must have passed validation
        //Postcondition: Dialog box closes
        private void addAddressButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        internal string AddressName
        {
            //Precondition: None
            //Postcondition: Returns name
            get { return nameTextBox.Text; }

            //Precondition: None
            //Postcondition: Sets name to value
            set { nameTextBox.Text = value; }
        }

        internal string AddressLine1
        {
            //Precondition: None
            //Postcondition: Returns address line 1
            get { return address1TextBox.Text; }

            //Precondition: None
            //Postcondition: Set value to address line 1
            set { address1TextBox.Text = value; }
        }

        internal string AddressLine2
        {
            //Precondition: None
            //Postcondition: Returns address line 2
            get { return address2TextBox.Text; }

            //Precondition: None
            //Postcondition: Sets value to address line 2
            set { address2TextBox.Text = value; }
        }

        internal string AddressCity
        {
            //Precondition: None
            //Postcondition: Returns city
            get { return cityTextBox.Text; }

            //Precondition: None
            //Postcondition: Sets value to city
            set { cityTextBox.Text = value; }
        }

        internal string AddressState
        {
            //Precondition: None
            //Postcondition: Returns state
            get { return stateCombo.Text; }

            //Precondition: None
            //Postcondition: Sets value to state
            set { stateCombo.Text = value; }
        }

        internal string AddressZip
        {
            //Precondition: None
            //Postcondition: Returns zip code
            get { return zipTextBox.Text; }

            //Precondition: None
            //Postcondition: Sets value to zip
            set { zipTextBox.Text = value; }
        }

        private void cancelAddressButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

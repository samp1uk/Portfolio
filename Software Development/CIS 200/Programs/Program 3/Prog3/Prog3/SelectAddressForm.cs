// Program 3
// CIS 200-01
// Fall 2019
// Due: 11/11/2019
// By: M3838

// File: SelectAddressForm.cs
//This form has been made to change addresses. When opened, it will request that you select a location from the list. You may not proceed until you have chosen at any rate one location. Once chose, it will open up the Address form so you may edit the location.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class SelectAddressForm : Form
    {
        public SelectAddressForm()
        {
            InitializeComponent();
           
        }
        public const int MIN_ADDRESSES = 2; // Minimum number of addresses needed

        private List<Address> addressList;
        public SelectAddressForm(List<Address> addresses)
        {
            InitializeComponent();

            addressList = addresses;
        }
        internal int EditAddressIndex
        {
            //Precondition: None
            //Postcondition: Returns selected index of edit address combo.
            get { return editAddressCombo.SelectedIndex; }

            //Precondition: Item must be chosen and must be smaller than address count.
            //Postcondition: Selected index is set to value.
            set
            {
                if ((value >= -1) && (value < addressList.Count))
                    editAddressCombo.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("EditAddressIndex", value,
                        "Index must be valid.");
            }
        }


        private void SelectAddressForm_Validated(object sender, EventArgs e)
        {
            editAddressErrorProvider.SetError(editAddressCombo, "");
        }

        private void SelectAddressForm_Validating(object sender, CancelEventArgs e)
        {
            if (editAddressCombo.SelectedIndex == -1) // -1 means no item selected
            {
                e.Cancel = true;
                editAddressErrorProvider.SetError(editAddressCombo, "Must select an address");
            }
        }

        private void SelectAddressForm_Load(object sender, EventArgs e)
        {
            foreach (Address a in addressList)
            {
                editAddressCombo.Items.Add(a.Name);
            }
            editAddressCombo.SelectedIndex = 0; //set the combo box to the first address on the list.
        }
        //Precondition: editAddressButton is activated.
        //Postcondition: SelectAddressForm closes.
        private void editAddressButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            // This handler uses MouseDown instead of Click event because
            // Click won't be allowed if other field's validation fails

            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
    }
}

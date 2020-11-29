// Program 2
// CIS 200-01
// Fall 2019
// Due: 10/21/2019
// By: M3838

// File: Prog2Form.cs
// This Program will let you select an about menu, exit, insert address and parcel and list the address and parcel.

using Prog2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        public Prog2Form()
        {
            InitializeComponent();
            upv = new UserParcelView();

            upv.AddAddress("John Smith","123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); //Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); //Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); //Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); //Test Address 4
            upv.AddAddress("Bony Clide", "398 Briarwood Street",
                "Severn", "MD", 21144); //Test Address 5
            upv.AddAddress("Jason Broune", "97 Center Avenue",
                "Boca Raton", "FL", 33428); //Test Address 6
            upv.AddAddress("Robin William", "8333 Lancaster Drive",
                "State College", "PA", 16801); //Test Address 7
            upv.AddAddress("Katrina Kafia", "73 El Dorado Street",
                "High Point", "NC", 27265); //Test Address 8

            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(7), 3.95M); //Test Letter 1
            upv.AddLetter(upv.AddressAt(1), upv.AddressAt(6), 2.30M); //Test Letter 2

            upv.AddGroundPackage(upv.AddressAt(2), upv.AddressAt(5), 14, 10, 5, 12.5); //Test GP 1
            upv.AddGroundPackage(upv.AddressAt(3), upv.AddressAt(4), 10, 12, 80, 50); //Test GP 2

            upv.AddNextDayAirPackage(upv.AddressAt(4), upv.AddressAt(3), 10, 40, 35, 61, 8.50M); //Test NDAP 1
            upv.AddNextDayAirPackage(upv.AddressAt(5), upv.AddressAt(2), 10, 15, 20, 10, 7.00M); //Test NDAP 2

            upv.AddTwoDayAirPackage(upv.AddressAt(6), upv.AddressAt(1), 46.5, 39.5, 28.0, 80.5, TwoDayAirPackage.Delivery.Saver); //Test TDAP 1
            upv.AddTwoDayAirPackage(upv.AddressAt(7), upv.AddressAt(0), 20, 40, 20, 250, TwoDayAirPackage.Delivery.Early); //Test TDAP2
        }

        private UserParcelView upv; //UPV
        String NL = Environment.NewLine; //New Line variable.
        //Preconiditon: None
        //Postcondition: Displays a messagebox with programmer information.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grading ID: M3838" + NL + "Section Number: CIS 200-01-4198" + NL + NL  + "This Program will let you select an about menu, exit, insert address and parcel and list the address and parcel.", "Program 2: About ");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm AddressForm = new AddressForm();
            DialogResult result;
            string name; //Variable to hold name
            string address1; //Variable to hold address line 1
            string address2; //Variable to hold address line 2
            string city; //Variable to hold city
            string state; //Variable to hold state
            int zip; //Variable to hold zip

            result = AddressForm.ShowDialog(); //Show Address form on top of main form

            if (result == DialogResult.OK) //If the dialog result is okay
            {
                name = AddressForm.AddressName;
                address1 = AddressForm.AddressLine1;
                address2 = AddressForm.AddressLine2;
                city = AddressForm.AddressCity;
                state = AddressForm.AddressState;
                zip = int.Parse(AddressForm.AddressZip);

                upv.AddAddress(name, address1, address2, city, state, zip); //Use add address method to add address input to UPV.
            }
        }

        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm LetterForm = new LetterForm(upv.AddressList);
            DialogResult result;
            int originIndex;
            int destinationIndex;
            decimal fixedCost;

            result = LetterForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                originIndex = LetterForm.OriginIndex;
                destinationIndex = LetterForm.DestIndex;
                fixedCost = decimal.Parse(LetterForm.LetterFixedCost);

                upv.AddLetter(upv.AddressAt(originIndex), upv.AddressAt(destinationIndex), fixedCost);
            }
        }

        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayText.AppendText("Number Of Addresses: " + $"{upv.AddressCount}" + NL + NL);

            //Step through list of addresses and display in text box.
            foreach (Address item in upv.AddressList)
            {
                displayText.AppendText(item.ToString() + NL);
                displayText.AppendText("================================" + NL);
            }
        }

        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayText.AppendText("Number Of Parcels: "+ $"{upv.ParcelCount}" + NL + NL);

            //Step through list of parcels and display in text box.
            foreach (Parcel item in upv.ParcelList)
            {
                displayText.AppendText(item.ToString() + NL);
                displayText.AppendText("================================" + NL);
            }
        }
    }
}

//Sohal Patel
//CIS-411-75-4202
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortgage_Calculator
{
    public partial class Amortization_Schedule : Form
    {
        public Amortization_Schedule(object dataSource, double monthlyPayment, int month, double totalPayment, double totalInterestPaid, string payOffDate)
        {
            InitializeComponent();
            //table value is grabed from the Mortgagelibrary and output values.
            amortizationView.DataSource = dataSource;
            monthlyPaymentTxt.Text = $"{monthlyPayment:C}";
            totalOfPayLbl.Text = $"Total of {month} Payments:";
            totalOfPayTxt.Text = $"{totalPayment:C}";
            totalInterestPaidTxt.Text = $"{totalInterestPaid:C}";
            payOffDateTxt.Text = $"{payOffDate}";
            //adds numbers on the left side of the data view so you can see how many values are added.
            this.amortizationView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.AmortizationView_Row);

        }
        //adds numbers on the left side of the data view so you can see how many values are added.
        private void AmortizationView_Row(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(amortizationView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
        //Closed the form.
        private void Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }

}

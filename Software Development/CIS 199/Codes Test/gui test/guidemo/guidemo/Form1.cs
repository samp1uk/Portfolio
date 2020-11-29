using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guidemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calbutton_Click(object sender, EventArgs e)
        {
            double tempf;
            double tempc;

            tempf = double.Parse(tempf.Text);
            tempc = 5.0 / 9.0 * (tempf - 32);

            tempinclabel.Text = $"{tempc:F1}";
        }
    }
}

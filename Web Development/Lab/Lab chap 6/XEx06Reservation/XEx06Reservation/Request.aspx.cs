//By Sohal Patel
//CIS-411-75-4202
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx06Reservation
{
    public partial class Request : System.Web.UI.Page
    {
        private string currentDate = DateTime.Today.ToShortDateString();
        private string currentYear = DateTime.Today.Year.ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            //set arrival date and departure date to todays date.
            txtArrivalDate.Text = DateTime.Parse(currentDate).ToString("yyyy-MM-dd");
            txtDepartureDate.Text = DateTime.Parse(currentDate).ToString("yyyy-MM-dd");

            //add this year copy right at the bottom of the page. 
            lblYear.Text = currentYear;

            //make sure that the arrival date is todays date.
            compareValidatorArrivalDate.ValueToCompare = DateTime.Today.ToString("yyyy-MM-dd");

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Check if all the validation is for the form is correct and then send a message to the user. 
            if (Page.IsValid)
            {
                //Two different message shown to the user. 
                lblMessage.Text = "Thank you for your request. We will get back to you within 24 hours.";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Thank you for your request.\\nWe will get back to you within 24 hours.')", true);
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            //set all the value to clear and to their default values.
            txtArrivalDate.Text = DateTime.Parse(currentDate).ToString("yyyy-MM-dd");
            txtDepartureDate.Text = DateTime.Parse(currentDate).ToString("yyyy-MM-dd");
            txtDepartureDate.Text = "";
            dropDownNumPeople.SelectedValue = Convert.ToString(1);
            radioBedType.SelectedValue = "King";
            txtSpecialReq.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNum.Text = "";
            dropDownPreffered.SelectedValue = "Email";
            lblMessage.Text = "";
        }


    }
}
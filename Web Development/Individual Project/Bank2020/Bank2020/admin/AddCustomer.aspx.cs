using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
namespace Bank2020.admin
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        string time;
        string c = ConfigurationManager.ConnectionStrings["social"].ConnectionString;

        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(c);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into customer(firstname,lastname,address,age ) values('" + firstNameTxt.Text + "','" + lastNameTxt.Text + "','" + addressTxt.Text + "','" + Convert.ToInt32(ageTxt.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MsgBox(" Customer has been added Sucessfully!", this.Page, this);

        }
    }
}
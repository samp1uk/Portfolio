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
using System.IO;
using System.Drawing;

namespace Bank2020.admin
{
    public partial class AddUser : System.Web.UI.Page
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

            string fileimg = "user.png";
            if (imgUpload.HasFile)
            {
                //string strpath = Path.GetExtension(imgUpload.PostedFile.FileName);

                fileimg = Path.GetFileName(imgUpload.PostedFile.FileName);
                imgUpload.SaveAs(Server.MapPath("~/UserImages/") + fileimg);
            }

            SqlConnection con = new SqlConnection(c);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into login(firstname,lastname,username,password,img ) values('" + firstNameTxt.Text + "','" + lastNameTxt.Text + "','" + usernameTxt.Text + "','" + passwordTxt.Text + "', @Uimg)", con);
            cmd.Parameters.AddWithValue("@Uimg", "~/UserImages/" + fileimg);
            cmd.ExecuteNonQuery();
            con.Close();
            MsgBox(" User has been added Sucessfully!", this.Page, this);

        }
    }
}
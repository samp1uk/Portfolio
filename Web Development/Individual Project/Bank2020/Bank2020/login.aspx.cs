using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Bank2020
{
    public partial class login : System.Web.UI.Page
    {
        string c = ConfigurationManager.ConnectionStrings["social"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(c))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from login where username=@u and password=@p", con);
                    cmd.Parameters.AddWithValue("@u", usernameBox.Text);
                    cmd.Parameters.AddWithValue("@p", passwordBox.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string firstname = dr["firstname"].ToString();
                            string lastname = dr["lastname"].ToString();
                            string imgpath = dr["img"].ToString();

                            dr.Close();

                            Session["username"] = usernameBox.Text;
                            Session["firstname"] = firstname;
                            Session["lastname"] = lastname;
                            Session["img"] = imgpath;

                            Response.Redirect("~/admin/user.aspx");
                        }
                    }
                    else
                    {
                        errorLbl.Text = "Invalid username or password!";
                    }
                }
                finally
                {

                    con.Close();
                }
            }


        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}
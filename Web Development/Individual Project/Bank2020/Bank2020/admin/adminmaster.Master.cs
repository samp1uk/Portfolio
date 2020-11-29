using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank2020.admin
{
    public partial class adminmaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["firstname"] == null)
            {
                // Session has expired or person has not signed in so redirect.
                FormsAuthentication.SignOut();
                Session.Abandon();
                Response.Redirect("~/login.aspx", true);

            }
            else
            {
                userImg.ImageUrl = Session["img"].ToString();
                lblUserInfo.Text = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
            }
        }
    }
}
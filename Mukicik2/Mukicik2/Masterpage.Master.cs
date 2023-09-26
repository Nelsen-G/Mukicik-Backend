using Mukicik2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mukicik2
{
    public partial class Masterpage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Application["user_count"] == null)
            {
                Application["user_count"] = 0;
            }

            User u = (User)Session["user"];

            if(u != null)
            {
                lblUserCount.Text = "Users Count: " + Application["user_count"] + "| Hi, " + u.Username;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Session.RemoveAll();
            Session.Clear();
            Session.Abandon();

            Application["user_count"] = Convert.ToInt32(Application["user_count"]) - 1;

            Response.Redirect("Home.aspx");
        }

        protected void btnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void btnUpdateDeleteProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateDeleteProduct.aspx");
        }

        protected void btnViewProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProduct.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
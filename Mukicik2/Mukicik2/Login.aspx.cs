using Mukicik2.Model;
using Mukicik2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mukicik2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserRepository check = new UserRepository();
            User u = check.checkUser(tbEmail.Text, tbPassword.Text);
            if(u != null)
            {
                Session["user"] = u;
                if(cbRemember.Checked == true)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Expires = DateTime.Now.AddDays(1);
                    cookie.Value = tbEmail.Text;
                    Response.Cookies.Add(cookie);
                }
                Application["user_count"] = Convert.ToInt32(Application["user_count"]) + 1;
                Response.Redirect("Home.aspx");
            }
        }
    }
}
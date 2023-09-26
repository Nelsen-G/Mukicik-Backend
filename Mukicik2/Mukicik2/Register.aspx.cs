using Mukicik2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mukicik2
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calendarDOB_SelectionChanged(object sender, EventArgs e)
        {
            DateTime currDate = calendarDOB.SelectedDate;
            tbDOB.Text = currDate.ToString("dd MMMM yyyy");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(!tbEmail.Text.Contains("@") || !tbEmail.Text.Contains(".") 
                || tbEmail.Text.IndexOf("@") == 0 || tbEmail.Text.IndexOf("@") == (tbEmail.Text.Length-1)
                || tbEmail.Text.IndexOf(".") == 0 || tbEmail.Text.IndexOf(".") == (tbEmail.Text.Length - 1)
                || tbEmail.Text.IndexOf("@.") != -1 || tbEmail.Text.IndexOf(".@") != -1) 
            {
                lblError.Text = "Email must be in correct format.";
            }
            else if(RadioButtonList1.SelectedValue == null)
            {
                lblError.Text = "Select your gender";
            }
            else if(CheckBox1.Checked == false)
            {
                lblError.Text = "Check the Tnc";
            }
            else
            {
                UserRepository register = new UserRepository();
                register.registerUser(tbName.Text, tbEmail.Text, tbPassword.Text, RadioButtonList1.SelectedValue, calendarDOB.SelectedDate, FileUpload1.FileName);
                Response.Redirect("Login.aspx");
            }
        }
    }
}
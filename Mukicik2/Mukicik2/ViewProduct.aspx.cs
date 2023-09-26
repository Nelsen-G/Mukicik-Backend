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
    public partial class ViewProduct : System.Web.UI.Page
    {
        public List<Product> AllProducts = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductRepository repo = new ProductRepository();
            AllProducts = repo.GetAllProducts();

            btnClearFilter.Visible = false;

            if (!IsPostBack)
            {
                CategoryRepository cat = new CategoryRepository();
                dropdownCategory.DataSource = cat.GetAllCategories();
                dropdownCategory.DataTextField = "CategoryName";
                dropdownCategory.DataValueField = "CategoryID";
                dropdownCategory.DataBind();
                
                if(Request.QueryString["id"] != null)
                {
                    AllProducts = repo.GetByID(Convert.ToInt32((Request.QueryString["id"])));
                    dropdownCategory.DataBind();
                    btnClearFilter.Visible = true;
                }
            }

        }

        protected void dropdownCategory_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Response.Redirect("ViewProduct.aspx?id=" + Convert.ToInt32(dropdownCategory.SelectedValue));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProduct.aspx");
        }
    }
}
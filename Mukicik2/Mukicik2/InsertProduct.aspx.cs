using Mukicik2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mukicik2
{
    public partial class InsertProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryRepository cat = new CategoryRepository();
            dropdownCategory.DataSource = cat.GetAllCategories();
            dropdownCategory.DataTextField = "CategoryName";
            dropdownCategory.DataValueField = "CategoryID";
            dropdownCategory.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ProductRepository addRepo = new ProductRepository();
            addRepo.InsertProduct(tbName.Text, Convert.ToInt32(tbPrice.Text), tbImage.Text, float.Parse(tbRating.Text), Convert.ToInt32(dropdownCategory.SelectedValue));
            Response.Redirect("ViewProduct.aspx");
        }
    }
}
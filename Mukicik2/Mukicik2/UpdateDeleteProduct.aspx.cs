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
    public partial class UpdateDeleteProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProductRepository view = new ProductRepository();
           
                GridView1.DataSource = view.GetAllProducts();
                GridView1.DataBind();

                CategoryRepository cat = new CategoryRepository();
                dropdownCategory.DataSource = cat.GetAllCategories();
                dropdownCategory.DataTextField = "CategoryName";
                dropdownCategory.DataValueField = "CategoryID";
                dropdownCategory.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.NewSelectedIndex];
            tbID.Text = row.Cells[2].Text;
            tbName.Text = row.Cells[3].Text;
            tbPrice.Text = row.Cells[4].Text;
            tbImage.Text = row.Cells[5].Text;
            tbRating.Text = row.Cells[6].Text;
            dropdownCategory.SelectedValue = row.Cells[7].Text;
        }
        
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            ProductRepository delete = new ProductRepository();
            delete.DeleteProduct(row.Cells[2].Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductRepository update = new ProductRepository();
            update.UpdateProduct(tbID.Text, tbName.Text, Convert.ToInt32(tbPrice.Text), tbImage.Text, float.Parse(tbRating.Text), Convert.ToInt32(dropdownCategory.SelectedValue));
            Response.Redirect(Request.RawUrl);
        }
    }
}
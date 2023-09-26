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
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Product> topProducts = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductRepository repo = new ProductRepository();
            topProducts = repo.GetTopProducts();
        }
    }
}
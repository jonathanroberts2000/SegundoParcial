using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JonathanRoberts
{
    public partial class NewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = (User)Session["UserEntity"];
            Lbl_UserName.Text = string.Format("Username: {0}", user.UserName);
            Lbl_UserFullName.Text = string.Format("{0} {1}", user.Name, user.LastName);
            Lbl_UserType.Text = string.Format("User Profile: {0}", user.ProfileType.ToString());
        }

        protected void Btn_ConfirmNewProduct_Click(object sender, EventArgs e)
        {
            var list = (List<Product>)Session["ProductList"];

            Product newProduct = new Product
            {
                Id = Convert.ToInt32(Txb_id.Text),
                Sku = Txb_sku.Text,
                Brand = Txb_brand.Text,
                Name = Txb_name.Text,
                Price = Convert.ToDouble(Txb_price.Text),
                IsEnabled = Rdb_enabled.Checked,
                MinQuantity = Convert.ToInt32(Txb_min_quantity.Text),
                MaxQuantity = Convert.ToInt32(Txb_max_quantity.Text),
                ProductType = (EProductType)Convert.ToInt32(Txb_product_type.Text)
            };

            ValidateNewProduct(ref newProduct);

            list.Add(newProduct);
            Session["ProductList"] = list;
            Response.Redirect("MainPage.aspx");
        }

        private void ValidateNewProduct(ref Product product)
        {
            int i = 0;
            var list = (List<Product>)Session["ProductList"];
            
            while(list.Select(x => x.Id).ToList().Contains(i))
            {
                i++;
            }

            product.Id = i;
        }
    }
}
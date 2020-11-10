using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JonathanRoberts
{
    public partial class ModifyProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = (User)Session["UserEntity"];
            Lbl_UserName.Text = string.Format("Username: {0}", user.UserName);
            Lbl_UserFullName.Text = string.Format("{0} {1}", user.Name, user.LastName);
            Lbl_UserType.Text = string.Format("User Profile: {0}", user.ProfileType.ToString());

            var product = (Product)Session["ProductToModify"];

            Lbl_id.Text += product.Id;
            Lbl_sku.Text += product.Sku;
            Lbl_brand.Text += product.Brand;
            Txb_brand.Text = product.Brand;
            Lbl_name.Text += product.Name;
            Txb_name.Text = product.Name;
            Txb_price.Text = product.Price.ToString();
            Rdb_enabled.Checked = product.IsEnabled;
            Lbl_enabled.Text += product.IsEnabled ? "Enabled" : "Disabled";
            Txb_min_quantity.Text += product.MinQuantity.ToString();
            Txb_max_quantity.Text = product.MaxQuantity.ToString();
            Lbl_product_type.Text += product.ProductType.ToString();
        }

        protected void Btn_SaveChanges_Click(object sender, EventArgs e)
        {
            var list = (List<Product>)Session["ProductList"];

            //var product = (Product)Session["ProductToModify"];

            list[Convert.ToInt32(Session["ProductToModifyIndex"])].Brand = Txb_brand.Text;
            list[Convert.ToInt32(Session["ProductToModifyIndex"])].Name = Txb_name.Text;
            list[Convert.ToInt32(Session["ProductToModifyIndex"])].Price = Convert.ToDouble(Txb_price.Text.Replace(",", "."));
            list[Convert.ToInt32(Session["ProductToModifyIndex"])].IsEnabled = Rdb_enabled.Checked;
            list[Convert.ToInt32(Session["ProductToModifyIndex"])].MinQuantity = Convert.ToInt32(Txb_min_quantity.Text);
            list[Convert.ToInt32(Session["ProductToModifyIndex"])].MaxQuantity = Convert.ToInt32(Txb_max_quantity.Text);

            //list.Insert(Convert.ToInt32(Session["ProductToModifyIndex"]), product);
            Session["ProductList"] = list;

            Response.Redirect("MainPage.aspx");
        }
    }
}
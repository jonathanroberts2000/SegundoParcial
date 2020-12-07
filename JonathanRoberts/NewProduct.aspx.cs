using BLL;
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
            var productBLL = new ProductBLL();

            productBLL.InsertNewProduct(Txb_sku.Text, Txb_brand.Text, Convert.ToDouble(Txb_price.Text.Replace(",", ".")), Txb_name.Text, Rdb_disabled.Checked, Convert.ToInt32(Txb_min_quantity.Text), Convert.ToInt32(Txb_max_quantity.Text), Convert.ToInt32(Txb_product_type.Text));

            Response.Redirect("MainPage.aspx");
        }

        protected void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}
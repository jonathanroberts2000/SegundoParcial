using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JonathanRoberts
{
    public partial class MainPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = (User)Session["UserEntity"];
            Lbl_UserName.Text = string.Format("Username: {0}", user.UserName);
            Lbl_UserFullName.Text = string.Format("{0} {1}", user.Name, user.LastName);
            Lbl_UserType.Text = string.Format("User Profile: {0}", user.ProfileType.ToString());
            if (!Page.IsPostBack)
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            var productBLL = new ProductBLL();
            var productList = productBLL.LoadProducts(0);
            GridProducts.DataSource = productList;
            GridProducts.DataBind();
        }

        protected void Grilla_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            var productBLL = new ProductBLL();
            var user = (User)Session["UserEntity"];

            if (user.ProfileType == EProfile.Administrator || user.ProfileType == EProfile.Operator)
            {
                if (e.CommandName == "DeleteProduct")
                {
                    productBLL.DeleteProduct(e.CommandArgument.ToString());
                    LoadProducts();
                }
                else if (e.CommandName == "ModifyProduct")
                {
                    Session["SkuToModify"] = e.CommandArgument.ToString();
                    Response.Redirect("ModifyProduct.aspx");
                }
            }else
            {
                Session["ErrorId"] = 1;
                Session["ErrorMessage"] = "You do not have permission to execute this action.";
                Response.Redirect("ErrorPage.aspx");
            }
        }

        protected void DropOptionList_OnChange(object sender, EventArgs e)
        {
            var user = (User)Session["UserEntity"];
            var productBLL = new ProductBLL();

            if (user.ProfileType == EProfile.Administrator || user.ProfileType == EProfile.Operator)
            {
                switch (DropOptionList.SelectedItem.Value)
                {
                    case "NewProduct.aspx":
                        if (user.ProfileType == EProfile.Administrator && DropOptionList.SelectedItem.Selected)
                        {
                            Response.Redirect("NewProduct.aspx");
                        }
                        else
                        {
                            Session["ErrorId"] = 1;
                            Session["ErrorMessage"] = "You do not have permission to execute this action.";
                            Response.Redirect("ErrorPage.aspx");
                        }
                        break;
                    case "ordId1":
                        GridProducts.DataSource = productBLL.LoadProducts(1);
                        GridProducts.DataBind();
                        break;
                    case "ordId2":
                        GridProducts.DataSource = productBLL.LoadProducts(2);
                        GridProducts.DataBind();
                        break;
                }
            }
            else
            {
                Session["ErrorId"] = 1;
                Session["ErrorMessage"] = "You do not have permission to execute this action.";
                Response.Redirect("ErrorPage.aspx");
            }
        }

        protected void Btn_search_Click(object sender, EventArgs e)
        {
            var productBLL = new ProductBLL();

            GridProducts.DataSource = productBLL.Search(Txb_search_name.Text, Txb_search_sku.Text, Txb_search_brand.Text);
            GridProducts.DataBind();
        }
    }
}
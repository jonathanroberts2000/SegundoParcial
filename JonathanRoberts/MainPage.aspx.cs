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
        private List<Product> productList;

        protected void Page_Load(object sender, EventArgs e)
        {
            var user = (User)Session["UserEntity"];
            Lbl_UserName.Text = string.Format("Username: {0}", user.UserName);
            Lbl_UserFullName.Text = string.Format("{0} {1}", user.Name, user.LastName);
            Lbl_UserType.Text = string.Format("User Profile: {0}", user.ProfileType.ToString());
            if(!Page.IsPostBack)
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            var productBLL = new ProductBLL();
            var productList = productBLL.LoadProducts();
            GridProducts.DataSource = productList;
            GridProducts.DataBind();
        }

        protected void Grilla_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            var list = (List<Product>)Session["ProductList"];
            var user = (User)Session["UserEntity"];

            if (user.ProfileType == EProfile.Administrator || user.ProfileType == EProfile.Operator)
            {
                if (e.CommandName == "DeleteProduct")
                {
                    var element = list.Where(x => x.Sku == e.CommandArgument.ToString()).SingleOrDefault();

                    list.Remove(element);

                    Session["ProductList"] = list;
                    GridProducts.DataSource = list;
                    GridProducts.DataBind();
                }
                else if (e.CommandName == "ModifyProduct")
                {
                    var element = list.Where(x => x.Sku == e.CommandArgument.ToString()).SingleOrDefault();

                    Session["ProductToModify"] = element;
                    Session["ProductToModifyIndex"] = list.IndexOf(element);
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
                        productList = (List<Product>)Session["ProductList"];
                        productList = productList.OrderBy(x => x.Name).ToList();
                        GridProducts.DataSource = productList;
                        GridProducts.DataBind();
                        Session["ProductList"] = productList.OrderBy(x => x.Name).ToList();
                        break;
                    case "ordId2":
                        productList = (List<Product>)Session["ProductList"];
                        productList = productList.OrderBy(x => x.ProductType).ToList();
                        GridProducts.DataSource = productList;
                        GridProducts.DataBind();
                        Session["ProductList"] = productList.OrderBy(x => x.ProductType).ToList();
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
    }
}
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
            productList = new List<Product>
            {
                new Product { Id = 1, Sku = "AAA-1010", Brand = "Microsoft CSP", Name = "Microsoft 365 Business", IsEnabled = true, MaxQuantity = 5000, MinQuantity = 1, Price = 8.85, ProductType = EProductType.Licence },
                new Product { Id = 2, Sku = "AAA-5056", Brand = "Check Point", Name = "Check Point CloudGuard SaaS", IsEnabled = true, MaxQuantity = 500, MinQuantity = 50, Price = 200.00, ProductType = EProductType.Software },
                new Product { Id = 3, Sku = "AAA-0789", Brand = "A10 Networks", Name = "Thunder ADC", IsEnabled = true, MaxQuantity = 50, MinQuantity = 1, Price = 2000.59, ProductType = EProductType.Hardware },
                new Product { Id = 4, Sku = "GGG-1852", Brand = "Microsoft CSP Perpetual", Name = "Windows Server CAL - 16 Licence Core", MinQuantity = 1, MaxQuantity = 2000, IsEnabled = false, Price = 2387.48, ProductType = EProductType.Software },
                new Product { Id = 5, Sku = "AAA-1824", Brand = "Microsoft CSP", Name = "Microsoft Azure Reserved Instance", MinQuantity = 1, MaxQuantity = 25, IsEnabled = true, ProductType = EProductType.Cloud, Price = 289.99 }
            };

            if(Session["ProductList"] != null)
            {
                productList = (List<Product>)Session["ProductList"];
                GridProducts.DataSource = productList;
                GridProducts.DataBind();
                Session["ProductList"] = productList;
            }else
            {
                GridProducts.DataSource = productList;
                GridProducts.DataBind();
                Session["ProductList"] = productList;
            }
        }

        protected void Grilla_RowCommand(Object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            var list = (List<Product>)Session["ProductList"];

            if (e.CommandName == "DeleteProduct")
            {
                var element = list.Where(x => x.Sku == e.CommandArgument.ToString()).SingleOrDefault();

                list.Remove(element);
                
                Session["ProductList"] = list;
                GridProducts.DataSource = list;
                GridProducts.DataBind();
            }else if(e.CommandName == "ModifyProduct")
            {
                var element = list.Where(x => x.Sku == e.CommandArgument.ToString()).SingleOrDefault();

                Session["ProductToModify"] = element;
                Session["ProductToModifyIndex"] = list.IndexOf(element);
                Response.Redirect("ModifyProduct.aspx");
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
                    //case "ModifyProduct.aspx":
                    //    Session["ProductToModify"] = "";
                    //    Response.Redirect("ModifyProduct.aspx");
                    //    break;
                    //case "DeleteProduct.aspx":
                    //    if (user.ProfileType == EProfile.Administrator)
                    //    {
                    //        Response.Redirect("DeleteProduct.aspx");
                    //    }
                    //    else
                    //    {
                    //        Session["ErrorId"] = 1;
                    //        Session["ErrorMessage"] = "You do not have permission to execute this action.";
                    //        Response.Redirect("ErrorPage.aspx");
                    //    }
                    //    break;
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
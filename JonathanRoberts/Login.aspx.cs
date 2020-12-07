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
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            var userBLL = new UserBLL();
=======
            //LINEAS SOLO PARA TESTEO, BORRARLAS ANTERS DE PRESENTAR
            UserNameTbx.Text = "jroberts";
            PasswordTbx.Text = "Jr28ar86$6";
            ///

            var user = UserNameTbx.Text;
            var password = PasswordTbx.Text;
>>>>>>> origin/branch_bck

            var user = userBLL.GetUser(UserNameTbx.Text, PasswordTbx.Text);

            if(user != null && user.Enabled)
            {
                Session["UserEntity"] = user;
                Response.Redirect("MainPage.aspx");
            }else if(user != null && !user.Enabled)
            {
                Session["ErrorId"] = 0;
                Session["ErrorMessage"] = "Your user is disabled";
                Response.Redirect("ErrorPage.aspx");
            }else
            {
                Session["ErrorId"] = 0;
                Session["ErrorMessage"] = "User or Password was incorrect.";
                Response.Redirect("ErrorPage.aspx");
            }
        }
    }
}
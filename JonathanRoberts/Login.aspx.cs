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
        private List<User> userList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                userList = new List<User>();
                userList.AddRange(new List<User>
                {
                    new User{ Id = 0, Name = "Jonathan", LastName = "Roberts", UserName = "jroberts", Password = "Jr28ar86$6", ProfileType = EProfile.Administrator, Enabled = true },
                    new User{ Id = 1, Name = "Maria", LastName = "Perez", UserName = "mperez", Password = "123456", ProfileType = EProfile.Operator, Enabled = true },
                    new User{ Id = 2, Name = "Carla", LastName = "Rodriguez", UserName = "crodriguez", Password = "1234567", ProfileType = EProfile.Reader, Enabled = true },
                    new User{ Id = 3, Name = "Lautaro", LastName = "Brossi", UserName = "lbrossi", Password = "12345678", ProfileType = EProfile.Administrator, Enabled = false}
                });
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            //LINEAS SOLO PARA TESTEO, BORRARLAS ANTERS DE PRESENTAR
            UserNameTbx.Text = "jroberts";
            PasswordTbx.Text = "Jr28ar86$6";
            ///

            var user = UserNameTbx.Text;
            var password = PasswordTbx.Text;

            var result = userList.FirstOrDefault(x => x.UserName == user && x.Password == password);

            if(result != null && result.Enabled)
            {
                Session["UserEntity"] = result;
                Response.Redirect("MainPage.aspx");
            }else if(result != null && !result.Enabled)
            {
                Session["ErrorId"] = 0;
                Session["ErrorMessage"] = "Your user is disabled";
                Response.Redirect("ErrorPage.aspx");
            }else
            {
                Session["ErrorId"] = 0;
                Session["ErrorMessage"] = "User or Password was incorrect";
                Response.Redirect("ErrorPage.aspx");
            }
        }
    }
}
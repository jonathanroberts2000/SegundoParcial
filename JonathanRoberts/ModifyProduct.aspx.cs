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
        }
    }
}
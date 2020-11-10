using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JonathanRoberts
{
    public partial class ErrorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label_Error.Text = Session["ErrorMessage"].ToString();
        }

        protected void Btn_ErrorRedirection_Click(object sender, EventArgs e)
        {
            var errorId = Convert.ToInt32(Session["ErrorId"]);

            switch(errorId)
            {
                case 0:
                    Response.Redirect("Login.aspx");
                    break;
                case 1:
                    Response.Redirect("MainPage.aspx");
                    break;
            }
        }
    }
}
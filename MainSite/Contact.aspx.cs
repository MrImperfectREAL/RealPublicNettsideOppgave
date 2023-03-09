using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer; 

namespace MainSite
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(HttpContext.Current.User.Identity.IsAuthenticated)
            {
                lblMsg.Text = "You are logged in!";

                lblMsg.Visible = true;
                Login1.Visible = false;
                LoginStatus1.Visible = true;
                TextBoxNewPassword.Visible = true;
                TextBoxConfirmPassword.Visible = true;
                btn_SavePassword.Visible = true;
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            BLayer bl = new BLayer();
            int userCount = bl.GetAllFromLogIn(Login1.UserName, Login1.Password);

            if (userCount == 1)
            {
                e.Authenticated = true;
            }
        }

        protected void btn_SavePassword_Click(object sender, EventArgs e)
        {
            if (TextBoxNewPassword.Text == TextBoxConfirmPassword.Text)
            {
                BLayer bl = new BLayer();
                bl.ResetPassword(HttpContext.Current.User.Identity.Name, TextBoxNewPassword.Text);

                lblMsg.Text = "Password has been reset.";

                lblMsg.Visible = true;
            }

            else
            {
                lblMsg.Text = "Your passwords do not match! Please pick a password you can remember, or try again.";

                lblMsg.Visible = true;
            }
        }
    }
}
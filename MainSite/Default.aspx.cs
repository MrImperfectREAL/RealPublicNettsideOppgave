using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace MainSite
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelRolf.Text = BLayer.GetAllText()[1];

            if (HttpContext.Current.User.Identity.IsAuthenticated)//hack, men du skjønner  vel at du må bruke ekte login her....
            {

                LabelRolf.Text = BLayer.GetAllText()[1];//henter text fra db, det som er nå, inn til textbox

                RolfEdit.Visible = true;
            }
        }

        protected void RolfEdit_Click(object sender, EventArgs e)
        {
            LabelRolf.Visible = false;
            RolfEdit.Visible = false;
            btn_Cancel.Visible = true;
            btn_Update.Visible = true;
            TextBoxEditOnPage.Visible = true;   

            TextBoxEditOnPage.Text = LabelRolf.Text;
        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            LabelRolf.Visible = true;
            RolfEdit.Visible = true;
            btn_Cancel.Visible = false;
            btn_Update.Visible = false;
            TextBoxEditOnPage.Visible= false;   
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            LabelRolf.Visible = true;
            RolfEdit.Visible = true;
            btn_Cancel.Visible = false;
            btn_Update.Visible = false;
            TextBoxEditOnPage.Visible = false;

            BLayer.UpdateText(TextBoxEditOnPage.Text, "Text2");
            LabelRolf.Text = BLayer.GetAllText()[1];//ææææææææææææææææææææææææææææææææææææææææææææææææææææææææææææææææææææææ
        }
    }
}
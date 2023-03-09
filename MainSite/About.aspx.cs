using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MainSite
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelAI.Text = BLayer.GetAllText()[0];

            if (HttpContext.Current.User.Identity.IsAuthenticated)//hack, men du skjønner  vel at du må bruke ekte login her....
            {
                LabelAI.Text = BLayer.GetAllText()[0];//henter text fra db, det som er nå, inn til textbox
                AIEdit.Visible = true;
                //TextBoxEditOnPage.Visible = true;
                //husk å ha en knapp for UPDATE
            }
        }

        protected void AIEdit_Click(object sender, EventArgs e)
        {
            AIEdit.Visible = false;
            btn_Cancel.Visible = true;
            btn_Update.Visible = true;
            LabelAI.Visible = false;
            TextBoxEditOnPage.Visible = true;

            TextBoxEditOnPage.Text = LabelAI.Text;
        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            LabelAI.Visible = true;
            AIEdit.Visible = true;
            btn_Cancel.Visible = false;
            btn_Update.Visible = false;
            TextBoxEditOnPage.Visible = false;
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            LabelAI.Visible = true;
            AIEdit.Visible = true;
            btn_Cancel.Visible = false;
            btn_Update.Visible = false;
            TextBoxEditOnPage.Visible = false;

            BLayer.UpdateText(TextBoxEditOnPage.Text, "Text1");
            LabelAI.Text = BLayer.GetAllText()[0];
        }
    }
}
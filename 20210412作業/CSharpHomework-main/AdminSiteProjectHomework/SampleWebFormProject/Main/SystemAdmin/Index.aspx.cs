﻿using CoreProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Main.SystemAdmin
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (!LoginHelper.TryLogin(this.txtAccount.Text, this.txtPWD.Text))
            {
                this.Label1.Visible = true;

            }
            else
            {
                Response.Redirect("MainPage.aspx");
            }
            
        }
    }
}
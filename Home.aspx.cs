﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Smart_healthpredictor
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }

        protected void patientlogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Patient_login.aspx");
        }

        protected void doctorlogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Doctor_login.aspx");
        }
    }
}
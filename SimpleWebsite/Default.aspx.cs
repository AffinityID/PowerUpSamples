﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace SimpleWebsite
{
    public partial class _Default : System.Web.UI.Page
    {
        protected string GetEnvironmentName()
        {
            return ConfigurationManager.AppSettings["EnvironmentName"];
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}

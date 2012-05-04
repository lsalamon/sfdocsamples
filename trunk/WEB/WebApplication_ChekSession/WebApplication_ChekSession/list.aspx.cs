﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace WebApplication_ChekSession
{
    public partial class About : System.Web.UI.Page
    {

        public string LIST;
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<string, DateTime> activeUsers = (Dictionary<string, DateTime>)Application["activeUsers"];

             StringBuilder str = new StringBuilder();

            foreach (KeyValuePair<string, DateTime> u in activeUsers)
            {
                str.AppendLine("<DIV>");
                str.AppendLine(string.Concat(u.Key," inicio:  " , u.Value.ToString()));
                str.AppendLine("</DIV>");
            }

            LIST = str.ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication_ChekSession
{
    public class Global : System.Web.HttpApplication
    {
        Dictionary<string,DateTime> activeUsers;
        void Application_Start(object sender, EventArgs e)
        {
            activeUsers = new Dictionary<string, DateTime>();
            Application["activeUsers"] = activeUsers;

        }

        void Application_End(object sender, EventArgs e)
        {
            

        }

        void Application_Error(object sender, EventArgs e)
        {
            

        }

        void Session_Start(object sender, EventArgs e)
        {

           
        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}

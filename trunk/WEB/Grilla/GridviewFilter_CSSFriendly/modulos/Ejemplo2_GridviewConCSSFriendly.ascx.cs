﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class modulos_Ejemplo2_GridviewConCSSFriendly : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        GridViewJedis.DataSource = JediHelper.Listado();
        GridViewJedis.DataBind();

        //GridViewJedis.UseAccessibleHeader = true;
        //GridViewJedis.HeaderRow.TableSection = TableRowSection.TableHeader;


    }
}

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class welcome : System.Web.UI.Page
{
    static int i;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        i = i + 1;
        if (i >= 100)
        {
            Response.Redirect("mainpage.aspx");
            i = 0;
            Timer1.Enabled = false;

        }
    }
}

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
using System.Data.SqlClient;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand rs = new SqlCommand("select * from login where user_name like '" + TextBox1.Text + "' and password like '" + TextBox2.Text + "'", con);
        con.Open();
        SqlDataReader dr = rs.ExecuteReader();
        if (dr.Read())
        {
            Response.Redirect("mainpage.aspx");
        }
        else
        {
            Response.Write("<script language=javascript>alert('Wrong Username/password');</script>");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("default4.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }
}

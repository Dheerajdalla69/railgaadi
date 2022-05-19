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

public partial class deleteuser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");

        con.Open();
        SqlCommand rs = new SqlCommand("select * from login ", con);
        SqlDataReader dr = rs.ExecuteReader();
        while (dr.Read())
        {

            DropDownList1.Items.Add(Convert.ToString(dr[0]));
        }
     
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");

        con.Open();
        SqlCommand rs = new SqlCommand("delete from login where user_name like '" +DropDownList1.Text+"' ", con);
        rs.ExecuteNonQuery();
        Response.Write("data deleted");
        Response.Redirect("deleteuser.aspx");
    
    
    }
}

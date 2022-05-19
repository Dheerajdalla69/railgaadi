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
public partial class delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DropDownList1.Items.Clear();
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");

        con.Open();
        SqlCommand rs = new SqlCommand("select * from addtrain", con);
        SqlDataReader dr = rs.ExecuteReader();
        while (dr.Read())
        {
            DropDownList1.Items.Add(Convert.ToString( dr[0]));
        }
    }
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");

        con.Open();
        SqlCommand rs = new SqlCommand("delete from addtrain where train_no like '" + DropDownList1.Text + "'", con);
        rs.ExecuteNonQuery();
        Response.Write("<script language=javascript>alert('DATA DELETED');</script>");

    }
}

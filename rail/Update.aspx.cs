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
public partial class Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        SqlCommand rs = new SqlCommand("update addtrain set name='"+TextBox6.Text+"', source='"+TextBox3.Text+"',destination='"+TextBox4.Text+"',timing='"+TextBox5.Text+"'", con);
        rs.ExecuteNonQuery();
        Response.Write("<script language=javascript>alert('Data Updated');</script>");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        SqlCommand rs = new SqlCommand("select * from addtrain where train_no like '" + TextBox1.Text + "'", con);
        SqlDataReader dr = rs.ExecuteReader();
        if (dr.Read())
        {
            TextBox6.Text = Convert.ToString(dr[1]);
            TextBox3.Text = Convert.ToString(dr[2]);
            TextBox4.Text = Convert.ToString(dr[3]);
            TextBox5.Text = Convert.ToString(dr[4]);
        }
        
    }
}

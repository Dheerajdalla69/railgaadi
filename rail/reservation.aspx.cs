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
public partial class reservation : System.Web.UI.Page
{
    int x = 1;

    
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
        con1.Open();
        SqlCommand rs1 = new SqlCommand("select * from addtrain", con1);
        SqlDataReader dr1 = rs1.ExecuteReader();
        while (dr1.Read())
        {
            DropDownList1.Items.Add(Convert.ToString( dr1[1]));
        }
        

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        SqlCommand rs = new SqlCommand("select * from reservation", con);
        SqlDataReader dr = rs.ExecuteReader();
        while (dr.Read())
        {
            x++;
        
        }
        int y = x + 1;
        TextBox9.Text = "4567"+y+"";
        TextBox10.Text = "TIC" + TextBox9.Text;
        
    }
    protected void TextBox9_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        SqlCommand rs = new SqlCommand("insert into reservation values('" + DropDownList2.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox7.Text + "','" + TextBox5.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + DropDownList1.Text + "')", con);
        rs.ExecuteNonQuery();
        Response.Write("Data Inserted");

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}

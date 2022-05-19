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

public partial class add_user : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox2.Text!="" && TextBox3.Text!="" && TextBox4.Text!="")
        {
            if (TextBox3.Text.Equals(TextBox4.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
                SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
                
                con1.Open();
                SqlCommand rs = new SqlCommand("select * from login where user_name like '" +TextBox2.Text+ "'",con1);
                SqlDataReader dr=rs.ExecuteReader();
                if (!dr.Read())
                {
                    con.Open();
                    SqlCommand rs1 = new SqlCommand("insert into login  values('" + TextBox2.Text + "','" + TextBox3.Text + "')", con);
                    rs1.ExecuteNonQuery();
                    Response.Write("Data Inserted");
                    con1.Close();
                    con.Close();
                }
                else
                    Response.Write("user already exist");
                



                }

            else
                Response.Write("please fill the same password in both fields");
        
           }
        else
        Response.Write("please fill the data first");
        
    }
}

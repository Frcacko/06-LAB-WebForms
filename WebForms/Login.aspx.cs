using System;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        using (SqlConnection con = new SqlConnection(cs))
        {
            string query = "SELECT COUNT(*) FROM Users WHERE UserName=@u AND Password=@p";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@u", txtUsername.Text);
            cmd.Parameters.AddWithValue("@p", txtPassword.Text);

            con.Open();
            int count = (int)cmd.ExecuteScalar();

            if (count == 1)
            {
                Response.Redirect("Shop.aspx");
            }
            else
            {
                lblMsg.Text = "Pogrešni podaci!";
            }
        }
    }
}

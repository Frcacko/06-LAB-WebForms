using System;
using System.Data.SqlClient;
using System.Configuration;

public partial class Registration : System.Web.UI.Page
{
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        using (SqlConnection con = new SqlConnection(cs))
        {
            string query = "INSERT INTO Users (UserName, Password, FullName) VALUES (@u, @p, @f)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@u", txtUsername.Text);
            cmd.Parameters.AddWithValue("@p", txtPassword.Text);
            cmd.Parameters.AddWithValue("@f", txtFullName.Text);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        Response.Redirect("Login.aspx");
    }
}

+using System;
using System.Data.SqlClient;
using System.Configuration;

namespace ImeTvogProjekta
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["WebFormsCS"].ConnectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Users WHERE UserName=@u AND Password=@p", con);

            cmd.Parameters.AddWithValue("@u", tbUsername.Text);
            cmd.Parameters.AddWithValue("@p", tbPassword.Text);

            int loginOk = (int)cmd.ExecuteScalar();
            con.Close();

            if (loginOk == 1)
                Response.Redirect("Shop.aspx");
            else
                lblError.Text = "Neispravni podaci!";
        }
    }
}

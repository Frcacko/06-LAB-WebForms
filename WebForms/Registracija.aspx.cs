using System;
using System.Data.SqlClient;
using System.Configuration;

namespace ImeTvogProjekta
{
    public partial class Registracija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["WebFormsCS"].ConnectionString);

            con.Open();

            SqlCommand check = new SqlCommand(
                "SELECT COUNT(*) FROM Users WHERE UserName=@user", con);
            check.Parameters.AddWithValue("@user", tbUsername.Text);

            int exists = (int)check.ExecuteScalar();

            if (exists > 0)
            {
                lblMessage.Text = "Korisničko ime već postoji!";
                con.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Users(UserName, Password, FullName) VALUES(@u,@p,@f)", con);
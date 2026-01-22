using System;
using System.Data.SqlClient;
using System.Configuration;

namespace ImeTvogProjekta
{
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadProducts();
        }

        private void LoadProducts()
        {
            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["WebFormsCS"].ConnectionString);

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);
            SqlDataReader dr = cmd.ExecuteReader();

            gvProducts.DataSource = dr;
            gvProducts.DataBind();

            dr.Close();
            con.Close();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["WebFormsCS"].ConnectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Products(Name, Description) VALUES(@n,@d)", con);

            cmd.Parameters.AddWithValue("@n", tbName.Text);
            cmd.Parameters.AddWithValue("@d", tbDescription.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            LoadProducts();
        }
    }
}

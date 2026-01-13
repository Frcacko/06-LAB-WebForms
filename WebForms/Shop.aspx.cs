using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Shop : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LoadProducts();
    }

    void LoadProducts()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvProducts.DataSource = dt;
            gvProducts.DataBind();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            string query = "INSERT INTO Products (Name, Description) VALUES (@n, @d)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@d", txtDesc.Text);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        LoadProducts();
    }
}

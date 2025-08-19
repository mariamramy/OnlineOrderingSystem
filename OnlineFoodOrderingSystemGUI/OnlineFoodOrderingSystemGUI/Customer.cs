using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineFoodOrderingSystemGUI
{
    public partial class CustomerForm : Form
    {
        // read connection string from App.config
        string connectionString = System.Configuration.ConfigurationManager
                                      .ConnectionStrings["FoodOrderingDB"].ConnectionString;

        public CustomerForm()
        {
            InitializeComponent();
        }
        
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customer", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewCustomer.DataSource = dt;
            }
        }
    }
}

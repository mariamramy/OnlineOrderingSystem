using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace OnlineOrderingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-C9DIFIT;Initial Catalog=OnlineOrderingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}

 
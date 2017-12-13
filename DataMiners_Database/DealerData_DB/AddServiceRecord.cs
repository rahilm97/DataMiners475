using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DealerData_DB
{
    public partial class AddServiceRecord : Form
    {
        public AddServiceRecord()
        {
            InitializeComponent();
        }

        private void AddServiceRecord_Load(object sender, EventArgs e)
        {
            SqlConnection.connection.Open();
            string query = "SELECT * FROM SERVICE";
            MySqlDataAdapter data = new MySqlDataAdapter(query, SqlConnection.connection);
            DataTable dTable = new DataTable();
            data.Fill(dTable);
            viewRecords.DataSource = dTable;
            SqlConnection.connection.Close();
        }

        private void addService_Click(object sender, EventArgs e)
        {
            SqlConnection.connection.Open();
            // The format for the SQL query to insert into SALE_RECORD
            string query = "insert into SERVICE values (@SERV_NUM, @VIN_NUMBER, @CUST_ID, @COST, @TYPE, @DATE)";
            MySqlCommand command = new MySqlCommand(query, SqlConnection.connection);

            command.Parameters.AddWithValue("@SERV_NUM", serviceId.Text);
            command.Parameters.AddWithValue("@VIN_NUMBER", vinNum.Text);
            command.Parameters.AddWithValue("@CUST_ID", customerId.Text);
            command.Parameters.AddWithValue("@COST", cost.Text);
            command.Parameters.AddWithValue("@TYPE", type.Text);
            command.Parameters.AddWithValue("@DATE", Convert.ToDateTime(date.Text).ToString("yyyy-MM-dd"));

            int newRows = command.ExecuteNonQuery();
            MessageBox.Show(newRows + " rows inserted!");
            SqlConnection.connection.Close();
            AddServiceRecord_Load(null, null);
        }
    }
}

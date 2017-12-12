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
    public partial class CustomerSearch : Form
    {
        public CustomerSearch()
        {
            InitializeComponent();
        }

        private void CustomerSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataminersDealerDataDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.dataminersDealerDataDataSet.CUSTOMER);

        }

        private void btnCustID_Click(object sender, EventArgs e)
        {
            SqlConnection.connection.Open();
            string query = "SELECT * FROM CUSTOMER WHERE c_id=" + int.Parse(custID.Text);
            MySqlDataAdapter data = new MySqlDataAdapter(query, SqlConnection.connection);
            DataTable dTable = new DataTable();
            data.Fill(dTable);
            dataGridView1.DataSource = dTable;
            SqlConnection.connection.Close();
            //SqlConnection.command = new MySqlCommand(query, SqlConnection.connection);
            //SqlConnection.dataReader = SqlConnection.command.ExecuteReader();
        }

        private void custNameSearch_Click(object sender, EventArgs e)
        {
            SqlConnection.connection.Open();
            string query = "SELECT * FROM CUSTOMER WHERE fname='" + custFname.Text + "' AND lname='" + custLname.Text + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query, SqlConnection.connection);
            DataTable dTable = new DataTable();
            data.Fill(dTable);
            dataGridView1.DataSource = dTable;
            SqlConnection.connection.Close();
        }
    }
}

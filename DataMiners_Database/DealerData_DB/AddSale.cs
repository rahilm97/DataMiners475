/*
 * Rahil Mehta, Tavi Tenari, Stan Huber, Chayse Summers
 * AddSale.cs
 * CSS 475 Database Project
 * 
 * This class controls the Windows Form for adding a sale record.
 * The form contains text boxes to enter values for each row of the tuple.
 */
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
    public partial class AddSale : Form
    {
        public AddSale()
        {
            InitializeComponent();
        }

        // Adds a new tuple to SALE_RECORD.
        private void addSaleRecord_Click(object sender, EventArgs e)
        {
            SqlConnection.connection.Open();
            // The format for the SQL query to insert into SALE_RECORD
            string query = "insert into SALE_RECORD values (@SALE_ID, @VIN_NUMBER, @PRICE, @DATE, @DEALER_ID, @CUST_ID)";
            MySqlCommand command = new MySqlCommand(query, SqlConnection.connection);

            command.Parameters.AddWithValue("@SALE_ID", saleID.Text);
            command.Parameters.AddWithValue("@VIN_NUMBER", vinNum.Text);
            command.Parameters.AddWithValue("@PRICE", price.Text);
            command.Parameters.AddWithValue("@DATE", date.Text);
            command.Parameters.AddWithValue("@DEALER_ID", dealershipID.Text);
            command.Parameters.AddWithValue("@CUST_ID", custIDBox.Text);

            int newRows = command.ExecuteNonQuery();
            MessageBox.Show(newRows + " rows inserted!");
            SqlConnection.connection.Close();
        }

        // Displays the data in SALE_RECORD to show the user the format for values.
        private void AddSale_Load(object sender, EventArgs e)
        {
            SqlConnection.connection.Open();
            string query = "SELECT * FROM SALE_RECORD";
            MySqlDataAdapter data = new MySqlDataAdapter(query, SqlConnection.connection);
            DataTable dTable = new DataTable();
            data.Fill(dTable);
            viewNewSale.DataSource = dTable;
            SqlConnection.connection.Close();
        }
    }
}

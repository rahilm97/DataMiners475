/*
 * Rahil Mehta, Tavi Tenari, Stan Huber, Chayse Summers
 * CustomerSearch.cs
 * CSS 475 Database Project
 * 
 * This class controls the Windows Form for searching for customers.
 * A user can either search for customers by ID or by first and last name.
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
    public partial class CustomerSearch : Form
    {
        public CustomerSearch()
        {
            InitializeComponent();
        }

        // Searches for a customer by ID.
        private void btnCustID_Click(object sender, EventArgs e)
        {
            SqlConnection.connection.Open();
            // The SQL query to select a customer by ID
            string query = "SELECT * FROM CUSTOMER WHERE c_id=" + int.Parse(custID.Text);
            MySqlDataAdapter data = new MySqlDataAdapter(query, SqlConnection.connection);
            DataTable dTable = new DataTable();
            data.Fill(dTable);
            dataGridView1.DataSource = dTable;
            SqlConnection.connection.Close();
        }

        // Searches for a customer by first name and last name.
        private void custNameSearch_Click(object sender, EventArgs e)
        {
            SqlConnection.connection.Open();
            // The SQL query to select a customer by first name and last name
            string query = "SELECT * FROM CUSTOMER WHERE fname='" + custFname.Text + "' AND lname='" + custLname.Text + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query, SqlConnection.connection);
            DataTable dTable = new DataTable();
            data.Fill(dTable);
            dataGridView1.DataSource = dTable;
            SqlConnection.connection.Close();
        }
    }
}

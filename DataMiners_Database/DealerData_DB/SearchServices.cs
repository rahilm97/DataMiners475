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
    public partial class SearchServices : Form
    {
        public SearchServices()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection.connection.Open();
            // The SQL query to select a service record from name
            string queryStart =
           "SELECT s.service_num as 'service number', s.S_vin_number as 'VIN', " +
           "s.S_c_id as 'customer ID', c.fname as 'first name', c.lname as 'last name', " +
           "s.cost, s.type, s.date " +
           "FROM SERVICE s, CUSTOMER c WHERE s.S_c_id = c.c_id";
            string queryName =
            " AND c.fname = '" + textboxFName.Text + "' AND c.lname = '" + textboxLName.Text + "'";
            string queryVIN =
            " AND S_vin_number='" + textboxVIN.Text + "'";
            string queryDate =
            " AND s.date " +
            "BETWEEN '" + Convert.ToDateTime(dateFrom.Text).ToString("yyyy-MM-dd") +
            "' AND '" + Convert.ToDateTime(dateTo.Text).ToString("yyyy-MM-dd") + "'";

            string query = queryStart;
            if (checkBoxVIN.Checked)
            {
                query += queryVIN;
            }
            if (checkBoxName.Checked)
            {
                query += queryName;
            }
            if (checkBoxDate.Checked)
            {
                query += queryDate;
            }
            MySqlDataAdapter data = new MySqlDataAdapter(query, SqlConnection.connection);

            DataTable dTable = new DataTable();
            data.Fill(dTable);
            if (dTable.Rows.Count == 0)
            {
                MessageBox.Show("No results.");
            }
            else
            {
                dataGridView1.DataSource = dTable;
            }
            SqlConnection.connection.Close();
        }

        private void checkBoxVIN_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxVIN.Checked)
            {
                labelVIN.Visible = false;
                textboxVIN.Visible = false;
            }
            else
            {
                labelVIN.Visible = true;
                textboxVIN.Visible = true;
            }
            searchVisiblity();
        }

        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxName.Checked)
            {
                labelFName.Visible = false;
                labelLName.Visible = false;
                textboxFName.Visible = false;
                textboxLName.Visible = false;
            }
            else
            {
                labelFName.Visible = true;
                labelLName.Visible = true;
                textboxFName.Visible = true;
                textboxLName.Visible = true;
            }
            searchVisiblity();
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxDate.Checked)
            {
                labelFrom.Visible = false;
                labelTo.Visible = false;
                dateFrom.Visible = false;
                dateTo.Visible = false;
            }
            else
            {
                labelFrom.Visible = true;
                labelTo.Visible = true;
                dateFrom.Visible = true;
                dateTo.Visible = true;
            }
            searchVisiblity();
        }

        private void searchVisiblity()
        {
            if (!checkBoxName.Checked && !checkBoxDate.Checked && !checkBoxVIN.Checked)
            {
                btnSearch.Visible = false;
            }
            else
            {
                btnSearch.Visible = true;
            }
        }

        private void SearchServices_Load(object sender, EventArgs e)
        {
            checkBoxDate.Checked = true;
            checkBoxName.Checked = true;
            checkBoxVIN.Checked = true;
        }
    }
}

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
    public partial class DealerData : Form
    {
        public DealerData()
        {
            //SqlConnection.connection.Open();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void searchCars_Click(object sender, EventArgs e)
        {
            CarSearch form = new CarSearch();
            form.ShowDialog();
        }

        private void addCars_Click(object sender, EventArgs e)
        {
            AddCars form = new AddCars();
            form.ShowDialog();
        }

        private void searchCustomers_Click(object sender, EventArgs e)
        {
            CustomerSearch form = new CustomerSearch();
            form.ShowDialog();
        }

        private void addSale_Click(object sender, EventArgs e)
        {
            AddSale form = new AddSale();
            form.ShowDialog();
        }

        private void searchService_Click(object sender, EventArgs e)
        {
            SearchServices form = new SearchServices();
            form.ShowDialog();
        }

        private void addService_Click(object sender, EventArgs e)
        {
            AddServiceRecord form = new AddServiceRecord();
            form.ShowDialog();
        }
    }
}

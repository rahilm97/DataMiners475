using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DealerData_DB
{
    public partial class AddCars : Form
    {
        public AddCars()
        {
            InitializeComponent();
        }

        private void confirmAddCar_Click(object sender, EventArgs e)
        {
            SqlConnection.connection.Open();
            // The format for the SQL query to insert into SALE_RECORD
            string query = "INSERT INTO CAR VALUES (@VIN_NUMBER, @USE_STATUS, @MILEAGE, @COLOR, @C_TRIMLEVEL, @D_DEALER_ID, @CUST_ID, @M_MODEL_ID)";
            MySqlCommand command = new MySqlCommand(query, SqlConnection.connection);

            command.Parameters.AddWithValue("@VIN_NUMBER", vinEntry.Text);
            command.Parameters.AddWithValue("@USE_STATUS", statusEntry.Text);
            command.Parameters.AddWithValue("@MILEAGE", mileageEntry.Text);
            command.Parameters.AddWithValue("@COLOR", colorEntry.Text);
            command.Parameters.AddWithValue("@C_TRIMLEVEL", trimEntry.Text);
            command.Parameters.AddWithValue("@D_DEALER_ID", dealerEntry.Text);
            command.Parameters.AddWithValue("@CUST_ID", customerEntry.Text);
            command.Parameters.AddWithValue("@M_MODEL_ID", modelEntry.Text);

            int newRows = command.ExecuteNonQuery();
            MessageBox.Show(newRows + " rows inserted!");
            SqlConnection.connection.Close();
        }
        

        // Displays the data in SALE_RECORD to show the user the format for values.
        private void AddCars_Load(object sender, EventArgs e)
        {
            SqlConnection.connection.Open();
            string query = "SELECT * FROM CAR";
            MySqlDataAdapter data = new MySqlDataAdapter(query, SqlConnection.connection);
            DataTable dTable = new DataTable();
            data.Fill(dTable);
            newCarData.DataSource = dTable;
            SqlConnection.connection.Close();
        }
    }
}

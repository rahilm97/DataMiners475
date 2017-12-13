using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DealerData_DB
{
    public partial class CarSearch : Form
    {
        public CarSearch()
        {
            InitializeComponent();
        }

        /**
         * The vinButton_CheckChanged method enables search by VIN number search fields.
         * When the radio button is changed the visibility of vinLabel and searchField are
         * changed. If the button is true when the search button is clicked then search is
         * performed based on the vin number search field. This routine services the featureButton
         * as well.
         */
        private void vinButton_CheckedChanged(object sender, EventArgs e)
        {
            vinLabel.Visible = !vinLabel.Visible;
            searchField.Visible = !searchField.Visible;
        }


        /**
         * The modelButton_CheckChanged method enables search by make and model search fields.
         * When the radio button is changed the visibility of make, model and year labels and
         * search fields are changed. If the button is true when the search button is clicked
         * then search is performed based on the make, model and year search fields.
         */
        private void modelButton_CheckedChanged(object sender, EventArgs e)
        {
            modelLabel.Visible = !modelLabel.Visible;
            makeLabel.Visible = !makeLabel.Visible;
            yearLabel.Visible = !yearLabel.Visible;
            searchField.Visible = !searchField.Visible;
            searchField2.Visible = !searchField2.Visible;
            SearchField3.Visible = !SearchField3.Visible;
        }


        /**
         * The priceButton_CheckChanged method enables search by maximum price search fields.
         * When the radio button is changed the visibility of priceLabel and searchField are
         * changed. If the button is true when the search button is clicked then search is
         * performed based on the price search field.
         */
        private void priceButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Visible = !priceLabel.Visible;
            searchField.Visible = !searchField.Visible;
        }

        /**
         * The searchConfirm_Click method is an event handling subroutine for the search button.
         * The method is called when the search button is clicked. The method querys the database
         * to retrieve car data based on the string in the search fields. If the vin button is 
         * checked then a data table is created containing the selected car details for the car
         * with the vin number in searchField. If the model button is checked when search is clicked
         * the a data table is created containing the selected car details for cars in the database with 
         * the make, model, and year contained in searchField, searchField2, and searchField3. Finally, 
         * if the price button is checked when the search button is clicked then a data table is created 
         * that contains the selected car details for cars with a price less than the price in searchField.
         */
        private void searchConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection.connection.Open();
            string query;
            if (vinButton.Checked)
                query = "SELECT * FROM CAR WHERE vin_num = '" + searchField.Text + "'";
            else if (modelButton.Checked)
                query = "SELECT C.vin_num, C.use_status, C.mileage, C.color, C.c_trimlevel, C.d_dealerid, C.cust_id, C.m_id FROM CAR AS C, MODEL AS M WHERE M.model_name = '" +
                    searchField.Text + "' AND M.manufacturer = '" + searchField2.Text + "' AND M.year = '" + SearchField3.Text + "' AND M.m_id = C.m_id";
            else if (priceButton.Checked)
                query = "SELECT * FROM CAR, PRICE WHERE vin_num = P_vin_number AND sale_price < " + int.Parse(searchField.Text);
            else
                query = "SELECT feature FROM CAR, FEATURES WHERE c_trimlevel = F_trim_level AND m_id = F_m_id AND vin_num = '" + searchField.Text + "'";

            MySqlDataAdapter data = new MySqlDataAdapter(query, SqlConnection.connection);
            DataTable dTable = new DataTable();
            data.Fill(dTable);
            searchCarData.DataSource = dTable;
            SqlConnection.connection.Close();
        }
    }
}

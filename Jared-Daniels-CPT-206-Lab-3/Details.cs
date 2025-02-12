using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jared_Daniels_CPT_206_Lab_3
{
    public partial class Details : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\StateDB.mdf;Integrated Security=True";
        private string stateName;

        public Details(string state)
        {
            InitializeComponent();
            stateName = state;
            // Display the selected state name over label at top of form
            lblStateName.Text = $"{stateName} Details:"; 
            LoadStateDetails();
        }

        private void LoadStateDetails()
        {
            // Display the selected state's details in the text boxes
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM States WHERE State = @StateName", conn);
                    cmd.Parameters.AddWithValue("@StateName", stateName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        idTextBox.Text = reader["Id"].ToString();
                        stateTextBox.Text = reader["State"].ToString();
                        populationTextBox.Text = reader["Population"].ToString();
                        flag_DescriptionTextBox.Text = reader["Flag Description"].ToString();
                        state_FlowerTextBox.Text = reader["State Flower"].ToString();
                        state_BirdTextBox.Text = reader["State Bird"].ToString();
                        colorsTextBox.Text = reader["Colors"].ToString();
                        largest_CitiesTextBox.Text = reader["Largest Cities"].ToString();
                        capitalTextBox.Text = reader["Capital"].ToString();
                        median_IncomeTextBox.Text = reader["Median Income"].ToString();
                        computer_Jobs_PercentageTextBox.Text = reader["Computer Jobs Percentage"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading state details: " + ex.Message);
                }
            }
        }

        // Close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

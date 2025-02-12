using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

/*
 * Jared Daniels 
 * CPT 206 A80S
 * Lab 3
 */

namespace Jared_Daniels_CPT_206_Lab_3
{
    public partial class Form1 : Form
    {
        internal static string selectedState;

        public Form1()
        {
            InitializeComponent();
        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.statesTableAdapter.Fill(this.stateDBDataSet.States);

            // Populate the combo box with the states
            foreach (DataRow row in stateDBDataSet.Tables["States"].Rows)
            {
                cmbBxState.Items.Add(row["State"].ToString());
            }
        }

        private void btnStateDetails_Click(object sender, EventArgs e)
        {
            // Check if a state is selected before opening the details form
            if (cmbBxState.SelectedItem != null)
            {
                // Open the details form with the selected state
                string selectedState = cmbBxState.SelectedItem.ToString();
                Details detailsForm = new Details(selectedState);
                detailsForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a state.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Checks which radio button is selected and searches for the selected data
            // Search by ID
            if (rdoBtnID.Checked)
            {
                int id = 0;
                if (int.TryParse(txtBoxSearch.Text, out id))
                {
                    this.statesTableAdapter.SearchByID(this.stateDBDataSet.States, id);
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID.");
                }
            }
            // Search by state
            else if (rdoBtnState.Checked)
            {
                this.statesTableAdapter.SearchByState(this.stateDBDataSet.States, txtBoxSearch.Text);
            }
            // Search by City
            else if (rdoBtnCity.Checked)
            {
                this.statesTableAdapter.SearchByCity(this.stateDBDataSet.States, txtBoxSearch.Text);
            }
            // Search by Flower
            else if (rdoBtnFlower.Checked)
            {
                this.statesTableAdapter.SearchByFlower(this.stateDBDataSet.States, txtBoxSearch.Text);
            }
            // Search by Bird
            else if (rdoBtnBird.Checked)
            {
                this.statesTableAdapter.SearchByBird(this.stateDBDataSet.States, txtBoxSearch.Text);
            }
            // Search by Color
            else if (rdoBtnColor.Checked)
            {
                this.statesTableAdapter.SearchByColors(this.stateDBDataSet.States, txtBoxSearch.Text);
            }
            // Search by Flag
            else if (rdoBtnFlag.Checked)
            {
                this.statesTableAdapter.SearchByFlag(this.stateDBDataSet.States, txtBoxSearch.Text);
            }
            // Ensures a search option is selected
            else
            {
                MessageBox.Show("Please select a search option.");
            }
        }

        // Sorts the data in the data grid view by selected column in ascending order
        private void btnSort_Click(object sender, EventArgs e)
        {
            // Sort by ID
            if (rdoBtnSortID.Checked)
            {
                this.statesTableAdapter.OrderByIDAsc(this.stateDBDataSet.States);
            }
            // Sort by State
            else if (rdoBtnSortState.Checked)
            {
                this.statesTableAdapter.OrderByStateAsc(this.stateDBDataSet.States);
            }
            // Sort by Population
            else if (rdoBtnSortPop.Checked)
            {
                this.statesTableAdapter.OrderByPopulationAsc(this.stateDBDataSet.States);
            }
            // Sort by Capital
            else if (rdoBtnSortCap.Checked)
            {
                this.statesTableAdapter.OrderByCapitalAsc(this.stateDBDataSet.States);
            }
            // Sort by Income
            else if (rdoBtnSortInc.Checked)
            {
                this.statesTableAdapter.OrderByIncomeAsc(this.stateDBDataSet.States);
            }
            // Sort by Jobs
            else if (rdoBtnSortJobs.Checked)
            {
                this.statesTableAdapter.OrderByJobsAsc(this.stateDBDataSet.States);
            }
            // Sort by Flower
            else if (rdoBtnSortFlower.Checked)
            {
                this.statesTableAdapter.OrderByFlowerAsc(this.stateDBDataSet.States);
            }
            // Sort by Bird
            else if (rdoBtnSortBird.Checked)
            {
                this.statesTableAdapter.OrderByBirdAsc(this.stateDBDataSet.States);
            }
            // Sort by Color
            else if (rdoBtnSortColors.Checked)
            {
                this.statesTableAdapter.OrderByColorsAsc(this.stateDBDataSet.States);
            }
            // Sort by Cities
            else if (rdoBtnSortCities.Checked)
            {
                this.statesTableAdapter.OrderByCitiesAsc(this.stateDBDataSet.States);
            }
            // Sort by Flag
            else if (rdoBtnSortFlag.Checked)
            {
                this.statesTableAdapter.OrderByFlagAsc(this.stateDBDataSet.States);
            }
            // Ensures a sort option is selected
            else
            {
                MessageBox.Show("Please select a sort option.");
            }
        }

        // Sort the data in the data grid view by selected column in descending order
        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            // Sort by ID
            if (rdoBtnSortID.Checked)
            {
                this.statesTableAdapter.OrderByIDDesc(this.stateDBDataSet.States);
            }
            // Sort by State
            else if (rdoBtnSortState.Checked)
            {
                this.statesTableAdapter.OrderByStateDesc(this.stateDBDataSet.States);
            }
            // Sort by Population
            else if (rdoBtnSortPop.Checked)
            {
                this.statesTableAdapter.OrderByPopulationDesc(this.stateDBDataSet.States);
            }
            // Sort by Capital
            else if (rdoBtnSortCap.Checked)
            {
                this.statesTableAdapter.OrderByCapitalDesc(this.stateDBDataSet.States);
            }
            // Sort by Income
            else if (rdoBtnSortInc.Checked)
            {
                this.statesTableAdapter.OrderByIncomeDesc(this.stateDBDataSet.States);
            }
            // Sort by Jobs
            else if (rdoBtnSortJobs.Checked)
            {
                this.statesTableAdapter.OrderByJobsDesc(this.stateDBDataSet.States);
            }
            // Sort by Flower
            else if (rdoBtnSortFlower.Checked)
            {
                this.statesTableAdapter.OrderByFlowerDesc(this.stateDBDataSet.States);
            }
            // Sort by Bird
            else if (rdoBtnSortBird.Checked)
            {
                this.statesTableAdapter.OrderByBirdDesc(this.stateDBDataSet.States);
            }
            // Sort by Color
            else if (rdoBtnSortColors.Checked)
            {
                this.statesTableAdapter.OrderByColorsDesc(this.stateDBDataSet.States);
            }
            // Sort by Cities
            else if (rdoBtnSortCities.Checked)
            {
                this.statesTableAdapter.OrderByCitiesDesc(this.stateDBDataSet.States);
            }
            // Sort by Flag
            else if (rdoBtnSortFlag.Checked)
            {
                this.statesTableAdapter.OrderByFlagDesc(this.stateDBDataSet.States);
            }
            // Ensures a sort option is selected
            else
            {
                MessageBox.Show("Please select a sort option.");
            }
        }

        // Filters the data based on the selected choices
        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Check to make sure a filter option and filter operator are selected
            if (cmbBxFilterOption.SelectedItem != null && cmbBxFilterOperator.SelectedItem != null)
            {
                // Filter by Population
                if (cmbBxFilterOption.SelectedItem.ToString() == "Population")
                {
                    // Filter by greater than
                    if (cmbBxFilterOperator.SelectedItem.ToString() == ">")
                    {
                        int population = 0;
                        if (int.TryParse(txtBoxFilter.Text, out population))
                        {
                            this.statesTableAdapter.FilterByPopulationGreaterThan(this.stateDBDataSet.States, population);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid population.");
                        }
                    }
                    // Filter by less than
                    else if (cmbBxFilterOperator.SelectedItem.ToString() == "<")
                    {
                        int population = 0;
                        if (int.TryParse(txtBoxFilter.Text, out population))
                        {
                            this.statesTableAdapter.FilterByPopulationLessThan(this.stateDBDataSet.States, population);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid population.");
                        }
                    }
                    // Filter by equal to
                    else if (cmbBxFilterOperator.SelectedItem.ToString() == "=")
                    {
                        int population = 0;
                        if (int.TryParse(txtBoxFilter.Text, out population))
                        {
                            this.statesTableAdapter.FilterByPopulationEqualTo(this.stateDBDataSet.States, population);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid population.");
                        }
                    }
                }
                // Filter by Median Income
                else if (cmbBxFilterOption.SelectedItem.ToString() == "Median Income")
                {
                    // Filter by greater than
                    if (cmbBxFilterOperator.SelectedItem.ToString() == ">")
                    {
                        int income = 0;
                        if (int.TryParse(txtBoxFilter.Text, out income))
                        {
                            this.statesTableAdapter.FilterByIncomeGreaterThan(this.stateDBDataSet.States, income);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid income.");
                        }
                    }
                    // Filter by less than
                    else if (cmbBxFilterOperator.SelectedItem.ToString() == "<")
                    {
                        int income = 0;
                        if (int.TryParse(txtBoxFilter.Text, out income))
                        {
                            this.statesTableAdapter.FilterByIncomeLessThan(this.stateDBDataSet.States, income);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid income.");
                        }
                        // Filter by equal to
                    }
                    else if (cmbBxFilterOperator.SelectedItem.ToString() == "=")
                    {
                        int income = 0;
                        if (int.TryParse(txtBoxFilter.Text, out income))
                        {
                            this.statesTableAdapter.FilterByIncomeEqualTo(this.stateDBDataSet.States, income);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid income.");
                        }
                    }
                }
                // Filter by computer related jobs
                if (cmbBxFilterOption.SelectedItem.ToString() == "Computer Jobs")
                {
                    // Filter by greater than
                    if (cmbBxFilterOperator.SelectedItem.ToString() == ">")
                    {
                        int jobs = 0;
                        if (int.TryParse(txtBoxFilter.Text, out jobs))
                        {
                            this.statesTableAdapter.FilterByComputerJobsGreaterThan(this.stateDBDataSet.States, jobs);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid number of computer jobs.");
                        }
                    }
                    // Filter by less than
                    else if (cmbBxFilterOperator.SelectedItem.ToString() == "<")
                    {
                        int jobs = 0;
                        if (int.TryParse(txtBoxFilter.Text, out jobs))
                        {
                            this.statesTableAdapter.FilterByComputerJobsLessThan(this.stateDBDataSet.States, jobs);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid number of computer jobs.");
                        }
                    }
                    // Filter by equal to
                    else if (cmbBxFilterOperator.SelectedItem.ToString() == "=")
                    {
                        int jobs = 0;
                        if (int.TryParse(txtBoxFilter.Text, out jobs))
                        {
                            this.statesTableAdapter.FilterByComputerJobsEqualTo(this.stateDBDataSet.States, jobs);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid number of computer jobs.");
                        }
                    }
                }
            }
            // Ensures a filter option and filter operator are selected
            else
            {
                MessageBox.Show("Please select a filter option and filter operator.");
            }
        }

        // Close form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

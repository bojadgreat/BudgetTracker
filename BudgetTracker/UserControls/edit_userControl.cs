using BudgetTracker.cashFlowDataSetTableAdapters;
using BudgetTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker.UserControls
{
    public partial class edit_userControl : UserControl
    {
        public edit_userControl()
        {
            InitializeComponent();

            // Create a new instance of the cashFlowDataSet for fetching
            cashFlowDataSet cfds = new cashFlowDataSet();

            // Initialize the TableAdapter
            cash_flow_tableTableAdapter tableAdapter = new cash_flow_tableTableAdapter();

            // Call Fill() method on the TableAdapter to populate the dataset
            tableAdapter.Fill(cfds.cash_flow_table);

            var eId = cfds.cash_flow_table.Select(t => t.Flow_ID).ToList();

            entryEdit_id_cBox.Items.Clear();
            entryEdit_id_cBox.Items.AddRange(eId.Cast<object>().ToArray());
        }

        private void user_edit_button_Click(object sender, EventArgs e)
        {

        }

        private void user_cancel_button_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void entryEdit_id_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entryEdit_id_cBox.SelectedItem != null)
            {
                // Assuming the ComboBox is holding integer values in its items
                int id = Convert.ToInt32(entryEdit_id_cBox.SelectedItem.ToString());

                // Create a new instance of the cashFlowDataSet for fetching
                cashFlowDataSet cfds = new cashFlowDataSet();

                // Initialize the TableAdapter
                cash_flow_tableTableAdapter tableAdapter = new cash_flow_tableTableAdapter();

                // Call Fill() method on the TableAdapter to populate the dataset
                tableAdapter.Fill(cfds.cash_flow_table);

                var flowData = new cashflow_model
                {
                    flow_amount = (float)cfds.cash_flow_table
                                        .Where(t => t.Flow_ID == id)
                                        .Select(t => t.Flow_amount)
                                        .FirstOrDefault(),
                    flow_description = cfds.cash_flow_table
                                        .Where(t => t.Flow_ID == id)
                                        .Select(t => t.Flow_description)
                                        .FirstOrDefault(),
                    flow_type = cfds.cash_flow_table
                                        .Where(t => t.Flow_ID == id)
                                        .Select(t => t.Flow_type)
                                        .FirstOrDefault(),
                    flow_datetime = cfds.cash_flow_table
                                        .Where(t => t.Flow_ID == id)
                                        .Select(t => t.Flow_datetime)
                                        .FirstOrDefault(),
                    flow_timestamp = cfds.cash_flow_table
                                        .Where(t => t.Flow_ID == id)
                                        .Select(t => t.Flow_timestamp)
                                        .FirstOrDefault()
                };

                // Set the description in the TextBox
                edit_descTB.Text = flowData.flow_description;
                // Set the type in the TextBox
                edit_typeCbox.Text = flowData.flow_type;
                // Set the description in the TextBox
                edit_dateDTP.Value = flowData.flow_datetime;
                // Set the amount in the TextBox
                edit_amtTB.Text = flowData.flow_amount.ToString();
            }
            else
            {
                MessageBox.Show("Please select a valid Flow ID.");
            }
        }
    }
}

using BudgetTracker.cashFlowDataSetTableAdapters;
using BudgetTracker.Models;
using BudgetTracker.Utilities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BudgetTracker.UserControls
{
    public partial class edit_userControl : UserControl
    {
        public edit_userControl()
        {
            InitializeComponent();

            var cfds = DBUtil.Get_cfds();

            var eId = cfds.cash_flow_table.Select(t => t.Flow_ID).ToList();

            entryEdit_id_cBox.Items.Clear();
            entryEdit_id_cBox.Items.AddRange(eId.Cast<object>().ToArray());
        }

        private void user_edit_button_Click(object sender, EventArgs e)
        {
            DBUtil db = new DBUtil();

            var e_edit = db.GetCashFlowData();
            
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

                var flowData = new cashflow_model();

                flowData.SetEditFlowAmount((float)cfds.cash_flow_table
                                    .Where(t => t.Flow_ID == id)
                                    .Select(t => t.Flow_amount)
                                    .FirstOrDefault());
                
                flowData.SetEditFlowDescription(cfds.cash_flow_table
                                        .Where(t => t.Flow_ID == id)
                                        .Select(t => t.Flow_description)
                                        .FirstOrDefault());

                flowData.SetEditFlowType(cfds.cash_flow_table
                                        .Where(t => t.Flow_ID == id)
                                        .Select(t => t.Flow_type)
                                        .FirstOrDefault());

                flowData.SetEditFlowDatetime(cfds.cash_flow_table
                                        .Where(t => t.Flow_ID == id)
                                        .Select(t => t.Flow_datetime)
                                        .FirstOrDefault());

                flowData.SetEditFlowTimestamp(cfds.cash_flow_table
                                    .Where(t => t.Flow_ID == id)
                                    .Select(t => t.Flow_timestamp)
                                    .FirstOrDefault());

                // Set the description in the TextBox
                edit_descTB.Text = flowData.flow_description;
                // Set the type in the TextBox
                edit_typeCbox.Text = flowData.flow_type;
                // Set the description in the TextBox
                edit_dateDTP.Value = flowData.flow_datetime.Date;
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

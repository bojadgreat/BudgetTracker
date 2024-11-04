using BudgetTracker.cashFlowDataSetTableAdapters;
using BudgetTracker.cashFlowHistDataSetTableAdapters;
using BudgetTracker.cashFlowHistoryDataSetTableAdapters;
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
            var e_edit = new cashflow_model();

            // Assuming the ComboBox is holding integer values in its items
            int id = Convert.ToInt32(entryEdit_id_cBox.SelectedItem.ToString());

            // Validate description
            if (!e_edit.SetFlowDescription(edit_descTB.Text))
            {
                return; // Stop execution if invalid
            }

            // Validate type
            if (!e_edit.SetFlowType(entryEdit_id_cBox.Text))
            {
                return; // Stop execution if invalid
            }

            // Validate amount
            if (!e_edit.SetFlowAmount(edit_amtTB.Text))
            {
                return; // Stop execution if invalid
            }

            e_edit.SetEditFlowDescription(edit_descTB.Text);
            e_edit.SetEditFlowType(edit_typeCbox.SelectedItem.ToString());
            e_edit.SetEditFlowDatetime(edit_dateDTP.Value);
            e_edit.SetEditFlowTimestamp(DateTime.Now);

            if (e_edit.flow_type == "Expense")
            {
                e_edit.SetExpenseFlowAmount(edit_amtTB.Text);
            }
            else
            {
                e_edit.SetEditFlowAmount((float)Convert.ToDouble(edit_amtTB.Text));
            }

            try
            {
                cash_flow_tableTableAdapter cflow = new cash_flow_tableTableAdapter();
                //cash_flow_historyTableAdapter chist = new cash_flow_historyTableAdapter();
                cash_flow_histTableAdapter cHist = new cash_flow_histTableAdapter();

                // Add new entry to the database
                cflow.Update(e_edit.flow_description, e_edit.flow_amount, e_edit.flow_type, e_edit.flow_datetime, e_edit.flow_timestamp, id);

                //Add new entry to history database
                cHist.Insert(e_edit.flow_description, e_edit.flow_amount, e_edit.flow_datetime, DateTime.Now, "EDIT ENTRY", e_edit.flow_type);

                MessageBox.Show("Entry edited successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void user_cancel_button_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();

            // Bring the dashboard back to normal
            Dashboard dashboard = Application.OpenForms["Dashboard"] as Dashboard;
            if (dashboard != null)
            {
                dashboard.WindowState = FormWindowState.Normal;
            }
        }

        private void entryEdit_id_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entryEdit_id_cBox.SelectedItem != null)
            {
                // Assuming the ComboBox is holding integer values in its items
                int id = Convert.ToInt32(entryEdit_id_cBox.SelectedItem.ToString());

                DBUtil db = new DBUtil();

                // Create a new instance of the cashFlowDataSet for fetching
                cashFlowDataSet cfds = DBUtil.Get_cfds();

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

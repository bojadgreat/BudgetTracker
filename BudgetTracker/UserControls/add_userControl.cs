using BudgetTracker.cashFlowDataSetTableAdapters;
using BudgetTracker.cashFlowHistDataSetTableAdapters;
using BudgetTracker.Forms;
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
    public partial class add_userControl : UserControl
    {
        public add_userControl()
        {
            InitializeComponent();
        }

        private void user_cancel_button_Click(object sender, EventArgs e)
        {
            Form tmp = FindForm();
            tmp.Close();
            tmp.Dispose();

            // Bring the dashboard back to normal
            if (Application.OpenForms["Dashboard"] is Dashboard dashboard)
            {
                dashboard.WindowState = FormWindowState.Normal;
            }
        }

        private void user_add_button_Click(object sender, EventArgs e)
        {
            var new_ent = new Models.cashflow_model();

            // Validate description
            if (!new_ent.SetFlowDescription(add_descTB.Text))
            {
                return; // Stop execution if invalid
            }

            // Validate type
            if (!new_ent.SetFlowType(add_typeCbox.Text))
            {
                return; // Stop execution if invalid
            }

            // Validate amount
            if (!new_ent.SetFlowAmount(add_amtTB.Text))
            {
                return; // Stop execution if invalid
            }

            new_ent.SetFlowDescription(add_descTB.Text);
            new_ent.SetFlowAmount(add_amtTB.Text);
            new_ent.SetFlowDatetime(add_dateDTP.Value);
            new_ent.SetFlowType(add_typeCbox.Text);
            
            if(new_ent.flow_type == "Expense")
            {
                new_ent.SetExpenseFlowAmount(add_amtTB.Text);
            }

            try
            {
                cash_flow_tableTableAdapter cflow = new cash_flow_tableTableAdapter();
                cash_flow_historyTableAdapter chist = new cash_flow_historyTableAdapter();
                
                
                // Add new entry to the database
                cflow.Insert(new_ent.flow_description, new_ent.flow_amount, new_ent.flow_type, new_ent.flow_datetime, DateTime.Now);

                //Add new entry to history database
                chist.Insert(new_ent.flow_description, new_ent.flow_amount, new_ent.flow_datetime, DateTime.Now, "ADD ENTRY", new_ent.flow_type);

                MessageBox.Show("Entry added successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                add_descTB.Text = "";
                add_amtTB.Text = "";
                add_dateDTP.Value = DateTime.Now;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

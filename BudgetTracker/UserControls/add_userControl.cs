using BudgetTracker.cashFlowDataSetTableAdapters;
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
            add_descTB.Text = "";
            add_amtTB.Text = "";
            add_dateDTP.Value = DateTime.Now;
        }

        private void user_add_button_Click(object sender, EventArgs e)
        {
            var new_ent = new Models.cashflow_model();
            new_ent.flow_description = add_descTB.Text;
            new_ent.flow_amount = (float)Convert.ToDouble(add_amtTB.Text);
            new_ent.flow_datetime = add_dateDTP.Value;
            new_ent.flow_type = add_typeCbox.Text;

            try
            {
                cash_flow_tableTableAdapter cflow = new cash_flow_tableTableAdapter();
                // Add new entry to the database
                cflow.Insert(new_ent.flow_description, new_ent.flow_amount, new_ent.flow_type, new_ent.flow_datetime, DateTime.Now);

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

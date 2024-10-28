﻿using BudgetTracker.cashFlowHistDataSetTableAdapters;
using BudgetTracker.cashFlowHistoryDataSetTableAdapters;
using BudgetTracker.Utilities;
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
    public partial class history_userControl : UserControl
    {
        public history_userControl()
        {
            InitializeComponent();
            loadcBox();
            if(hist_date_cbox.Text != "")
            {
                loadTable();
            }
            
        }

        private void loadcBox()
        {
            hist_date_cbox.Items.Clear();
            cashFlowDataSet cfds = DBUtil.Get_cfds();
            hist_date_cbox.Items.Add("All Time");
            
            var hist_date = cfds.cash_flow_table.Select(t => t.Flow_datetime).ToList();

            hist_date_cbox.Items.AddRange(hist_date.Cast<object>().ToArray());
        }
        
        private void loadTable()
        {
            //cashFlowHistDataSet cfhs = DBUtil.Get_cfhs();
            cash_flow_histTableAdapter cfht = new cash_flow_histTableAdapter();
            
            DataTable dataTable = cfht.GetData();

            var filteredData = dataTable.AsEnumerable().Select(t => t);     

            if (hist_date_cbox.Text == "All Time")
            {
                filteredData = dataTable.AsEnumerable().Select(t => t);
            }
            else
            {
                DateTime date = Convert.ToDateTime(hist_date_cbox.Text);
                filteredData = dataTable.AsEnumerable().Where(t => t.Field<DateTime>("Flow_datetime").Date == date);
            }
            

            

            if (filteredData.Any())
            {
                hist_dgv.DataSource = filteredData.OrderBy(t => t.Field<DateTime>("Flow_datetime")).CopyToDataTable();

                dgvSetHeadTextColumn("Entry ID", 0, hist_dgv);
                dgvSetHeadTextColumn("Entry Description", 1, hist_dgv);
                dgvSetHeadTextColumn("Entry Amount", 2, hist_dgv);
                dgvSetHeadTextColumn("Entry Date", 3, hist_dgv);
                dgvSetHeadTextColumn("Entry Timestamp", 4, hist_dgv);
                dgvSetHeadTextColumn("Entry Operation", 5, hist_dgv);
                dgvSetHeadTextColumn("Entry Type", 6, hist_dgv);
            }
            else
            {
                hist_dgv.DataSource = null;
            }
        }

        private void dgvSetHeadTextColumn(string headText, int colInd, DataGridView dgvCol)
        {
            dgvCol.Columns[colInd].HeaderText = headText;
        }
    }
}

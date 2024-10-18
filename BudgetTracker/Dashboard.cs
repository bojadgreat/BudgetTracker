using BudgetTracker.cashFlowDataSetTableAdapters;
using BudgetTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BudgetTracker
{
    public partial class Dashboard : Form
    {
        
        

        public Dashboard()
        {
            InitializeComponent();
            date_label.Text = DateTime.Now.ToString("yyyy-MM-dd");
            updateClock();
        }
        
        private async void updateClock()
        {
            while (true)
            {
                // Update the label with the current time (hours, minutes, seconds)
                time_label.Text = DateTime.Now.ToString("HH:mm:ss");  // 24-hour format with seconds

                // Wait for 1 second before updating again (non-blocking)
                await Task.Delay(1000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reloadData();
        }

        private void dgvSetHeadTextColumn(string headText, int colInd, DataGridView dgvCol)
        {
            dgvCol.Columns[colInd].HeaderText = headText;
        }
        
        //chart initialization
        private void initialize_chart(List<date_total> dateTotals, List<date_income> dateIncome, List<date_expense> dateExpense)
        {
            Series ser1 = cashFlowChart.Series["Remaining Balance"];
            Series ser2 = cashFlowChart.Series["Income"];
            Series ser3 = cashFlowChart.Series["Expenses"];

            ser1.Points.Clear();
            ser2.Points.Clear();
            ser3.Points.Clear();

            // Add data points to remaining balance
            foreach (var data in dateTotals)
            {
                ser1.Points.AddXY(data.ent_date, data.ent_tot_amount); // X is date, Y is total
            }

            // Add data points to income
            foreach (var data in dateIncome)
            {
                ser2.Points.AddXY(data.ent_date, data.ent_inc_amount); // X is date, Y is total
            }

            // Add data points to expenses
            foreach (var data in dateExpense)
            {
                ser3.Points.AddXY(data.ent_date, data.ent_exp_amount); // X is date, Y is total
            }

            // Optionally, format the chart axes.
            cashFlowChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy"; // Format X-axis labels as dates
            cashFlowChart.ChartAreas[0].AxisX.Title = "Date";
            cashFlowChart.ChartAreas[0].AxisY.Title = "Amount";

            // Recalculate axis scale based on the new data
            cashFlowChart.ChartAreas[0].RecalculateAxesScale();
        }
        

        private List<date_total> chartTotal()
        {
            cashFlowDataSet cfds = new cashFlowDataSet();

            // Initialize the TableAdapter
            cash_flow_tableTableAdapter tableAdapter = new cash_flow_tableTableAdapter();

            // Call Fill() method on the TableAdapter to populate the dataset
            tableAdapter.Fill(cfds.cash_flow_table);  // This is where the data is fetched

            List<date_total> date_Totals = new List<date_total>();

            var groupedData = cfds.cash_flow_table
                .GroupBy(t => t.Flow_datetime.Date)  // Group by date
                .Select(g => new date_total
                {
                    ent_date = g.Key,                // The date
                    ent_tot_amount = (float)g.Sum(t => t.Flow_amount) // Sum the Flow_amount for that date
                })
                .ToList();

            // Add all the grouped data to the date_Totals list.
            date_Totals.AddRange(groupedData);
            
            return date_Totals;
        }

        private List<date_income> chartInc()
        {
            cashFlowDataSet cfds = new cashFlowDataSet();

            // Initialize the TableAdapter
            cash_flow_tableTableAdapter tableAdapter = new cash_flow_tableTableAdapter();

            // Call Fill() method on the TableAdapter to populate the dataset
            tableAdapter.Fill(cfds.cash_flow_table);  // This is where the data is fetched

            List<date_income> date_Income = new List<date_income>();

            var groupedData = cfds.cash_flow_table
                .GroupBy(t => t.Flow_datetime.Date)  // Group by date
                .Select(g => new date_income
                {
                    ent_date = g.Key,                // The date
                    ent_inc_amount = (float)g.Where(t => t.Flow_type == "Income").Sum(t => t.Flow_amount) // Sum the Flow_amount for that date and type
                })
                .ToList();

            // Add all the grouped data to the date_Totals list.
            date_Income.AddRange(groupedData);

            return date_Income;
        }

        private List<date_expense> chartExp()
        {
            cashFlowDataSet cfds = new cashFlowDataSet();

            // Initialize the TableAdapter
            cash_flow_tableTableAdapter tableAdapter = new cash_flow_tableTableAdapter();

            // Call Fill() method on the TableAdapter to populate the dataset
            tableAdapter.Fill(cfds.cash_flow_table);  // This is where the data is fetched

            List<date_expense> date_Expense = new List<date_expense>();

            var groupedData = cfds.cash_flow_table
                .GroupBy(t => t.Flow_datetime.Date)  // Group by date
                .Select(g => new date_expense
                {
                    ent_date = g.Key,                // The date
                    ent_exp_amount = ((float)g.Where(t => t.Flow_type == "Expense").Sum(t => t.Flow_amount)) * -1 // Sum the Flow_amount for that date and type
                })
                .ToList();

            // Add all the grouped data to the date_Totals list.
            date_Expense.AddRange(groupedData);

            return date_Expense;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            var menuForm = new Forms.menu_form("add");
            menuForm.Show();
            menuForm.FormClosed += (s, ev) => reloadData();
        }
        
        private void reloadData()
        {
            cash_flow_tableTableAdapter cft = new cash_flow_tableTableAdapter();
            cash_flowDataGridView.DataSource = cft.GetData();

            dgvSetHeadTextColumn("Entry ID", 0, cash_flowDataGridView);
            dgvSetHeadTextColumn("Entry Description", 1, cash_flowDataGridView);
            dgvSetHeadTextColumn("Entry Amount", 2, cash_flowDataGridView);
            dgvSetHeadTextColumn("Entry Date", 3, cash_flowDataGridView);
            dgvSetHeadTextColumn("Entry Timestamp", 4, cash_flowDataGridView);

            initialize_chart(chartTotal(), chartInc(), chartExp());
        }
    }
}

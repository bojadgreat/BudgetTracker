using BudgetTracker.cashFlowDataSetTableAdapters;
using BudgetTracker.cashFlowHistDataSetTableAdapters;
using BudgetTracker.cashFlowHistoryDataSetTableAdapters;
using BudgetTracker.Models;
using BudgetTracker.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BudgetTracker
{
    public partial class Dashboard : Form
    {
        private Timer _weatherTimer;

        public Dashboard()
        {
            InitializeComponent();
            date_label.Text = DateTime.Now.ToString("yyyy-MM-dd");
            updateClock();
            updateWeather();

            // Initialize the timer for updating weather data every 24 hours
            _weatherTimer = new Timer
            {
                Interval = 24 * 60 * 60 * 1000 // 24 hours in milliseconds
            };
            _weatherTimer.Tick += (sender, args) => updateWeather();
            _weatherTimer.Start();
        }

        #region DASHBOARD FUNCTIONALITY
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

        private async void updateWeather()
        {
            DotNetEnv.Env.Load();
            var client = new HttpClient();
            var url = "http://api.openweathermap.org/data/2.5/weather?q=Mandaue&appid=f4aedc6e88fbcf8053f75317d9fc7c23&units=metric";

            try
            {
                var weatherResponse = await client.GetStringAsync(url);
                var weatherData = JsonConvert.DeserializeObject<Weather>(weatherResponse);

                string comString = weatherData.Main.Temp.ToString() + " °C " + weatherData.WeatherDetails[0].Description.ToUpper();
                tempLabel.Text = comString;
                string cityString = weatherData.Name.ToString() + " City";
                cityLabel.Text = cityString;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching weather data: " + ex.Message); 
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            reloadData();
        }

        private void dgvSetHeadTextColumn(string headText, int colInd, DataGridView dgvCol)
        {
            dgvCol.Columns[colInd].HeaderText = headText;
        }

        private void reloadData()
        {
            cash_flow_tableTableAdapter cft = new cash_flow_tableTableAdapter();
            DataTable dataTable = cft.GetData();

            var filteredData = dataTable.AsEnumerable().Where(t => t.Field<DateTime>("Flow_datetime").Month == DateTime.Now.Month);


            if (filteredData.Any())
            {
                cash_flowDataGridView.DataSource = filteredData.OrderBy(t => t.Field<DateTime>("Flow_datetime")).CopyToDataTable();

                dgvSetHeadTextColumn("Entry ID", 0, cash_flowDataGridView);
                dgvSetHeadTextColumn("Entry Description", 1, cash_flowDataGridView);
                dgvSetHeadTextColumn("Entry Amount", 2, cash_flowDataGridView);
                dgvSetHeadTextColumn("Entry Type", 3, cash_flowDataGridView);
                dgvSetHeadTextColumn("Entry Date", 4, cash_flowDataGridView);
                dgvSetHeadTextColumn("Entry Timestamp", 5, cash_flowDataGridView);
            }
            else
            {
                cash_flowDataGridView.DataSource = null;
            }



            initialize_chart(chartTotal(), chartInc(), chartExp());
        }

        private void cash_flowDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clear previous row highlighting
            foreach (DataGridViewRow row in cash_flowDataGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White; // or any default color
            }

            // Highlight the current row
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                cash_flowDataGridView.Rows[cash_flowDataGridView.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.LightSkyBlue; // Highlight color
            }
        }
        #endregion

        #region CHART
        //chart initialization
        private void initialize_chart(List<date_total> dateTotals, List<date_income> dateIncome, List<date_expense> dateExpense)
        {
            //// Add data points to remaining balance
            //foreach (var data in dateTotals)
            //{
            //    ser1.Points.AddXY(data.ent_date, Math.Abs(data.ent_exp_amount + data.ent_inc_amount)); // X is date, Y is total
            //}


            cashFlowChart.Series["Report"].Points.Clear();
            cashFlowChart.Series["Report"].IsValueShownAsLabel = true;
            
            if(!dateIncome.Any() && !dateExpense.Any())
            {
                return;
            }
            else
            {
                foreach (var data in dateTotals)
                {
                    cashFlowChart.Series["Report"].Points.AddXY("Remaining Balance", $"{data.rem_total:0.00}");
                }

                // Add data points to income
                foreach (var data in dateIncome)
                {
                    cashFlowChart.Series["Report"].Points.AddXY($"Total Income for {DateTime.Now.ToString("MMMM")}", $"{data.tot_inc:0.00}");
                }

                // Add data points to expenses
                foreach (var data in dateExpense)
                {
                    cashFlowChart.Series["Report"].Points.AddXY($"Total Expenses for {DateTime.Now.ToString("MMMM")}", $"{data.tot_exp:0.00}");
                }
            }
            
            

            // Optionally, format the chart axes.
            //cashFlowChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy"; // Format X-axis labels as dates
            //cashFlowChart.ChartAreas[0].AxisX.Title = "Date";
            //cashFlowChart.ChartAreas[0].AxisY.Title = "Amount";

            //cashFlowChart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            //cashFlowChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            cashFlowChart.Titles[0].Text = $"Report for the month of {DateTime.Now.ToString("MMMM")}";
            //ser2.LegendText = "Total Income for this month";
            //ser3.LegendText = "Total Expenses for this month"; 

            // Recalculate axis scale based on the new data
            cashFlowChart.ChartAreas[0].RecalculateAxesScale();

            cashFlowChart.Invalidate();
        }
        

        private List<date_total> chartTotal()
        {
            var cfds = DBUtil.Get_cfds();

            List<date_total> date_Totals = new List<date_total>();

            // Variables to track running totals
            //float runningIncome = 0;
            //float runningExpenses = 0;
            
            
            //DateTime today = DateTime.Now;
            //DateTime fourDaysAgo = today.AddDays(-4);


            date_total dt = new date_total
            {
                rem_total = (float)cfds.cash_flow_table
                .Sum(t => t.Flow_amount)
            };
            
            //.GroupBy(t => t.Flow_datetime.Date)  // Group by date
            //.Select(g => new date_total
            //{
            //    ent_date = g.Key,  // The date
            //    // Calculate the sum for income and expenses separately
            //    ent_inc_amount = (float)g.Where(t => t.Flow_type == "Income").Sum(t => t.Flow_amount),    // Income (positive flow)
            //    ent_exp_amount = (float)g.Where(t => t.Flow_type == "Expense").Sum(t => t.Flow_amount)   // Expenses (negative flow)
            //})
            //.OrderBy(dt => dt.ent_date)  // Order by date to ensure the correct running total sequence
            //.ToList();

            //// Calculate the running totals and update the list
            //foreach (var entry in groupedData)
            //{
            //    runningIncome += entry.ent_inc_amount;
            //    runningExpenses += entry.ent_exp_amount;

            //    date_Totals.Add(new date_total
            //    {
            //        //ent_date = entry.ent_date,
            //        ent_inc_amount = runningIncome,    // Cumulative income
            //        ent_exp_amount = runningExpenses // Cumulative expenses
            //    });
            //}

            date_Totals.Add(dt);

            return date_Totals;
        }

        private List<date_income> chartInc()
        {
            var cfds = DBUtil.Get_cfds();

            List<date_income> date_Income = new List<date_income>();

            //DateTime today = DateTime.Now;
            //DateTime fourDaysAgo = today.AddDays(-4);

            date_income di = new date_income
            {
                tot_inc = (float)cfds.cash_flow_table
                .Where(t => t.Flow_datetime.Month == DateTime.Now.Month && t.Flow_type == "Income")
                .Sum(t => t.Flow_amount)
            };

            //var groupedData = cfds.cash_flow_table
            //    //.Where(t => t.Flow_datetime >= fourDaysAgo)
            //    .GroupBy(t => t.Flow_datetime.Date)  // Group by date
            //    .Select(g => new date_income
            //    {
            //        ent_date = g.Key,                // The date
            //        ent_inc_amount = (float)g.Where(t => t.Flow_type == "Income").Sum(t => t.Flow_amount) // Sum the Flow_amount for that date and type
            //    })
            //    .ToList();

            // Add all the grouped data to the date_Totals list.
            if(di.tot_inc != 0)
            {
                date_Income.Add(di);
            }
            
            return date_Income;
        }

        private List<date_expense> chartExp()
        {
            var cfds = DBUtil.Get_cfds();

            List<date_expense> date_Expense = new List<date_expense>();

            date_expense de = new date_expense
            {
                tot_exp = (float)cfds.cash_flow_table
                .Where(t => t.Flow_datetime.Month == DateTime.Now.Month && t.Flow_type == "Expense")
                .Sum(t => t.Flow_amount) * -1
            };

            //DateTime today = DateTime.Now;
            //DateTime fourDaysAgo = today.AddDays(-4);

            //var groupedData = cfds.cash_flow_table
            //    //.Where(t => t.Flow_datetime >= fourDaysAgo)
            //    .GroupBy(t => t.Flow_datetime.Date)  // Group by date
            //    .Select(g => new date_expense
            //    {
            //        ent_date = g.Key,                // The date
            //        ent_exp_amount = ((float)g.Where(t => t.Flow_type == "Expense").Sum(t => t.Flow_amount)) * -1 // Sum the Flow_amount for that date and type
            //    })
            //    .ToList();

            // Add all the grouped data to the date_Totals list.
            
            if(de.tot_exp != 0)
            {
                date_Expense.Add(de);
            }
            

            return date_Expense;
        }
        #endregion

        #region ADD
        private void add_button_Click(object sender, EventArgs e)
        {
            var menuForm = new Forms.menu_form("add");
            menuForm.Show();
            menuForm.FormClosed += (s, ev) => reloadData();
        }
        #endregion

        #region EDIT
        private void edit_button_Click(object sender, EventArgs e)
        {
            var menuForm = new Forms.menu_form("edit");
            menuForm.Show();
            menuForm.FormClosed += (s, ev) => reloadData();
        }
        #endregion

        #region DELETE
        private void delete_cashflow_Click(object sender, EventArgs e)
        {
            cashflow_history_model cfhm = new cashflow_history_model();

            var idSelected = cash_flowDataGridView.CurrentRow.Cells[0].Value;

            var cfds = DBUtil.Get_cfds();

            var cSelected = cfds.cash_flow_table.Where(t => t.Flow_ID == Convert.ToInt32(idSelected)).Select(t => t).ToList();
            
            foreach (var sel in cSelected)
            {
                cfhm.flow_id = sel.Flow_ID;
                cfhm.flow_description = sel.Flow_description;
                cfhm.flow_amount = (float)sel.Flow_amount;
                cfhm.flow_datetime = sel.Flow_datetime;
                cfhm.flow_type = sel.Flow_type;
                cfhm.flow_timestamp = sel.Flow_timestamp;
            }
            
            DialogResult dialogResult = MessageBox.Show("Do you want to delete selected entry?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    cash_flow_tableTableAdapter cflow = new cash_flow_tableTableAdapter();
                    //cash_flow_historyTableAdapter chist = new cash_flow_historyTableAdapter();
                    cash_flow_histTableAdapter cHist = new cash_flow_histTableAdapter();

                    // Add new entry to the database
                    cflow.Delete(Convert.ToInt32(idSelected));
                    //Add new entry to history database
                    cHist.Insert(cfhm.flow_description, cfhm.flow_amount, cfhm.flow_datetime, DateTime.Now, "DELETE ENTRY", cfhm.flow_type);

                    MessageBox.Show("Entry deleted successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    reloadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region HISTORY
        private void history_button_Click(object sender, EventArgs e)
        {
            var menuForm = new Forms.menu_form("history");
            menuForm.Show();
            menuForm.FormClosed += (s, ev) => reloadData();
        }
        #endregion
    }
}

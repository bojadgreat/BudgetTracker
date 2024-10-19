using BudgetTracker.cashFlowDataSetTableAdapters;
using BudgetTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Utilities
{
    internal class DBUtil
    {
        // Private field to hold the cashflow_model data
        private cashflow_model _cfds;

        // Public getter method to return the cashflow_model data
        public cashflow_model GetCashFlowData()
        {
            if (_cfds == null)  // Only fetch if not already fetched
            {
                _cfds = FetchCashFlowData();
            }
            return _cfds;
        }

        // Method to fetch data from the dataset and return a cashflow_model instance
        private cashflow_model FetchCashFlowData()
        {
            var cfds = Get_cfds();

            // Select the first record in the table and populate cashflow_model
            var flowData = new cashflow_model();
            
            flowData.SetFlowAmount((float?)cfds.cash_flow_table
                                .Select(t => (float)t.Flow_amount)
                                .FirstOrDefault() ?? 0); // Handle nulls
            flowData.SetFlowDescription(cfds.cash_flow_table
                                .Select(t => t.Flow_description)
                                .FirstOrDefault());
            flowData.SetFlowType(cfds.cash_flow_table
                                .Select(t => t.Flow_type)
                                .FirstOrDefault());
            flowData.SetFlowDatetime(cfds.cash_flow_table
                                .Select(t => t.Flow_datetime)
                                .FirstOrDefault());
            flowData.SetFlowTimestamp(cfds.cash_flow_table
                                .Select(t => t.Flow_timestamp)
                                .FirstOrDefault());

            return flowData;
        }
        
        public static cashFlowDataSet Get_cfds()
        {
            // Create a new instance of the cashFlowDataSet for fetching
            cashFlowDataSet cfds = new cashFlowDataSet();

            // Initialize the TableAdapter
            cash_flow_tableTableAdapter tableAdapter = new cash_flow_tableTableAdapter();

            // Call Fill() method on the TableAdapter to populate the dataset
            tableAdapter.Fill(cfds.cash_flow_table);

            return cfds;
        }
        
        public static void Set_cfds(cashflow_model cfmodel)
        {
            var cfds_set = Get_cfds();

            cfds_set.cash_flow_table.Select(t => t.Flow_description);
        }
    }
}

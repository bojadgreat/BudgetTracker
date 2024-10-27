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
        }
        
        public void loadcBox()
        {
            hist_date_cbox.Items.Clear();
            cashFlowDataSet cfds = DBUtil.Get_cfds();
            hist_date_cbox.Items.Add("All Time");
            
            var hist_date = cfds.cash_flow_table.Select(t => t.Flow_datetime).ToList();

            hist_date_cbox.Items.AddRange(hist_date.Cast<object>().ToArray());
        }
        
        
    }
}

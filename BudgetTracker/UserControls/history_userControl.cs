﻿using System;
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
        }
        
        public void loadcBox()
        {
            hist_date_cbox.Items.Clear();
            
        }
    }
}

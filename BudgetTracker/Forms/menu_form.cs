using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker.Forms
{
    public partial class menu_form : Form
    {
        public menu_form(string title_type)
        {
            InitializeComponent();
            // Add user controls to the menu panel
            switch (title_type)
            {
                case "add":
                    UserControls.add_userControl user_add = new UserControls.add_userControl();
                    addUserControl(user_add);
                    break;
                case "delete":
                    UserControls.delete_userControl user_delete = new UserControls.delete_userControl();
                    addUserControl(user_delete);
                    break;
                case "edit":
                    UserControls.edit_userControl user_edit = new UserControls.edit_userControl();
                    addUserControl(user_edit);
                    break;
                case "history":
                    UserControls.history_userControl user_hist = new UserControls.history_userControl();
                    addUserControl(user_hist);
                    break;
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            menu_panel.Controls.Clear();
            menu_panel.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}

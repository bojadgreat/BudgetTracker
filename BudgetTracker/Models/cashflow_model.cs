using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker.Models
{
    internal class cashflow_model
    {
        public int id {  get; private set; }
        public string flow_description {  get; private set; }
        public string flow_type { get; private set; }
        public float flow_amount { get; private set; }
        public DateTime flow_datetime {  get; private set; }
        public DateTime flow_timestamp { get; private set; }

        // Setter method for flow_description
        public bool SetFlowDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please input description", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                flow_description = description;
                return true;
            }
        }

        // Setter method for flow_type
        public bool SetFlowType(string type)
        {
            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please input type", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                flow_type = type;
                return true;
            }
        }

        // Setter method for flow_amount Float
        public void SetFlowAmount(float amount)
        {
            flow_amount = amount;
        }

        // Setter method for flow_amount string
        public bool SetFlowAmount(string amount)
        {
            float amountOut;
            if (!float.TryParse(amount, out amountOut))
            {
                MessageBox.Show("Please enter a valid number for the amount.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                flow_amount = (float)Math.Round(Convert.ToDouble(amountOut), 2); // Set the flow_amount only if parsing is successful
                return false;
            }
        }
        
        public bool SetExpenseFlowAmount(string amount)
        {
            float amountOut;
            if (!float.TryParse(amount, out amountOut))
            {
                MessageBox.Show("Please enter a valid number for the amount.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                flow_amount = ((float)Math.Round(Convert.ToDouble(amountOut), 2) * -1); // Set the flow_amount only if parsing is successful
                return true;
            }
        }

        // Setter method for flow_datetime
        public void SetFlowDatetime(DateTime datetime)
        {
            try
            {
                flow_datetime = datetime;
            }
            catch
            {
                MessageBox.Show("Please enter a valid date format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Setter method for flow_timestamp
        public void SetFlowTimestamp(DateTime timestamp)
        {
            flow_timestamp = timestamp;
        }


        //EDIT SETTERS
        // Setter method for flow_description
        public void SetEditFlowDescription(string description)
        {
            flow_description = description;
        }

        // Setter method for flow_type
        public void SetEditFlowType(string type)
        {
            flow_type = type;
        }

        // Setter method for flow_amount
        public void SetEditFlowAmount(float amount)
        {
            flow_amount = amount;
        }

        // Setter method for flow_datetime
        public void SetEditFlowDatetime(DateTime datetime)
        {
            flow_datetime = datetime;
        }

        // Setter method for flow_timestamp
        public void SetEditFlowTimestamp(DateTime timestamp)
        {
            flow_timestamp = timestamp;
        }
    }
}

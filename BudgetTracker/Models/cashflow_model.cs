using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Models
{
    internal class cashflow_model
    {
        public int id {  get; set; }
        public string flow_description {  get; set; }
        public string flow_type { get; set; }
        public float flow_amount { get; set; }
        public DateTime flow_datetime {  get; set; }
        public DateTime flow_timestamp { get; set; }
    }
}

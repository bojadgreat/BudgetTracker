using System;

namespace BudgetTracker.Models
{
    public class cashflow_history_model
    {
        public int flow_id {  get; set; }
        public string flow_description {  get; set; }
        public string flow_type { get; set; }
        public float flow_amount { get; set; }
        public DateTime flow_datetime {  get; set; }
        public DateTime flow_timestamp { get; set; }
        public string flow_operation { get; set; }
    }
}

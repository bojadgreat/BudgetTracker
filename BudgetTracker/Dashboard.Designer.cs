﻿namespace BudgetTracker
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cash_flowDataGridView = new System.Windows.Forms.DataGridView();
            this.general_panel = new System.Windows.Forms.Panel();
            this.info_panel = new System.Windows.Forms.Panel();
            this.time_panel = new System.Windows.Forms.Panel();
            this.time_label = new System.Windows.Forms.Label();
            this.date_panel = new System.Windows.Forms.Panel();
            this.date_label = new System.Windows.Forms.Label();
            this.controls_panel = new System.Windows.Forms.Panel();
            this.history_button = new System.Windows.Forms.Button();
            this.delete_cashflow = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.cashFlowChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.table_panel = new System.Windows.Forms.Panel();
            this.cashFlowDataSet = new BudgetTracker.cashFlowDataSet();
            this.cashflowtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cash_flow_tableTableAdapter = new BudgetTracker.cashFlowDataSetTableAdapters.cash_flow_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cash_flowDataGridView)).BeginInit();
            this.general_panel.SuspendLayout();
            this.info_panel.SuspendLayout();
            this.time_panel.SuspendLayout();
            this.date_panel.SuspendLayout();
            this.controls_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashFlowChart)).BeginInit();
            this.table_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashFlowDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowtableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cash_flowDataGridView
            // 
            this.cash_flowDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cash_flowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cash_flowDataGridView.Location = new System.Drawing.Point(3, 3);
            this.cash_flowDataGridView.Name = "cash_flowDataGridView";
            this.cash_flowDataGridView.Size = new System.Drawing.Size(1034, 422);
            this.cash_flowDataGridView.TabIndex = 1;
            this.cash_flowDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cash_flowDataGridView_CellClick);
            // 
            // general_panel
            // 
            this.general_panel.Controls.Add(this.info_panel);
            this.general_panel.Controls.Add(this.controls_panel);
            this.general_panel.Location = new System.Drawing.Point(12, 12);
            this.general_panel.Name = "general_panel";
            this.general_panel.Size = new System.Drawing.Size(1040, 223);
            this.general_panel.TabIndex = 2;
            // 
            // info_panel
            // 
            this.info_panel.Controls.Add(this.time_panel);
            this.info_panel.Controls.Add(this.date_panel);
            this.info_panel.Location = new System.Drawing.Point(637, 3);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(400, 217);
            this.info_panel.TabIndex = 1;
            // 
            // time_panel
            // 
            this.time_panel.Controls.Add(this.time_label);
            this.time_panel.Location = new System.Drawing.Point(4, 112);
            this.time_panel.Name = "time_panel";
            this.time_panel.Size = new System.Drawing.Size(393, 102);
            this.time_panel.TabIndex = 1;
            // 
            // time_label
            // 
            this.time_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(52, 14);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(292, 76);
            this.time_label.TabIndex = 1;
            this.time_label.Text = "00:00:00";
            // 
            // date_panel
            // 
            this.date_panel.Controls.Add(this.date_label);
            this.date_panel.Location = new System.Drawing.Point(4, 4);
            this.date_panel.Name = "date_panel";
            this.date_panel.Size = new System.Drawing.Size(393, 102);
            this.date_panel.TabIndex = 0;
            // 
            // date_label
            // 
            this.date_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(14, 14);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(366, 76);
            this.date_label.TabIndex = 0;
            this.date_label.Text = "00/00/0000";
            // 
            // controls_panel
            // 
            this.controls_panel.Controls.Add(this.history_button);
            this.controls_panel.Controls.Add(this.delete_cashflow);
            this.controls_panel.Controls.Add(this.edit_button);
            this.controls_panel.Controls.Add(this.add_button);
            this.controls_panel.Controls.Add(this.cashFlowChart);
            this.controls_panel.Location = new System.Drawing.Point(3, 3);
            this.controls_panel.Name = "controls_panel";
            this.controls_panel.Size = new System.Drawing.Size(628, 217);
            this.controls_panel.TabIndex = 0;
            // 
            // history_button
            // 
            this.history_button.Location = new System.Drawing.Point(16, 158);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(187, 40);
            this.history_button.TabIndex = 4;
            this.history_button.Text = "HISTORY";
            this.history_button.UseVisualStyleBackColor = true;
            // 
            // delete_cashflow
            // 
            this.delete_cashflow.Location = new System.Drawing.Point(16, 112);
            this.delete_cashflow.Name = "delete_cashflow";
            this.delete_cashflow.Size = new System.Drawing.Size(187, 40);
            this.delete_cashflow.TabIndex = 3;
            this.delete_cashflow.Text = "DELETE CASHFLOW";
            this.delete_cashflow.UseVisualStyleBackColor = true;
            this.delete_cashflow.Click += new System.EventHandler(this.delete_cashflow_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(16, 66);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(187, 40);
            this.edit_button.TabIndex = 2;
            this.edit_button.Text = "EDIT ENTRY";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(16, 20);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(187, 40);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "ADD CASHFLOW";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // cashFlowChart
            // 
            this.cashFlowChart.BackColor = System.Drawing.SystemColors.Control;
            customLabel1.ForeColor = System.Drawing.Color.Black;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.Name = "total_cashflow_chart";
            this.cashFlowChart.ChartAreas.Add(chartArea1);
            this.cashFlowChart.Location = new System.Drawing.Point(230, 3);
            this.cashFlowChart.Name = "cashFlowChart";
            series1.ChartArea = "total_cashflow_chart";
            series1.Name = "Remaining Balance";
            series2.ChartArea = "total_cashflow_chart";
            series2.Name = "Income";
            series3.ChartArea = "total_cashflow_chart";
            series3.Name = "Expenses";
            this.cashFlowChart.Series.Add(series1);
            this.cashFlowChart.Series.Add(series2);
            this.cashFlowChart.Series.Add(series3);
            this.cashFlowChart.Size = new System.Drawing.Size(395, 211);
            this.cashFlowChart.TabIndex = 0;
            this.cashFlowChart.Text = "chart1";
            // 
            // table_panel
            // 
            this.table_panel.Controls.Add(this.cash_flowDataGridView);
            this.table_panel.Location = new System.Drawing.Point(12, 241);
            this.table_panel.Name = "table_panel";
            this.table_panel.Size = new System.Drawing.Size(1040, 428);
            this.table_panel.TabIndex = 3;
            // 
            // cashFlowDataSet
            // 
            this.cashFlowDataSet.DataSetName = "cashFlowDataSet";
            this.cashFlowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cashflowtableBindingSource
            // 
            this.cashflowtableBindingSource.DataMember = "cash_flow_table";
            this.cashflowtableBindingSource.DataSource = this.cashFlowDataSet;
            // 
            // cash_flow_tableTableAdapter
            // 
            this.cash_flow_tableTableAdapter.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.table_panel);
            this.Controls.Add(this.general_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Tracker";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cash_flowDataGridView)).EndInit();
            this.general_panel.ResumeLayout(false);
            this.info_panel.ResumeLayout(false);
            this.time_panel.ResumeLayout(false);
            this.time_panel.PerformLayout();
            this.date_panel.ResumeLayout(false);
            this.date_panel.PerformLayout();
            this.controls_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashFlowChart)).EndInit();
            this.table_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashFlowDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowtableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView cash_flowDataGridView;
        private System.Windows.Forms.Panel general_panel;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Panel controls_panel;
        private System.Windows.Forms.DataVisualization.Charting.Chart cashFlowChart;
        private System.Windows.Forms.Panel table_panel;
        private System.Windows.Forms.Button history_button;
        private System.Windows.Forms.Button delete_cashflow;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Panel time_panel;
        private System.Windows.Forms.Panel date_panel;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label time_label;
        private cashFlowDataSet cashFlowDataSet;
        private System.Windows.Forms.BindingSource cashflowtableBindingSource;
        private cashFlowDataSetTableAdapters.cash_flow_tableTableAdapter cash_flow_tableTableAdapter;
    }
}


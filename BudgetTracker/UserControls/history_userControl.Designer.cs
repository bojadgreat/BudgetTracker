namespace BudgetTracker.UserControls
{
    partial class history_userControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entry_panel = new System.Windows.Forms.Panel();
            this.header_add_panel = new System.Windows.Forms.Panel();
            this.history_label = new System.Windows.Forms.Label();
            this.hist_date_cbox = new System.Windows.Forms.ComboBox();
            this.hist_dgv = new System.Windows.Forms.DataGridView();
            this.entry_panel.SuspendLayout();
            this.header_add_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hist_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // entry_panel
            // 
            this.entry_panel.Controls.Add(this.hist_dgv);
            this.entry_panel.Controls.Add(this.hist_date_cbox);
            this.entry_panel.Location = new System.Drawing.Point(3, 122);
            this.entry_panel.Name = "entry_panel";
            this.entry_panel.Size = new System.Drawing.Size(672, 291);
            this.entry_panel.TabIndex = 3;
            // 
            // header_add_panel
            // 
            this.header_add_panel.Controls.Add(this.history_label);
            this.header_add_panel.Location = new System.Drawing.Point(3, 4);
            this.header_add_panel.Name = "header_add_panel";
            this.header_add_panel.Size = new System.Drawing.Size(672, 112);
            this.header_add_panel.TabIndex = 2;
            // 
            // history_label
            // 
            this.history_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.history_label.AutoSize = true;
            this.history_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_label.Location = new System.Drawing.Point(183, 20);
            this.history_label.Name = "history_label";
            this.history_label.Size = new System.Drawing.Size(317, 73);
            this.history_label.TabIndex = 1;
            this.history_label.Text = "HISTORY";
            // 
            // hist_date_cbox
            // 
            this.hist_date_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hist_date_cbox.FormattingEnabled = true;
            this.hist_date_cbox.Location = new System.Drawing.Point(136, 9);
            this.hist_date_cbox.Name = "hist_date_cbox";
            this.hist_date_cbox.Size = new System.Drawing.Size(385, 28);
            this.hist_date_cbox.TabIndex = 0;
            // 
            // hist_dgv
            // 
            this.hist_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hist_dgv.Location = new System.Drawing.Point(3, 46);
            this.hist_dgv.Name = "hist_dgv";
            this.hist_dgv.Size = new System.Drawing.Size(666, 242);
            this.hist_dgv.TabIndex = 1;
            // 
            // history_userControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.entry_panel);
            this.Controls.Add(this.header_add_panel);
            this.Name = "history_userControl";
            this.Size = new System.Drawing.Size(679, 416);
            this.entry_panel.ResumeLayout(false);
            this.header_add_panel.ResumeLayout(false);
            this.header_add_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hist_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel entry_panel;
        private System.Windows.Forms.Panel header_add_panel;
        private System.Windows.Forms.DataGridView hist_dgv;
        private System.Windows.Forms.ComboBox hist_date_cbox;
        private System.Windows.Forms.Label history_label;
    }
}

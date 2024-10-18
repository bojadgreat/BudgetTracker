namespace BudgetTracker.UserControls
{
    partial class add_userControl
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
            this.header_add_panel = new System.Windows.Forms.Panel();
            this.add_label = new System.Windows.Forms.Label();
            this.entry_panel = new System.Windows.Forms.Panel();
            this.add_typeCbox = new System.Windows.Forms.ComboBox();
            this.type_label = new System.Windows.Forms.Label();
            this.user_add_button = new System.Windows.Forms.Button();
            this.user_cancel_button = new System.Windows.Forms.Button();
            this.add_dateDTP = new System.Windows.Forms.DateTimePicker();
            this.date_label = new System.Windows.Forms.Label();
            this.add_amtTB = new System.Windows.Forms.TextBox();
            this.amount_label = new System.Windows.Forms.Label();
            this.add_descTB = new System.Windows.Forms.TextBox();
            this.desc_label = new System.Windows.Forms.Label();
            this.header_add_panel.SuspendLayout();
            this.entry_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_add_panel
            // 
            this.header_add_panel.Controls.Add(this.add_label);
            this.header_add_panel.Location = new System.Drawing.Point(4, 4);
            this.header_add_panel.Name = "header_add_panel";
            this.header_add_panel.Size = new System.Drawing.Size(672, 112);
            this.header_add_panel.TabIndex = 0;
            // 
            // add_label
            // 
            this.add_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_label.AutoSize = true;
            this.add_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_label.Location = new System.Drawing.Point(133, 21);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(401, 73);
            this.add_label.TabIndex = 0;
            this.add_label.Text = "ADD ENTRY";
            // 
            // entry_panel
            // 
            this.entry_panel.Controls.Add(this.add_typeCbox);
            this.entry_panel.Controls.Add(this.type_label);
            this.entry_panel.Controls.Add(this.user_add_button);
            this.entry_panel.Controls.Add(this.user_cancel_button);
            this.entry_panel.Controls.Add(this.add_dateDTP);
            this.entry_panel.Controls.Add(this.date_label);
            this.entry_panel.Controls.Add(this.add_amtTB);
            this.entry_panel.Controls.Add(this.amount_label);
            this.entry_panel.Controls.Add(this.add_descTB);
            this.entry_panel.Controls.Add(this.desc_label);
            this.entry_panel.Location = new System.Drawing.Point(4, 122);
            this.entry_panel.Name = "entry_panel";
            this.entry_panel.Size = new System.Drawing.Size(672, 291);
            this.entry_panel.TabIndex = 1;
            // 
            // add_typeCbox
            // 
            this.add_typeCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_typeCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_typeCbox.FormattingEnabled = true;
            this.add_typeCbox.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.add_typeCbox.Location = new System.Drawing.Point(434, 98);
            this.add_typeCbox.Name = "add_typeCbox";
            this.add_typeCbox.Size = new System.Drawing.Size(208, 33);
            this.add_typeCbox.TabIndex = 4;
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_label.Location = new System.Drawing.Point(365, 100);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(66, 25);
            this.type_label.TabIndex = 6;
            this.type_label.Text = "Type:";
            // 
            // user_add_button
            // 
            this.user_add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_add_button.Location = new System.Drawing.Point(418, 205);
            this.user_add_button.Name = "user_add_button";
            this.user_add_button.Size = new System.Drawing.Size(243, 69);
            this.user_add_button.TabIndex = 5;
            this.user_add_button.Text = "ADD ENTRY";
            this.user_add_button.UseVisualStyleBackColor = true;
            this.user_add_button.Click += new System.EventHandler(this.user_add_button_Click);
            // 
            // user_cancel_button
            // 
            this.user_cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_cancel_button.Location = new System.Drawing.Point(14, 205);
            this.user_cancel_button.Name = "user_cancel_button";
            this.user_cancel_button.Size = new System.Drawing.Size(243, 69);
            this.user_cancel_button.TabIndex = 6;
            this.user_cancel_button.Text = "CANCEL";
            this.user_cancel_button.UseVisualStyleBackColor = true;
            this.user_cancel_button.Click += new System.EventHandler(this.user_cancel_button_Click);
            // 
            // add_dateDTP
            // 
            this.add_dateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_dateDTP.Location = new System.Drawing.Point(434, 46);
            this.add_dateDTP.Name = "add_dateDTP";
            this.add_dateDTP.Size = new System.Drawing.Size(208, 31);
            this.add_dateDTP.TabIndex = 3;
            this.add_dateDTP.Value = new System.DateTime(2024, 10, 18, 13, 18, 53, 0);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(365, 48);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(63, 25);
            this.date_label.TabIndex = 0;
            this.date_label.Text = "Date:";
            // 
            // add_amtTB
            // 
            this.add_amtTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_amtTB.Location = new System.Drawing.Point(121, 100);
            this.add_amtTB.Name = "add_amtTB";
            this.add_amtTB.Size = new System.Drawing.Size(206, 31);
            this.add_amtTB.TabIndex = 2;
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_label.Location = new System.Drawing.Point(24, 100);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(91, 25);
            this.amount_label.TabIndex = 0;
            this.amount_label.Text = "Amount:";
            // 
            // add_descTB
            // 
            this.add_descTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_descTB.Location = new System.Drawing.Point(156, 48);
            this.add_descTB.Name = "add_descTB";
            this.add_descTB.Size = new System.Drawing.Size(171, 31);
            this.add_descTB.TabIndex = 1;
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_label.Location = new System.Drawing.Point(24, 48);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(126, 25);
            this.desc_label.TabIndex = 0;
            this.desc_label.Text = "Description:";
            // 
            // add_userControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.entry_panel);
            this.Controls.Add(this.header_add_panel);
            this.Name = "add_userControl";
            this.Size = new System.Drawing.Size(679, 416);
            this.header_add_panel.ResumeLayout(false);
            this.header_add_panel.PerformLayout();
            this.entry_panel.ResumeLayout(false);
            this.entry_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_add_panel;
        private System.Windows.Forms.Panel entry_panel;
        private System.Windows.Forms.Label add_label;
        private System.Windows.Forms.DateTimePicker add_dateDTP;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox add_amtTB;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.TextBox add_descTB;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.Button user_add_button;
        private System.Windows.Forms.Button user_cancel_button;
        private System.Windows.Forms.ComboBox add_typeCbox;
        private System.Windows.Forms.Label type_label;
    }
}

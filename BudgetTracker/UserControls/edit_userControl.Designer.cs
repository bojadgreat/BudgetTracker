namespace BudgetTracker.UserControls
{
    partial class edit_userControl
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
            this.edit_label = new System.Windows.Forms.Label();
            this.entry_panel = new System.Windows.Forms.Panel();
            this.edit_typeCbox = new System.Windows.Forms.ComboBox();
            this.type_label = new System.Windows.Forms.Label();
            this.user_edit_button = new System.Windows.Forms.Button();
            this.user_cancel_button = new System.Windows.Forms.Button();
            this.edit_dateDTP = new System.Windows.Forms.DateTimePicker();
            this.date_label = new System.Windows.Forms.Label();
            this.edit_amtTB = new System.Windows.Forms.TextBox();
            this.amount_label = new System.Windows.Forms.Label();
            this.edit_descTB = new System.Windows.Forms.TextBox();
            this.desc_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.entryEdit_id_cBox = new System.Windows.Forms.ComboBox();
            this.header_add_panel.SuspendLayout();
            this.entry_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_add_panel
            // 
            this.header_add_panel.Controls.Add(this.edit_label);
            this.header_add_panel.Location = new System.Drawing.Point(3, 4);
            this.header_add_panel.Name = "header_add_panel";
            this.header_add_panel.Size = new System.Drawing.Size(672, 112);
            this.header_add_panel.TabIndex = 2;
            // 
            // edit_label
            // 
            this.edit_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_label.AutoSize = true;
            this.edit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_label.Location = new System.Drawing.Point(133, 21);
            this.edit_label.Name = "edit_label";
            this.edit_label.Size = new System.Drawing.Size(412, 73);
            this.edit_label.TabIndex = 0;
            this.edit_label.Text = "EDIT ENTRY";
            // 
            // entry_panel
            // 
            this.entry_panel.Controls.Add(this.entryEdit_id_cBox);
            this.entry_panel.Controls.Add(this.id_label);
            this.entry_panel.Controls.Add(this.edit_typeCbox);
            this.entry_panel.Controls.Add(this.type_label);
            this.entry_panel.Controls.Add(this.user_edit_button);
            this.entry_panel.Controls.Add(this.user_cancel_button);
            this.entry_panel.Controls.Add(this.edit_dateDTP);
            this.entry_panel.Controls.Add(this.date_label);
            this.entry_panel.Controls.Add(this.edit_amtTB);
            this.entry_panel.Controls.Add(this.amount_label);
            this.entry_panel.Controls.Add(this.edit_descTB);
            this.entry_panel.Controls.Add(this.desc_label);
            this.entry_panel.Location = new System.Drawing.Point(3, 122);
            this.entry_panel.Name = "entry_panel";
            this.entry_panel.Size = new System.Drawing.Size(672, 291);
            this.entry_panel.TabIndex = 3;
            // 
            // edit_typeCbox
            // 
            this.edit_typeCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edit_typeCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_typeCbox.FormattingEnabled = true;
            this.edit_typeCbox.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.edit_typeCbox.Location = new System.Drawing.Point(434, 60);
            this.edit_typeCbox.Name = "edit_typeCbox";
            this.edit_typeCbox.Size = new System.Drawing.Size(208, 33);
            this.edit_typeCbox.TabIndex = 4;
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_label.Location = new System.Drawing.Point(365, 63);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(66, 25);
            this.type_label.TabIndex = 6;
            this.type_label.Text = "Type:";
            // 
            // user_edit_button
            // 
            this.user_edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_edit_button.Location = new System.Drawing.Point(418, 205);
            this.user_edit_button.Name = "user_edit_button";
            this.user_edit_button.Size = new System.Drawing.Size(243, 69);
            this.user_edit_button.TabIndex = 5;
            this.user_edit_button.Text = "EDIT ENTRY";
            this.user_edit_button.UseVisualStyleBackColor = true;
            this.user_edit_button.Click += new System.EventHandler(this.user_edit_button_Click);
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
            // edit_dateDTP
            // 
            this.edit_dateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_dateDTP.Location = new System.Drawing.Point(434, 11);
            this.edit_dateDTP.Name = "edit_dateDTP";
            this.edit_dateDTP.Size = new System.Drawing.Size(208, 31);
            this.edit_dateDTP.TabIndex = 3;
            this.edit_dateDTP.Value = new System.DateTime(2024, 10, 18, 13, 18, 53, 0);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(365, 16);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(63, 25);
            this.date_label.TabIndex = 0;
            this.date_label.Text = "Date:";
            // 
            // edit_amtTB
            // 
            this.edit_amtTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_amtTB.Location = new System.Drawing.Point(121, 115);
            this.edit_amtTB.Name = "edit_amtTB";
            this.edit_amtTB.Size = new System.Drawing.Size(206, 31);
            this.edit_amtTB.TabIndex = 2;
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_label.Location = new System.Drawing.Point(24, 115);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(91, 25);
            this.amount_label.TabIndex = 0;
            this.amount_label.Text = "Amount:";
            // 
            // edit_descTB
            // 
            this.edit_descTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_descTB.Location = new System.Drawing.Point(156, 63);
            this.edit_descTB.Name = "edit_descTB";
            this.edit_descTB.Size = new System.Drawing.Size(171, 31);
            this.edit_descTB.TabIndex = 1;
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_label.Location = new System.Drawing.Point(24, 63);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(126, 25);
            this.desc_label.TabIndex = 0;
            this.desc_label.Text = "Description:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(24, 16);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(94, 25);
            this.id_label.TabIndex = 7;
            this.id_label.Text = "Entry ID:";
            // 
            // entryEdit_id_cBox
            // 
            this.entryEdit_id_cBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entryEdit_id_cBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryEdit_id_cBox.FormattingEnabled = true;
            this.entryEdit_id_cBox.Location = new System.Drawing.Point(124, 13);
            this.entryEdit_id_cBox.Name = "entryEdit_id_cBox";
            this.entryEdit_id_cBox.Size = new System.Drawing.Size(203, 33);
            this.entryEdit_id_cBox.TabIndex = 8;
            this.entryEdit_id_cBox.SelectedIndexChanged += new System.EventHandler(this.entryEdit_id_cBox_SelectedIndexChanged);
            // 
            // edit_userControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header_add_panel);
            this.Controls.Add(this.entry_panel);
            this.Name = "edit_userControl";
            this.Size = new System.Drawing.Size(679, 416);
            this.header_add_panel.ResumeLayout(false);
            this.header_add_panel.PerformLayout();
            this.entry_panel.ResumeLayout(false);
            this.entry_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_add_panel;
        private System.Windows.Forms.Label edit_label;
        private System.Windows.Forms.Panel entry_panel;
        private System.Windows.Forms.ComboBox edit_typeCbox;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Button user_edit_button;
        private System.Windows.Forms.Button user_cancel_button;
        private System.Windows.Forms.DateTimePicker edit_dateDTP;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox edit_amtTB;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.TextBox edit_descTB;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.ComboBox entryEdit_id_cBox;
        private System.Windows.Forms.Label id_label;
    }
}

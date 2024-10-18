namespace BudgetTracker.UserControls
{
    partial class delete_userControl
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
            this.SuspendLayout();
            // 
            // entry_panel
            // 
            this.entry_panel.Location = new System.Drawing.Point(3, 122);
            this.entry_panel.Name = "entry_panel";
            this.entry_panel.Size = new System.Drawing.Size(672, 291);
            this.entry_panel.TabIndex = 3;
            // 
            // header_add_panel
            // 
            this.header_add_panel.Location = new System.Drawing.Point(3, 4);
            this.header_add_panel.Name = "header_add_panel";
            this.header_add_panel.Size = new System.Drawing.Size(672, 112);
            this.header_add_panel.TabIndex = 2;
            // 
            // delete_userControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.entry_panel);
            this.Controls.Add(this.header_add_panel);
            this.Name = "delete_userControl";
            this.Size = new System.Drawing.Size(679, 416);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel entry_panel;
        private System.Windows.Forms.Panel header_add_panel;
    }
}

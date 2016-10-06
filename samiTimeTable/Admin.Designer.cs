namespace samiTimeTable
{
    partial class Admin
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
            this.delete_button = new System.Windows.Forms.Button();
            this.update_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(52, 119);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(112, 23);
            this.delete_button.TabIndex = 19;
            this.delete_button.Text = "מחיקה";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_bt
            // 
            this.update_bt.Location = new System.Drawing.Point(52, 85);
            this.update_bt.Name = "update_bt";
            this.update_bt.Size = new System.Drawing.Size(112, 23);
            this.update_bt.TabIndex = 27;
            this.update_bt.Text = "עדכון";
            this.update_bt.UseVisualStyleBackColor = true;
            this.update_bt.Click += new System.EventHandler(this.update_bt_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(934, 489);
            this.Controls.Add(this.update_bt);
            this.Controls.Add(this.delete_button);
            this.Name = "Admin";
            this.Text = "Shubi\'s Time Table for SCE (Admin)";
            this.Controls.SetChildIndex(this.delete_button, 0);
            this.Controls.SetChildIndex(this.update_bt, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_bt;
    }
}

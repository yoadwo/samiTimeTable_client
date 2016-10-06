namespace samiTimeTable
{
    partial class addUser
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
            this.message_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.email_lb = new System.Windows.Forms.Label();
            this.password_lb = new System.Windows.Forms.Label();
            this.verify_password_lb = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.verify_password_tb = new System.Windows.Forms.TextBox();
            this.ok_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message_lb
            // 
            this.message_lb.AutoSize = true;
            this.message_lb.Font = new System.Drawing.Font("Arial", 14F);
            this.message_lb.Location = new System.Drawing.Point(75, 30);
            this.message_lb.Name = "message_lb";
            this.message_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.message_lb.Size = new System.Drawing.Size(268, 22);
            this.message_lb.TabIndex = 0;
            this.message_lb.Text = "אנא הזינו שם, כתובת אימייל וסיסמא";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Arial", 9F);
            this.name_lb.Location = new System.Drawing.Point(319, 77);
            this.name_lb.Name = "name_lb";
            this.name_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lb.Size = new System.Drawing.Size(22, 15);
            this.name_lb.TabIndex = 1;
            this.name_lb.Text = "שם";
            // 
            // email_lb
            // 
            this.email_lb.AutoSize = true;
            this.email_lb.Font = new System.Drawing.Font("Arial", 9F);
            this.email_lb.Location = new System.Drawing.Point(280, 104);
            this.email_lb.Name = "email_lb";
            this.email_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.email_lb.Size = new System.Drawing.Size(61, 15);
            this.email_lb.TabIndex = 2;
            this.email_lb.Text = "כתובת מייל";
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("Arial", 9F);
            this.password_lb.Location = new System.Drawing.Point(301, 132);
            this.password_lb.Name = "password_lb";
            this.password_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password_lb.Size = new System.Drawing.Size(38, 15);
            this.password_lb.TabIndex = 3;
            this.password_lb.Text = "סיסמא";
            // 
            // verify_password_lb
            // 
            this.verify_password_lb.AutoSize = true;
            this.verify_password_lb.Font = new System.Drawing.Font("Arial", 9F);
            this.verify_password_lb.Location = new System.Drawing.Point(273, 161);
            this.verify_password_lb.Name = "verify_password_lb";
            this.verify_password_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.verify_password_lb.Size = new System.Drawing.Size(68, 15);
            this.verify_password_lb.TabIndex = 4;
            this.verify_password_lb.Text = "אישור סיסמא";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(75, 77);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(164, 20);
            this.name_tb.TabIndex = 5;
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(75, 104);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(164, 20);
            this.email_tb.TabIndex = 6;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(75, 132);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(164, 20);
            this.password_tb.TabIndex = 7;
            // 
            // verify_password_tb
            // 
            this.verify_password_tb.Location = new System.Drawing.Point(75, 159);
            this.verify_password_tb.Name = "verify_password_tb";
            this.verify_password_tb.PasswordChar = '*';
            this.verify_password_tb.Size = new System.Drawing.Size(164, 20);
            this.verify_password_tb.TabIndex = 8;
            // 
            // ok_bt
            // 
            this.ok_bt.Location = new System.Drawing.Point(273, 209);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(75, 23);
            this.ok_bt.TabIndex = 9;
            this.ok_bt.Text = "אישור";
            this.ok_bt.UseVisualStyleBackColor = true;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(75, 209);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 10;
            this.cancel_bt.Text = "ביטול";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 274);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.ok_bt);
            this.Controls.Add(this.verify_password_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.verify_password_lb);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.email_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.message_lb);
            this.Name = "addUser";
            this.Text = "הוספת משתמש למערכת";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label email_lb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.Label verify_password_lb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox verify_password_tb;
        private System.Windows.Forms.Button ok_bt;
        private System.Windows.Forms.Button cancel_bt;
    }
}
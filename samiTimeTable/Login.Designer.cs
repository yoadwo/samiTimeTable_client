namespace samiTimeTable
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.email_lb = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.login_bt = new System.Windows.Forms.Button();
            this.exit_bt = new System.Windows.Forms.Button();
            this.signup_bt = new System.Windows.Forms.Button();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.pass_lb = new System.Windows.Forms.Label();
            this.sce_pb = new System.Windows.Forms.PictureBox();
            this.gingers_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sce_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gingers_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // email_lb
            // 
            this.email_lb.AutoSize = true;
            this.email_lb.BackColor = System.Drawing.Color.NavajoWhite;
            this.email_lb.Font = new System.Drawing.Font("Arial", 10F);
            this.email_lb.Location = new System.Drawing.Point(504, 186);
            this.email_lb.Name = "email_lb";
            this.email_lb.Size = new System.Drawing.Size(39, 16);
            this.email_lb.TabIndex = 2;
            this.email_lb.Text = "אימייל";
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(261, 183);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(212, 20);
            this.email_tb.TabIndex = 10;
            // 
            // login_bt
            // 
            this.login_bt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.login_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_bt.Location = new System.Drawing.Point(419, 267);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(54, 23);
            this.login_bt.TabIndex = 12;
            this.login_bt.Text = "כניסה";
            this.login_bt.UseVisualStyleBackColor = false;
            this.login_bt.Click += new System.EventHandler(this.login_bt_Click);
            // 
            // exit_bt
            // 
            this.exit_bt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exit_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_bt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bt.Location = new System.Drawing.Point(261, 267);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(54, 23);
            this.exit_bt.TabIndex = 14;
            this.exit_bt.Text = "יציאה";
            this.exit_bt.UseVisualStyleBackColor = false;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // signup_bt
            // 
            this.signup_bt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.signup_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_bt.Location = new System.Drawing.Point(340, 267);
            this.signup_bt.Name = "signup_bt";
            this.signup_bt.Size = new System.Drawing.Size(54, 23);
            this.signup_bt.TabIndex = 13;
            this.signup_bt.Text = "הרשמה";
            this.signup_bt.UseVisualStyleBackColor = false;
            this.signup_bt.Click += new System.EventHandler(this.signup_bt_Click);
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(261, 211);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(212, 20);
            this.password_tb.TabIndex = 11;
            // 
            // pass_lb
            // 
            this.pass_lb.AutoSize = true;
            this.pass_lb.BackColor = System.Drawing.Color.NavajoWhite;
            this.pass_lb.Font = new System.Drawing.Font("Arial", 10F);
            this.pass_lb.Location = new System.Drawing.Point(500, 212);
            this.pass_lb.Name = "pass_lb";
            this.pass_lb.Size = new System.Drawing.Size(43, 16);
            this.pass_lb.TabIndex = 15;
            this.pass_lb.Text = "סיסמא";
            // 
            // sce_pb
            // 
            this.sce_pb.Image = global::samiTimeTable.Properties.Resources.sce_clear;
            this.sce_pb.Location = new System.Drawing.Point(3, 12);
            this.sce_pb.Name = "sce_pb";
            this.sce_pb.Size = new System.Drawing.Size(200, 100);
            this.sce_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sce_pb.TabIndex = 1;
            this.sce_pb.TabStop = false;
            // 
            // gingers_pb
            // 
            this.gingers_pb.Image = ((System.Drawing.Image)(resources.GetObject("gingers_pb.Image")));
            this.gingers_pb.Location = new System.Drawing.Point(474, 12);
            this.gingers_pb.Name = "gingers_pb";
            this.gingers_pb.Size = new System.Drawing.Size(200, 100);
            this.gingers_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gingers_pb.TabIndex = 0;
            this.gingers_pb.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(686, 349);
            this.Controls.Add(this.pass_lb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.signup_bt);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.login_bt);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.email_lb);
            this.Controls.Add(this.sce_pb);
            this.Controls.Add(this.gingers_pb);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.sce_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gingers_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label email_lb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Button login_bt;
        private System.Windows.Forms.Button exit_bt;
        private System.Windows.Forms.Button signup_bt;
        private System.Windows.Forms.PictureBox sce_pb;
        private System.Windows.Forms.PictureBox gingers_pb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label pass_lb;
    }
}
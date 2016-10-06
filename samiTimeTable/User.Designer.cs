namespace samiTimeTable
{
    partial class User
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
            this.showAll_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Admin_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.search_lb = new System.Windows.Forms.Label();
            this.sortValue_cb = new System.Windows.Forms.ComboBox();
            this.class_rb = new System.Windows.Forms.RadioButton();
            this.day_rb = new System.Windows.Forms.RadioButton();
            this.teacher_rb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.type_cb = new System.Windows.Forms.ComboBox();
            this.find_bt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showAll_button
            // 
            this.showAll_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.showAll_button.Location = new System.Drawing.Point(601, 114);
            this.showAll_button.Name = "showAll_button";
            this.showAll_button.Size = new System.Drawing.Size(274, 29);
            this.showAll_button.TabIndex = 15;
            this.showAll_button.Text = "סופר-מערכת";
            this.showAll_button.UseVisualStyleBackColor = true;
            this.showAll_button.Click += new System.EventHandler(this.showAll_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(817, 429);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 11;
            this.Exit_button.Text = "יציאה";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Admin_button
            // 
            this.Admin_button.Enabled = false;
            this.Admin_button.Location = new System.Drawing.Point(52, 429);
            this.Admin_button.Name = "Admin_button";
            this.Admin_button.Size = new System.Drawing.Size(75, 23);
            this.Admin_button.TabIndex = 10;
            this.Admin_button.Text = "Admin";
            this.Admin_button.UseVisualStyleBackColor = true;
            this.Admin_button.Click += new System.EventHandler(this.Admin_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(991, 229);
            this.dataGridView1.TabIndex = 6;
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Add_button.Location = new System.Drawing.Point(52, 23);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(112, 23);
            this.Add_button.TabIndex = 5;
            this.Add_button.Text = "הוספת קורס";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // search_lb
            // 
            this.search_lb.AutoSize = true;
            this.search_lb.Font = new System.Drawing.Font("Arial", 8.25F);
            this.search_lb.Location = new System.Drawing.Point(944, 18);
            this.search_lb.Name = "search_lb";
            this.search_lb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search_lb.Size = new System.Drawing.Size(55, 14);
            this.search_lb.TabIndex = 18;
            this.search_lb.Text = "חיפוש לפי:";
            // 
            // sortValue_cb
            // 
            this.sortValue_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortValue_cb.FormattingEnabled = true;
            this.sortValue_cb.Location = new System.Drawing.Point(601, 50);
            this.sortValue_cb.Name = "sortValue_cb";
            this.sortValue_cb.Size = new System.Drawing.Size(274, 21);
            this.sortValue_cb.TabIndex = 20;
            // 
            // class_rb
            // 
            this.class_rb.AutoSize = true;
            this.class_rb.Font = new System.Drawing.Font("Arial", 8.25F);
            this.class_rb.Location = new System.Drawing.Point(688, 18);
            this.class_rb.Name = "class_rb";
            this.class_rb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.class_rb.Size = new System.Drawing.Size(73, 18);
            this.class_rb.TabIndex = 21;
            this.class_rb.TabStop = true;
            this.class_rb.Text = "שם הקורס";
            this.class_rb.UseVisualStyleBackColor = true;
            this.class_rb.CheckedChanged += new System.EventHandler(this.class_rb_CheckedChanged);
            // 
            // day_rb
            // 
            this.day_rb.AutoSize = true;
            this.day_rb.Font = new System.Drawing.Font("Arial", 8.25F);
            this.day_rb.Location = new System.Drawing.Point(601, 18);
            this.day_rb.Name = "day_rb";
            this.day_rb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.day_rb.Size = new System.Drawing.Size(38, 18);
            this.day_rb.TabIndex = 22;
            this.day_rb.TabStop = true;
            this.day_rb.Text = "יום";
            this.day_rb.UseVisualStyleBackColor = true;
            this.day_rb.CheckedChanged += new System.EventHandler(this.day_rb_CheckedChanged);
            // 
            // teacher_rb
            // 
            this.teacher_rb.AutoSize = true;
            this.teacher_rb.Font = new System.Drawing.Font("Arial", 8.25F);
            this.teacher_rb.Location = new System.Drawing.Point(798, 18);
            this.teacher_rb.Name = "teacher_rb";
            this.teacher_rb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.teacher_rb.Size = new System.Drawing.Size(77, 18);
            this.teacher_rb.TabIndex = 23;
            this.teacher_rb.TabStop = true;
            this.teacher_rb.Text = "שם המרצה";
            this.teacher_rb.UseVisualStyleBackColor = true;
            this.teacher_rb.CheckedChanged += new System.EventHandler(this.teacher_rb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.Location = new System.Drawing.Point(903, 89);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "תרגולים או הרצאות:";
            // 
            // type_cb
            // 
            this.type_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_cb.Font = new System.Drawing.Font("Arial", 8.25F);
            this.type_cb.FormattingEnabled = true;
            this.type_cb.Items.AddRange(new object[] {
            "הרצאות",
            "תרגולים",
            "מעבדות",
            "הכל"});
            this.type_cb.Location = new System.Drawing.Point(688, 86);
            this.type_cb.Name = "type_cb";
            this.type_cb.Size = new System.Drawing.Size(187, 22);
            this.type_cb.TabIndex = 25;
            // 
            // find_bt
            // 
            this.find_bt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.find_bt.Location = new System.Drawing.Point(601, 84);
            this.find_bt.Name = "find_bt";
            this.find_bt.Size = new System.Drawing.Size(78, 24);
            this.find_bt.TabIndex = 26;
            this.find_bt.Text = "חיפוש";
            this.find_bt.UseVisualStyleBackColor = true;
            this.find_bt.Click += new System.EventHandler(this.find_bt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label2.Location = new System.Drawing.Point(933, 49);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 27;
            this.label2.Text = "ערך החיפוש:";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1062, 585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.find_bt);
            this.Controls.Add(this.type_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacher_rb);
            this.Controls.Add(this.day_rb);
            this.Controls.Add(this.class_rb);
            this.Controls.Add(this.sortValue_cb);
            this.Controls.Add(this.search_lb);
            this.Controls.Add(this.showAll_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Admin_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "User";
            this.Text = "Shubi\'s Time Table for SCE";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add_button;
        protected System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Admin_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button showAll_button;
        private System.Windows.Forms.Label search_lb;
        private System.Windows.Forms.ComboBox sortValue_cb;
        private System.Windows.Forms.RadioButton class_rb;
        private System.Windows.Forms.RadioButton day_rb;
        private System.Windows.Forms.RadioButton teacher_rb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox type_cb;
        private System.Windows.Forms.Button find_bt;
        private System.Windows.Forms.Label label2;
    }
}
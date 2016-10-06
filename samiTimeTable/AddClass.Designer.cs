namespace samiTimeTable
{
    partial class AddClass
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
            this.class_label = new System.Windows.Forms.Label();
            this.class_textBox = new System.Windows.Forms.TextBox();
            this.lect_radio = new System.Windows.Forms.RadioButton();
            this.ps_radio = new System.Windows.Forms.RadioButton();
            this.room_label = new System.Windows.Forms.Label();
            this.room_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.day_box = new System.Windows.Forms.ComboBox();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTime_label = new System.Windows.Forms.Label();
            this.endTime_label = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OK_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.teacher_label = new System.Windows.Forms.Label();
            this.teacher_textBox = new System.Windows.Forms.TextBox();
            this.lab_radio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Font = new System.Drawing.Font("Arial", 8.25F);
            this.class_label.Location = new System.Drawing.Point(270, 29);
            this.class_label.Name = "class_label";
            this.class_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.class_label.Size = new System.Drawing.Size(58, 14);
            this.class_label.TabIndex = 0;
            this.class_label.Text = "שם הקורס:";
            // 
            // class_textBox
            // 
            this.class_textBox.Font = new System.Drawing.Font("Arial", 8.25F);
            this.class_textBox.Location = new System.Drawing.Point(71, 29);
            this.class_textBox.Name = "class_textBox";
            this.class_textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.class_textBox.Size = new System.Drawing.Size(173, 20);
            this.class_textBox.TabIndex = 1;
            // 
            // lect_radio
            // 
            this.lect_radio.AutoSize = true;
            this.lect_radio.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lect_radio.Location = new System.Drawing.Point(271, 142);
            this.lect_radio.Name = "lect_radio";
            this.lect_radio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lect_radio.Size = new System.Drawing.Size(57, 18);
            this.lect_radio.TabIndex = 4;
            this.lect_radio.TabStop = true;
            this.lect_radio.Text = "הרצאה";
            this.lect_radio.UseVisualStyleBackColor = true;
            // 
            // ps_radio
            // 
            this.ps_radio.AutoSize = true;
            this.ps_radio.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ps_radio.Location = new System.Drawing.Point(176, 142);
            this.ps_radio.Name = "ps_radio";
            this.ps_radio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ps_radio.Size = new System.Drawing.Size(51, 18);
            this.ps_radio.TabIndex = 5;
            this.ps_radio.TabStop = true;
            this.ps_radio.Text = "תרגול";
            this.ps_radio.UseVisualStyleBackColor = true;
            // 
            // room_label
            // 
            this.room_label.AutoSize = true;
            this.room_label.Font = new System.Drawing.Font("Arial", 8.25F);
            this.room_label.Location = new System.Drawing.Point(270, 105);
            this.room_label.Name = "room_label";
            this.room_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.room_label.Size = new System.Drawing.Size(61, 14);
            this.room_label.TabIndex = 4;
            this.room_label.Text = "מספר כיתה:";
            // 
            // room_textBox
            // 
            this.room_textBox.Font = new System.Drawing.Font("Arial", 8.25F);
            this.room_textBox.Location = new System.Drawing.Point(71, 105);
            this.room_textBox.Name = "room_textBox";
            this.room_textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.room_textBox.Size = new System.Drawing.Size(173, 20);
            this.room_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.Location = new System.Drawing.Point(304, 176);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(23, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "יום:";
            // 
            // day_box
            // 
            this.day_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day_box.Font = new System.Drawing.Font("Arial", 8.25F);
            this.day_box.FormattingEnabled = true;
            this.day_box.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "שישי"});
            this.day_box.Location = new System.Drawing.Point(71, 176);
            this.day_box.Name = "day_box";
            this.day_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.day_box.Size = new System.Drawing.Size(121, 22);
            this.day_box.TabIndex = 6;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Checked = false;
            this.StartDateTimePicker.CustomFormat = "HH:mm";
            this.StartDateTimePicker.Font = new System.Drawing.Font("Arial", 8.25F);
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Location = new System.Drawing.Point(71, 218);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartDateTimePicker.ShowCheckBox = true;
            this.StartDateTimePicker.ShowUpDown = true;
            this.StartDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.StartDateTimePicker.TabIndex = 7;
            // 
            // startTime_label
            // 
            this.startTime_label.AutoSize = true;
            this.startTime_label.Font = new System.Drawing.Font("Arial", 8.25F);
            this.startTime_label.Location = new System.Drawing.Point(263, 218);
            this.startTime_label.Name = "startTime_label";
            this.startTime_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startTime_label.Size = new System.Drawing.Size(68, 14);
            this.startTime_label.TabIndex = 9;
            this.startTime_label.Text = "שעת התחלה:";
            // 
            // endTime_label
            // 
            this.endTime_label.AutoSize = true;
            this.endTime_label.Font = new System.Drawing.Font("Arial", 8.25F);
            this.endTime_label.Location = new System.Drawing.Point(276, 263);
            this.endTime_label.Name = "endTime_label";
            this.endTime_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endTime_label.Size = new System.Drawing.Size(55, 14);
            this.endTime_label.TabIndex = 10;
            this.endTime_label.Text = "שעת סיום:";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Checked = false;
            this.EndDateTimePicker.CustomFormat = "HH:mm";
            this.EndDateTimePicker.Font = new System.Drawing.Font("Arial", 8.25F);
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(71, 263);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EndDateTimePicker.ShowCheckBox = true;
            this.EndDateTimePicker.ShowUpDown = true;
            this.EndDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.EndDateTimePicker.TabIndex = 8;
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Arial", 9.25F);
            this.OK_button.Location = new System.Drawing.Point(289, 300);
            this.OK_button.Name = "OK_button";
            this.OK_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 12;
            this.OK_button.Text = "הוספה";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Arial", 9.25F);
            this.cancel_button.Location = new System.Drawing.Point(50, 300);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "ביטול";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // teacher_label
            // 
            this.teacher_label.AutoSize = true;
            this.teacher_label.Font = new System.Drawing.Font("Arial", 8.25F);
            this.teacher_label.Location = new System.Drawing.Point(266, 66);
            this.teacher_label.Name = "teacher_label";
            this.teacher_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.teacher_label.Size = new System.Drawing.Size(62, 14);
            this.teacher_label.TabIndex = 14;
            this.teacher_label.Text = "שם המרצה:";
            // 
            // teacher_textBox
            // 
            this.teacher_textBox.Font = new System.Drawing.Font("Arial", 8.25F);
            this.teacher_textBox.Location = new System.Drawing.Point(71, 66);
            this.teacher_textBox.Name = "teacher_textBox";
            this.teacher_textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.teacher_textBox.Size = new System.Drawing.Size(173, 20);
            this.teacher_textBox.TabIndex = 2;
            // 
            // lab_radio
            // 
            this.lab_radio.AutoSize = true;
            this.lab_radio.Location = new System.Drawing.Point(65, 142);
            this.lab_radio.Name = "lab_radio";
            this.lab_radio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_radio.Size = new System.Drawing.Size(60, 17);
            this.lab_radio.TabIndex = 15;
            this.lab_radio.TabStop = true;
            this.lab_radio.Text = "מעבדה";
            this.lab_radio.UseVisualStyleBackColor = true;
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 342);
            this.Controls.Add(this.lab_radio);
            this.Controls.Add(this.teacher_textBox);
            this.Controls.Add(this.teacher_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.endTime_label);
            this.Controls.Add(this.startTime_label);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.day_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.room_textBox);
            this.Controls.Add(this.room_label);
            this.Controls.Add(this.ps_radio);
            this.Controls.Add(this.lect_radio);
            this.Controls.Add(this.class_textBox);
            this.Controls.Add(this.class_label);
            this.Name = "AddClass";
            this.Text = "הוספת שיעור למערכת";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label class_label;
        public System.Windows.Forms.TextBox class_textBox;
        public System.Windows.Forms.RadioButton lect_radio;
        public System.Windows.Forms.RadioButton ps_radio;
        private System.Windows.Forms.Label room_label;
        public System.Windows.Forms.TextBox room_textBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox day_box;
        public System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label startTime_label;
        private System.Windows.Forms.Label endTime_label;
        public System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label teacher_label;
        public System.Windows.Forms.TextBox teacher_textBox;
        public System.Windows.Forms.RadioButton lab_radio;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samiTimeTable
{
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (verify_fields())
            {
                string type = "";
                if (lect_radio.Checked)
                    type = "Lecture";
                if (ps_radio.Checked)
                    type = "Practical Session";
                if (lab_radio.Checked)
                    type = "Lab";
                DialogResult result1 = MessageBox.Show(
                    "אנא אשרו את הפרטים הבאים\n" 
                    + class_textBox.Text  + "\n"
                    + teacher_textBox.Text + "\n"
                    + room_textBox.Text + "\n"
                    + type + "\n"
                    + day_box.SelectedItem + "\n"
                    + StartDateTimePicker.Value.ToString("HH:mm")+"\n"
                    //+ "Starting Time: " + StartDateTimePicker.Value.ToString() + "\n"
                    + EndDateTimePicker.Value.ToString("HH:mm"),
                    //+ "Ending Time: " + EndDateTimePicker.Value.ToString(""),
                "אישור פרטים",
                MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                    this.DialogResult = DialogResult.OK;
            }
                
        }

        private bool verify_fields()
        {
            if (class_textBox.Text.Equals(""))
            {
                MessageBox.Show("אנא ציינו את שם הקורס");
                return false;
            }
            if (teacher_textBox.Text.Equals(""))
            {
                MessageBox.Show("אנא ציינו את שם המרצה או המתרגל");
                return false;
            }
            if (!lect_radio.Checked && !ps_radio.Checked && !lab_radio.Checked)
            {
                MessageBox.Show("אנא ציינו את סוג השיעור");
                return false;
            }
            if (room_textBox.Text.Equals(""))
            {
                MessageBox.Show("אנא ציינו את מספר הכיתה");
                return false;
            }
            if (day_box.SelectedItem == null)
            {
                MessageBox.Show("אנא בחרו יום");
                return false;
            }
            if (!StartDateTimePicker.Checked)
            {
                MessageBox.Show("אנא בחרו שעת התחלה");
                return false;
            }
            if (!EndDateTimePicker.Checked)
            {
                MessageBox.Show("אנא בחרו שעת סיום");
                return false;
            }
            if (StartDateTimePicker.Value >= EndDateTimePicker.Value)
            {
                MessageBox.Show("שעת הסיום אינה יכולה להיות מוקדמת משעת ההתחלה");
                return false;
            }
            return true;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

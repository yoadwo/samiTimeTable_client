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
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            if (verify_fields())
            {
                string[] paramz = { "email", "studentName", "password" };
                string[] valuez = { email_tb.Text, name_tb.Text, password_tb.Text };
                string response = PHPMethods.HttpInsert("insertUser.php", paramz, valuez);
                if (response.Equals("inserted"))
                {
                    MessageBox.Show("המשתמש הוזן בהצלחה" + "\n" + "יש לחכות לאישור המערכת");
                    this.Close();
                }
                else if (response.Equals("exists"))
                    MessageBox.Show("המשתמש כבר קיים במערכת" + "\n" + "יש לחכות לאישור המערכת");
                else if (response.Contains("Error") || response.Contains("error"))
                    MessageBox.Show(response);
            }
        }

        private Boolean verify_fields()
        {
            if (name_tb.Text.Equals(""))
            {
                MessageBox.Show("אנא הזן שם משתמש");
                return false;
            }
            if (email_tb.Text.Equals(""))
            {
                MessageBox.Show("אנא הזן כתובת מייל");
                return false;
            }
            if (password_tb.Text.Equals(""))
            {
                MessageBox.Show("אנא הזן סיסמא");
                return false;
            }
            if (verify_password_tb.Text.Equals(""))
            {
                MessageBox.Show("אנא הזן סיסמא לאישור");
                return false;
            }
            if (!password_tb.Text.Equals(verify_password_tb.Text))
            {
                    MessageBox.Show("סיסמא ואישור סיסמא אינם תואמים");
                    return false;
            }
            return true;
        }
    }
}

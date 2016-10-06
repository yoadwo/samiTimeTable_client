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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            if (email_tb.Text.Equals(""))
            {
                MessageBox.Show("נא להכניס כתובת אימייל");
                return;
            }
            if (password_tb.Text.Equals(""))
            {
                MessageBox.Show("נא להכניס סיסמא");
                return;
            }
            string repsonse = PHPMethods.HttpVerify(email_tb.Text, password_tb.Text);
            if (repsonse.Equals("approved"))
            {
                using (var user = new User())
                {
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                }
            }
            else if (repsonse.Equals("admin")){
                using (var admin = new Admin())
                {
                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                }
            }
            else
                MessageBox.Show("כתובת אימייל איננה מאושרת או קיימת" + "\n" + "במידת הצורך, צרו קשר עם אחראי התוכנה");
        }
        private void signup_bt_Click(object sender, EventArgs e)
        {
            using (var addUser = new addUser())
            {
                addUser.ShowDialog();
            }
        }

       
        private void exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

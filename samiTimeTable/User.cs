using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

//TODO:
/*
1. make the url constant, only add <file>.php suffix
4. hash passwords?
*/
namespace samiTimeTable
{
    public partial class User : Form
    {
        protected DataTable dt;
        public User(): base ()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            initDT();
        }
        protected void initDT()
        {
            dt = new DataTable();
            dt.Columns.Add("id", typeof(System.Int32));
            dt.Columns.Add("courseName", typeof(System.String));
            dt.Columns.Add("teacher", typeof(System.String));
            dt.Columns.Add("room", typeof(System.String));
            dt.Columns.Add("day", typeof(System.String));
            dt.Columns.Add("startTime", typeof(System.String));
            dt.Columns.Add("endTime", typeof(System.String));
            dt.Columns.Add("Type", typeof(System.String));
        }


        protected void find_bt_Click(object sender, EventArgs e)
        {
            string type = "";
            string[] keyVal = verifyKeyVal();
            if (keyVal == null)
                return;
            type = verifyType();
            if (type == null)
                return;
            string response = PHPMethods.HttpSelect("select.php", keyVal[0], keyVal[1], type);
            if (response.StartsWith("OK"))
            {
                parseClasses(response.Substring(response.IndexOf('@') + 1));
                dataGridView1.DataSource = dt;
                dataGridView1.Focus();
            }
            else if (response.Equals("No rows found"))
                MessageBox.Show("לא נמצאו תוצאות");
            else
                MessageBox.Show(response);
        }
        protected string verifyType()
        {
            if (type_cb.SelectedItem == null)
            {
                MessageBox.Show("אנא בחרו את סוג השיעור");
                return null;
            }
            else if (type_cb.SelectedItem.ToString().Equals("הרצאות"))
                return "הרצאות";
            else if (type_cb.SelectedItem.ToString().Equals("תרגולים"))
                return "תרגולים";
            else if (type_cb.SelectedItem.ToString().Equals("מעבדות"))
                return "מעבדות";
            else //if (type_cb.SelectedItem.ToString().Equals("both"))
                return "both";

        }
        protected string[] verifyKeyVal()
        {
            string key = "", value = "";
            if (class_rb.Checked)
            {
                key = "courseName";
                if (sortValue_cb.SelectedItem == null)
                {
                    MessageBox.Show("אנא בחרו את הקורס הרצוי");
                    return null;
                }
                else
                {
                    value = sortValue_cb.SelectedItem.ToString();
                }
            }
            else if (day_rb.Checked)
            {
                key = "day";
                if (sortValue_cb.SelectedItem == null)
                {
                    MessageBox.Show("אנא בחרו את היום הרצוי");
                    return null;
                }
                else
                {
                    value = sortValue_cb.SelectedItem.ToString();
                }
            }
            else if (teacher_rb.Checked)
            {
                key = "teacherName";
                if (sortValue_cb.SelectedItem == null)
                {
                    MessageBox.Show("אנא בחרו את המרצה או המתרגל הרצויים");
                    return null;
                }
                else
                {
                    value = sortValue_cb.SelectedItem.ToString();
                }
            }
            else
            {
                MessageBox.Show("אנא בחרו את סוג החיפוש");
                return null;
            }
            string[] keyVal = { key, value };
            return keyVal;
        }

        protected void parseClasses(string response)
        {
            // response ="id1*course1*teacher1*room1*day1*start1*end1#id2*course2*teacher2*room2*day2*start2*end2"

            dt.Clear();
            string[] rows = response.Split('#');
            //rows[0] = "id1*course1*teacher1*room1*day1*start1*end1"
            //rows[1] = "id2*course2*teacher2*room2*day2*start2*end2"
            foreach (var row in rows)
            {
                DataRow dr = dt.NewRow();
                string[] cells = row.Split('*');
                //cells[0]=course1, cells[1]=teacher1, cells[2]=...
                dr["id"] = cells[0];
                dr["courseName"] = cells[1];
                dr["teacher"] = cells[2];
                dr["room"] = cells[3];
                dr["day"] = cells[4];
                dr["startTime"] = cells[5];
                dr["endTime"] = cells[6];
                dr["type"] = cells[7];
                dt.Rows.Add(dr);
            }

        }

        protected void showAll_button_Click(object sender, EventArgs e)
        {
            refreshAll();
            
        }
        protected void refreshAll()
        {
            string response = PHPMethods.HttpSelect("select.php", "1", "1", "All");
            if (response.StartsWith("OK"))
            {
                parseClasses(response.Substring(response.IndexOf('@') + 1));
                dataGridView1.DataSource = dt;
                dataGridView1.Focus();
            }
            else if (response.Equals("No rows found"))
                MessageBox.Show("לא נמצאו תוצאות");
            else
                MessageBox.Show(response);
        }


        protected void Add_button_Click(object sender, EventArgs e)
        {
            using (var add = new AddClass())
            {
                add.ShowDialog();
                if (add.DialogResult == DialogResult.OK)
                {
                    if (addRequest(add))
                    {
                        string response = PHPMethods.HttpSelect("select.php", "courseName", add.class_textBox.Text, "both");
                        if (response.StartsWith("OK"))
                        {
                            parseClasses(response.Substring(response.IndexOf('@') + 1));
                            dataGridView1.DataSource = dt;
                            dataGridView1.Focus();
                        }
                        else if (response.Equals("No rows found"))
                            MessageBox.Show("לא נמצאו תוצאות");
                        else
                            MessageBox.Show(response);
                    }
                }
            }
         
        }
        protected bool addRequest(AddClass add)
        {
            string type = null,
                course = add.class_textBox.Text.ToString(),
                room = add.room_textBox.Text.ToString(),
                teacher = add.teacher_textBox.Text.ToString(),
                day = add.day_box.SelectedItem.ToString(),
                start, end;
            if (add.lect_radio.Checked)
                type = "הרצאות";
            else if (add.ps_radio.Checked)
                type = "תרגולים";
            else if (add.lab_radio.Checked)
                type = "מעבדות";
            start = add.StartDateTimePicker.Value.ToString("HH:mm") + ":00";
            end = add.EndDateTimePicker.Value.ToString("HH:mm") + ":00";
            
            string[] paramz = { "id", "type", "course", "room", "teacher", "day", "start", "end" };
            string[] valuez = { "-1", type, course, room, teacher, day, start, end };
            string response = PHPMethods.HttpInsert("insertClass.php", paramz, valuez);
            if (response.Equals("Inserted"))
            {
                MessageBox.Show("הרשומה נקלטה בהצלחה");
                return true;
            }
            else {
                MessageBox.Show(response);
                return false;
            }
            //WebRequest request = sendRequest(type, course, room, teacher, day, start, end);
            //getRespone(request);

        }
        private DialogResult InputBox()
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Enter Password";
            label.Text = "Please Enter Password for Admin Login";
            #region initForm
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            #endregion

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (textBox.Text.Equals("Lectures"))
                {
                    return DialogResult.OK;
                }
                else
                {
                    return DialogResult.No;
                }
            }
            else return DialogResult.Cancel;
            
        }
       
        private void day_rb_CheckedChanged(object sender, EventArgs e)
        {
            refreshSortBox("day");
        }
        private void class_rb_CheckedChanged(object sender, EventArgs e)
        {
            refreshSortBox("courseName");
        }
        private void teacher_rb_CheckedChanged(object sender, EventArgs e)
        {
            refreshSortBox("teacherName");
        }
        private void refreshSortBox(string key)
        {
            string response = PHPMethods.HttpSearchAs(key);
            this.sortValue_cb.Items.Clear();
            this.sortValue_cb.Items.AddRange(response.Split('*'));
        }

        protected void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected virtual void Admin_button_Click(object sender, EventArgs e)
        {
            DialogResult result = InputBox();
            if (result == DialogResult.OK)
            {
                this.Hide();
                using (var admin = new Admin())
                {
                    admin.StartPosition = FormStartPosition.CenterParent;
                    admin.ShowDialog();
                }
                this.Show();
            }
            else if (result == DialogResult.No)
                MessageBox.Show("Wrong Password!");

        }

        #region webrequest_and_webresponse
        /*
        private WebRequest sendRequest(string type, string course, string room, string teacher, string day, string start, string end)
        {
            string url = "http://wolfsthal.esy.es/SceTime/insert.php";
            // Create a request using a URL that can receive a post. 
            WebRequest request = WebRequest.Create(url);
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = AddClassString(type, course, teacher, room, day, start, end);
            //string postData = "name=yoad";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            return request;
        }
        
        private void getRespone(WebRequest request)
        {

            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();
        }
        private string AddClassString(string type, string course, string teacher, string room, string day, string start, string end)
        {
            return
                "type=" + type + "&" +
                "course=" + course + "&" +
                "teacher=" + teacher + "&" +
                "room=" + room + "&" +
                "day=" + day + "&" +
                "start=" + start + "&" +
                "end=" + end;
        }
        */
        #endregion

        protected void User_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}




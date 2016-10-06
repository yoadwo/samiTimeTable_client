using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace samiTimeTable
{
    public partial class Admin : samiTimeTable.User
    {
        /* 
        To Fix Auto-Increment
        Perhaps add:
        ALTER TABLE YOUR_TABLE AUTO_INCREMENT=YOUR_DESIRED_NUMBER;
        to delete php file
        
        */
        public Admin() : base()
        {
            InitializeComponent();
        }

        protected override void Admin_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Already in Admin Mode");
        }

        private string[] rowToArray(DataGridView dataGridView1, int rowIndex)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                sb.Append(dataGridView1[i, rowIndex].Value);
                if (i < dataGridView1.ColumnCount - 1)
                    sb.Append(',');
            }
            return sb.ToString().Split(',');
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string IDs = extractSelectedIDs();
            DialogResult result = MessageBox.Show(
                    "אנא אשרו מחיקת השורות הבאות\n" + IDs,
                    "אישור מחיקת שורות", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string response = PHPMethods.HttpDelete("deleteClass.php", IDs);
                if (response.Equals("deleted"))
                    MessageBox.Show("השורות המבוקשות נמחקו\nנא לרענן את הטופס");
                else if (response.Equals("none"))
                    MessageBox.Show("לא נמצאו שורות או שגיאת מחיקה");
                else if (response.Contains("Error") || response.Contains("error"))
                    MessageBox.Show(response);
            }
        }
        private string extractSelectedIDs()
        {
            string IDs = "";
            int count = dataGridView1.SelectedRows.Count;
            for (int i = 0; i < count; i++)
            {
                IDs += dataGridView1.SelectedRows[i].Cells["ID"].Value;
                if (i < count - 1)
                    IDs += ", ";
            }
            return IDs;
        }

        private void update_bt_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            if (updateRow(rowIndex))
            {
                refreshAll();
            }
            
        }

        private bool updateRow(int rowIndex)
        {
            string[] paramz = { "id", "course", "teacher", "room", "day", "start", "end", "type" };
            string[] valuz = rowToArray(dataGridView1, rowIndex);
            DialogResult dialogResult = MessageBox.Show("האם לעדכן נתוני רשומה " +
                valuz[0] + "?", "אישור שליחת נתונים לשרת",
                 MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string response = PHPMethods.HttpInsert("insertClass.php", paramz, valuz);
                if (response.Equals("Updated"))
                {
                    MessageBox.Show("הרשומה עודכנה");
                    return true;
                }
                else // if (response.Contains("Error") || response.Contains("error"))
                {
                    MessageBox.Show(response);
                    return false;
                }
            }
            else // if (dialogResult == DialogResult.No)
            {
                return false;
            }
        }
    }
}

using DBMS_PROJECT.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_PROJECT.View
{
    public partial class MemberInfo : Form
    {
        string a, b, c;
        public MemberInfo()
        {

            InitializeComponent();
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a1 = new Admin();
            a1.Show();
        }

        private void MemberInfoLoad(object sender, EventArgs e)
        {
            var member = ResisterController.GetAllMember();
            dataGridViewMember.DataSource = member;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CellClickEvent(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTrigger_Click(object sender, EventArgs e)
        {
            var a = LoginController.Manageuser(1);
            if(a!=0)
            {
                MessageBox.Show("Sucessfully Enable");
            }
        }

        private void buttondisabletrigger_Click(object sender, EventArgs e)
        {
            var a = LoginController.Manageuser(0);
            if (a != 0)
            {
                MessageBox.Show("Sucessfully Disable");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMember.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dataGridViewMember.CurrentRow.Selected = true;
                textBox1.Text = dataGridViewMember.Rows[e.RowIndex].Cells["userName"].FormattedValue.ToString();
                c = dataGridViewMember.Rows[e.RowIndex].Cells["userName"].FormattedValue.ToString();
                a = dataGridViewMember.Rows[e.RowIndex].Cells["Permission"].FormattedValue.ToString();
                if (a == "Invalid")
                {
                    b = "Valid";
                }
                if (a == "Valid")
                {
                    b = "Invalid";
                }
            }
        }

        private void buttonBloodStock_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                var res = ResisterController.updatepermission(b, c);
                if (!res)
                {


                }
                else
                {
                    MessageBox.Show("Permission Changed", "Message");
                    textBox1.Text = "";
                    var member = ResisterController.GetAllMember();
                    dataGridViewMember.DataSource = member;
                }

            }
            else
            {
                MessageBox.Show("Select User to manage", "Alert");
            }
            
        }
    }
}

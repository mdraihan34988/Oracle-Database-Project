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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_FromClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a1 = new Login();
            a1.Show();

        }

        private void buttonBloodStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blood_Stock bs = new Blood_Stock();
            bs.Show();
        }

        private void buttonMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberInfo bs = new MemberInfo();
            bs.Show();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            History bs = new History();
            bs.Show();
        }
    }
}

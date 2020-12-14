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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a1 = new Admin();
            a1.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a1 = new Login();
            a1.Show();
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            labelBalance.Text = null;
            dataGridViewHistory.DataSource = null;
            var request = RequestController.GetAllRequest();
            dataGridViewHistory.DataSource = request;
        }

        private void buttonDonor_Click(object sender, EventArgs e)
        {
            labelBalance.Text = null;
            dataGridViewHistory.DataSource = null;
            var donor = BloodDonerController.GetAllDonor();
            dataGridViewHistory.DataSource = donor;
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            dataGridViewHistory.DataSource = null;
            var result = RequestController.GetBalance();
            labelBalance.Text = result.ToString() + " BDT";
        }
    }
}

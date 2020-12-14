using DBMS_PROJECT.Controller;
using DBMS_PROJECT.Model;
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
    public partial class MemberHistory : Form
    {
        User u;
        public MemberHistory()
        {
            InitializeComponent();
        }
        public MemberHistory(dynamic user)
        {
            InitializeComponent();
            this.u = user;
        }

        private void BalanceClick(object sender, EventArgs e)
        {
            dataGridViewHistory.DataSource = null;
            var result = RequestController.GetBalance(u.Username);
            labelBalance.Text = result.ToString() + " BDT";
        }

        private void InfoFormClo(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DonorClick(object sender, EventArgs e)
        {
            labelBalance.Text = null;
            dataGridViewHistory.DataSource = null;
            var donor = BloodDonerController.GetDonor(u.Username);
            dataGridViewHistory.DataSource = donor;
        }

        private void ReqClick(object sender, EventArgs e)
        {
            labelBalance.Text = null;
            dataGridViewHistory.DataSource = null;
            var request = RequestController.GetRequest(u.Username);
            dataGridViewHistory.DataSource = request;
        }

        private void BackButton(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredMember r = new RegisteredMember(u);
            r.Show();
        }
    }
}

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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage l1 = new HomePage();
            l1.Show();
        }

        private void SearchDonorClicked(object sender, EventArgs e)
        {
            this.Hide();
            SearchDoner a = new SearchDoner();
            a.Show();
        }

        private void BloodReqClicked(object sender, EventArgs e)
        {
            this.Hide();
            BloodReqNon a = new BloodReqNon();
            a.Show();
        }
    }
}

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
    public partial class RegisteredMember : Form
    {
        User u;
  
        public RegisteredMember()
        {
            InitializeComponent();
        }
        public RegisteredMember(dynamic user)
        {
            InitializeComponent();
            this.u = user;
            labelName.Text = u.Username;
            labelBloodGroup.Text = ResisterController.GetInfo(u.Info_Id);
        }

        private void buttonDonateBlood_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodDonate a = new BloodDonate(u);
            a.Show();
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBloodRequest(object sender, EventArgs e)
        {
            this.Hide();
            BloodRequest a = new BloodRequest(u);
            a.Show();
        }

        private void ButtonHistory(object sender, EventArgs e)
        {
            this.Hide();
            MemberHistory a = new MemberHistory(u);
            a.Show();
        }

        private void ButtonEdit(object sender, EventArgs e)
        {
            this.Hide();
            EditInformation a = new EditInformation(u);
            a.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }
    }
}

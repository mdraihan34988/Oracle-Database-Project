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
    public partial class EditInformation : Form
    {
        User u;
        public EditInformation()
        {
            InitializeComponent();

        }
        public EditInformation(dynamic user)
        {
            InitializeComponent();
            this.u = user;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           
            string a, b = "";
            var res = ResisterController.GetMemberuname(u.Username);
            if(textBoxAddress.Text.Length == 0 && textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Provide at least one information to Update", "Alert");
            }
            else
            {
                if (textBoxAddress.Text.Length == 0)
                {
                    a = res.Address;
                    b = textBoxEmail.Text;
                }
                else if (textBoxEmail.Text.Length == 0)
                {
                    a = textBoxAddress.Text;
                    b = res.Gmail;
                }
                else
                {
                    a = textBoxAddress.Text;

                    b = textBoxEmail.Text;
                }

                int result = ResisterController.UpdateInfo(u.Username, b, a);
                if (result != 0)
                {
                     textBoxAddress.Text=null;
                     textBoxEmail.Text=null;

                    MessageBox.Show("Successfully updated!", "Message");
                }
            }

        }

        private void linkLabelChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ChangePassword a = new ChangePassword(u);
            a.Show();
        }

        private void BackClick(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredMember r = new RegisteredMember(u);
            r.Show();

        }

        private void UpadteFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

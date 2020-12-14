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
    public partial class ChangePassword : Form
    {
        User u;
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(dynamic user)
        {
            InitializeComponent();
            this.u = user;
        }

        private void BackButton(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredMember r = new RegisteredMember(u);
            r.Show();
        }

        private void ChangePasswordLoding(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ComfirmClick(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == textBoxRepass.Text)
            {
                string errors = "";
                errors += textBoxNewPassword.Text.Length == 0 ? "\nPlease Provide New Password" : "";
                errors += textBoxRepass.Text.Length == 0 ? "\nPlease provide Retype Password" : "";
                errors += textBoxOldPassword.Text.Length == 0 ? "\nPlease Provide Old Password" : "";
                if (errors.Length == 0)
                {
                    int result = ResisterController.UpdatePassword(u.Username,textBoxOldPassword.Text,textBoxNewPassword.Text);
                    if (result !=0)
                    {
                        
                        MessageBox.Show("Password Changed Succesfully", "Message");
                        this.Hide();
                        RegisteredMember a = new RegisteredMember(u);
                        a.Show();

                    }
                    else
                    {
                        MessageBox.Show("Your password is incorrect", "Alert");
                    }
                }
                else
                {
                    MessageBox.Show(errors, "Filled the flowing!");
                    return;
                }

            }
            else
            {
                MessageBox.Show("New password and re-Enter pasword doesn't match", "Alert");
            }
        }
    }
}

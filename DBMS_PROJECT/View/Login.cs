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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButtonClicked(object sender, EventArgs e)
        {

 
                User a = new User();

                if (textBoxUser.Text == "")
                {
                    MessageBox.Show("Username Can not be empty!", "Alert");
                }

                else if (textBoxPass.Text == "")
                {
                    MessageBox.Show("Password Can not be empty!", "Alert");
                }

                else
                {
                    var res = LoginController.ValidateMember(textBoxUser.Text);
                    a = res;
                    if (res == null)
                    {
                        textBoxUser.Text = "";
                        textBoxPass.Text = "";
                        MessageBox.Show("User does no exist", "Alert");

                    }
                    else
                    {
                        if (a.Password != textBoxPass.Text)
                        {
                            textBoxPass.Text = "";
                            MessageBox.Show("Invalid  Password", "Alert");
                        }
                        else if (a.Permission.Equals("Invalid"))
                        {
                        textBoxUser.Text = "";
                        textBoxPass.Text = "";
                        MessageBox.Show("Your account is blocked.Contact with support@btr.com", "Alert");
                        }
                        else
                        {
                            if (a.Type == "User")
                            {
                                this.Hide();
                                RegisteredMember r = new RegisteredMember(a);
                                r.Show();
                            }
                            else if (a.Type == "Admin")
                            {
                                this.Hide();
                                Admin r = new Admin();
                                r.Show();
                            }
                        }
                    }
                }
            




        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CreateClickEvent(object sender, EventArgs e)
        {
            this.Hide();
            Registration r1 = new Registration();
            r1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage r1 = new HomePage();
            r1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage r1 = new HomePage();
            r1.Show();
        }
    }
}

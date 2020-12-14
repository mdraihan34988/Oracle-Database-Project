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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RegisterClickEvent(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxRepass.Text)
            {
                string errors = "";
                errors += textBoxName.Text.Length == 0 ? "Please Provide Name" : "";
                errors += textBoxPassword.Text.Length == 0 ? "\nPlease Provide Password" : "";
                errors += textBoxRepass.Text.Length == 0 ? "\nPlease provide Retype password" : "";
                errors += textBoxUsername.Text.Length == 0 ? "\nPlease Provide User Name" : "";
                errors += textBoxAddress.Text.Length == 0 ? "\nPlease Provide Address" : "";
                errors += textBoxEmail.Text.Length == 0 ? "\nPlease Provide Gmail" : "";
                errors += comboBoxBloodGroup.SelectedItem== null ? "\nPlease Provide Blood Group" : "";
                if (!radioButtonFemale.Checked && !radioButtonMale.Checked)
                    errors += "\nPlease Provide Gender";
             
                errors += textBoxProfession.Text.Length == 0 ? "\n Please Provide Profession" : "";

                if (errors.Length != 0)
                {
                    MessageBox.Show(errors, "Filled the flowing!");
                    return;
                }
                else
                {
                    string gend = radioButtonFemale.Checked ? "Female" : "Male";


                    string a = dateTimePickerDob.Text;
                    var res = ResisterController.ResisterMember(textBoxName.Text, textBoxUsername.Text, textBoxPassword.Text, comboBoxBloodGroup.Text, dateTimePickerDob.Value, textBoxProfession.Text, gend, textBoxEmail.Text, textBoxAddress.Text,a );
                    if (!res)
                    {

                       
                    }
                    else
                    {
                        MessageBox.Show("Successfully registered", "Message");
                        this.Hide();
                        Login f1 = new Login();
                        f1.Show();

                    }
                }
            }
            else
            {
                MessageBox.Show("Password and Re-enter password must be same!", "Allert");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage r1 = new HomePage();
            r1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login r1 = new Login();
            r1.Show();
        }
    }
}

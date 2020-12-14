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
    public partial class BloodRequest : Form
    {
        User u;
        public BloodRequest()
        {
            InitializeComponent();
        }
        public BloodRequest(dynamic user)
        {
            InitializeComponent();
            this.u = user;
           // labelName.Text = u.Username;
           // labelBloodGroup.Text = ResisterController.GetInfo(u.Info_Id);
        }

        private void BldReqFromClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ReqClicked(object sender, EventArgs e)
        {
            string errors = "";
            errors += comboBoxBloodGroup.SelectedItem == null ? "\nPlease Provide Blood Group\n" : "";
            errors += textBoxQuantity.Text.Length == 0 ? "Please Provide Quantity\n" : "";
            if (textBoxQuantity.Text.Length != 0)
            {
                errors += Int32.Parse(textBoxQuantity.Text) < 0 ? "Quantity can not be negetive\n" : "";


            }



            if (errors == "")
            {
                string user = u.Username;
                string reqtype;
                int quantity = Int32.Parse(textBoxQuantity.Text);
                string membertype = "Registered";
                string bloodgroup = comboBoxBloodGroup.SelectedItem.ToString();
                var result = BloodStckController.CheckRequest(bloodgroup, quantity);
                if (result != 0)
                {
                   
                    textBoxQuantity.Text = null;
                    reqtype = "Accepted";
                    MessageBox.Show("Request Accepted. \n" + "Your service charge is : " + quantity * 50, "Success");
                }
                else
                {
                   
                    textBoxQuantity.Text = null;
                    reqtype = "Rejected";
                    MessageBox.Show("Request Rejected", "Failed");
                }
                RequestController.InsertRequest(user, membertype, reqtype, bloodgroup, quantity);
            }
            else
            {
                MessageBox.Show(errors, "Filled the flowing!");
                return;


            }
        }

        private void BackClicked(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredMember r = new RegisteredMember(u);
            r.Show();
        }
    }
}

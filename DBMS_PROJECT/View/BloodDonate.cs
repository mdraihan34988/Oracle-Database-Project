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
    public partial class BloodDonate : Form
    {
        User u;
        public BloodDonate()
        {
            InitializeComponent();
        }
        public BloodDonate(dynamic user)
        {
            InitializeComponent();
            this.u = user;
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            BloodDonerController.InsertDonateInfo(u);
            BloodStckController.UpdateStock(ResisterController.GetInfo(u.Info_Id));
            MessageBox.Show("Thank you for your donation", "Message");
            //buttonBack.PerformClick();
            this.Hide();
            RegisteredMember f1 = new RegisteredMember(u);
            f1.Show();

        }

        private void BloodDonateLoading(object sender, EventArgs e)
        {
            DateTime result = BloodDonerController.GetLastDonateDate(u.Username);
            TimeSpan donatetime = DateTime.Now.Subtract(result);
            if (result == DateTime.Parse("01/01/1753"))
            {
                label1.Text = "Not donated yet";
                dateTimePickerLastTimeDonate.Visible = false;
            }
            else
            {


                dateTimePickerLastTimeDonate.Visible = true;
                dateTimePickerLastTimeDonate.Value = DateTime.Parse(result.ToShortDateString());


            }

            if (donatetime.TotalDays >= 90)
            {
                buttonSubmit.Visible = true;

            }
            else
            {
                double a = 90 - donatetime.TotalDays;
                int c = (int)a;
                MessageBox.Show("You can not donate blood before " + c.ToString() + " Days", "Alert");
                // buttonBack.PerformClick();

            }
        }

        private void DonateClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackClick(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredMember f1 = new RegisteredMember(u);
            f1.Show();

        }
    }
}

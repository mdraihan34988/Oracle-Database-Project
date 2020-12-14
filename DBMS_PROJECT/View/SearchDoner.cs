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
    public partial class SearchDoner : Form
    {
        public SearchDoner()
        {
            InitializeComponent();
        }

        private void DonorSearchFromClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SearchButtonClicked(object sender, EventArgs e)
        {
            
            string error = "";
            error += comboBoxBloodGroup.SelectedItem == null ? "\nPlease Provide Blood Group" : "";
            if(error=="")
            {
                string bldgrp = comboBoxBloodGroup.SelectedItem.ToString();
                var member = ResisterController.GetMember(bldgrp);
                if (member.Count == 0)
                {
                    label3.Text = "No donor is available";
                }
                else
                {
                    label3.Text = "";
                }
                
                dataGridViewMember.DataSource = member;
            }
            else
            {
                MessageBox.Show("Select Blood Group", "Alert");
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h1 = new HomePage();
            h1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h1 = new HomePage();
            h1.Show();
        }

        private void dataGridViewMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

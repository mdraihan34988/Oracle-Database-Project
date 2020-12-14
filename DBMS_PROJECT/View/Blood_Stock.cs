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
    public partial class Blood_Stock : Form
    {
        public Blood_Stock()
        {
            InitializeComponent();
        }

        private void FormClosingevent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a1 = new Login();
            a1.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a1 = new Admin();
            a1.Show();
        }

        private void BloodStockFormLoad(object sender, EventArgs e)
        {
            var bloodstock = BloodStckController.GetAllBloodGroup();
            dataGridViewStock.DataSource = bloodstock;
        }

        private void dataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}

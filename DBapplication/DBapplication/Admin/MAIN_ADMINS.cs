using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class MAIN_ADMINS : Form
    {
        public MAIN_ADMINS()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form tmp = new WELCOME_TO_CINEPHILIA();
            tmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchadmin1.Show();
            searchadmin1.BringToFront();
        }

        private void MAIN_ADMINS_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            managerialsta1.Show();
            managerialsta1.BringToFront();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reportadmin1.Show();
            reportadmin1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addMovie1.Show();
            addMovie1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteUser1.Show();
            deleteUser1.BringToFront();
        }
    }
}

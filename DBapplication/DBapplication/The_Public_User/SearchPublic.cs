using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication.The_Public_User
{
    public partial class SearchPublic : UserControl
    {
        public SearchPublic()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form tmp = new search1public();
            tmp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form tmp = new search2public();
            tmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form tmp = new search3public();
            tmp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form tmp = new search4public();
            tmp.Show();
        }
    }
}

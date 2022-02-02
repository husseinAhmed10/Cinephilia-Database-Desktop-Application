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
    public partial class changepassword : Form
    {
        string username;
        Controller controllerObj;
        public changepassword(string user)
        {
            InitializeComponent();
            username = user;
            controllerObj = new Controller();
        }

        private void changepassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.changepass(username, textBox1.Text);
            if (result == 1)
                MessageBox.Show("password updated succefully");
            else
                MessageBox.Show("error updating password");
        }
    }
}

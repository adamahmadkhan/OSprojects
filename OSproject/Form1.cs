using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSproject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (name.Text == "CUI" && pass.Text == "CNS")
                MessageBox.Show("Login");
            else
                MessageBox.Show("Invalid");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

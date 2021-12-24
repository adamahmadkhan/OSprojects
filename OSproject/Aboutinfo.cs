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
    public partial class Aboutinfo : UserControl
    {
        uint page = 0;
        Label[] pg;
        public Aboutinfo()
        {
            InitializeComponent();
        }
        private void Aboutinfo_Load(object sender, EventArgs e)
        {
            pg= new Label[3];
            pg[0] = page1;
            pg[1] = page2;
            pg[2] = page3;
            pg[1].Hide();
            pg[2].Hide();
            pg[0].Show();
            


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (page == 0)
                last.Show();
            pg[page].Hide();
            page = page + 1;
            page = page % 3;
            label2.Text = "page" + page;
            pg[page].Show();
            
        }

        private void last_Click(object sender, EventArgs e)
        {
            pg[page].Hide();
            page = page - 1;
            page = page % 3;
            if (page == 0)
                last.Hide();
            label2.Text = "page" + page;
            pg[page].Show();

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void page2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void page3_Click(object sender, EventArgs e)
        {

        }
    }
}

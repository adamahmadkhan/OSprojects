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
    public partial class Firstcomefirstserved : UserControl
    {
        TextBox[] pid;
        int totalid;
        TextBox[] bt;
        public Firstcomefirstserved()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void id1_TextChanged(object sender, EventArgs e)
        {

        }
        public void reset()
        {
            pid = new TextBox[10];
            pid[0] = id0;
            pid[1] = id1;
            pid[2] = id2;
            pid[3] = id3;
            pid[4] = id4;
            pid[5] = id5;
            pid[6] = id6;
            pid[7] = id7;
            pid[8] = id8;
            pid[9] = id9;
            bt[0] = burst0;
            bt[1] = burst1;
            bt[2] = burst2;
            bt[3] = burst3;
            bt[4] = burst4;
            bt[5] = burst5;
            bt[6] = burst6;
            bt[7] = burst7;
            bt[8] = burst8;
            bt[9] = burst9;
            for (int i = 0; i < 9; i++)
            {
                pid[i].Hide();
                bt[i].Hide();
            }
              
            for(int i=0;i<totalid;i++)
            {
                pid[i].Show();
                bt[i].Show();
            }
        }
        private void total_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void sub_Click(object sender, EventArgs e)
        {
            totalid = Convert.ToInt32(total.Text);
            label2.Show();
            reset();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void burst0_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

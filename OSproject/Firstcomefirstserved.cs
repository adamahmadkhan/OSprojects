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
        public void working(int total)
        {
            TextBox[] pid = new TextBox[10];
            pid[0] = id10;
            pid[1] = id1;
            pid[2] = id2;
            pid[3] = id3;
            pid[4] = id4;
            pid[5] = id5;
            pid[6] = id6;
            pid[7] = id7;
            pid[8] = id8;
            pid[9] = id9;
            
            for(int i=1;i<total;i++)
            {
                label1.Text = label1.Text+ "Sr " + i + "\n";
                pid[i].Show();
            }
        }
        private void total_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void sub_Click(object sender, EventArgs e)
        {
            int totalid = Int32.Parse(total.Text);
            working(totalid);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

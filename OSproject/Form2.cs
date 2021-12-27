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
    public partial class Dashboard : Form
    {


        cpualgothirms c = new cpualgothirms();
        public Dashboard()
        {
            InitializeComponent();
            

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fcfs.Hide();
            RR.Hide();
            developers1.Hide();
            sjf.Hide();
            Prioritysch.Hide();
            SRT.Hide();
            aboutinfo1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {
            fcfs.Hide();
            developers1.Hide();
            sjf.Hide();
            RR.Hide();
            Prioritysch.Hide();
            SRT.Hide();
            aboutinfo1.Show();
        }

        private void developers1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fcfs.Hide();
            aboutinfo1.Hide();
            Prioritysch.Hide();
            RR.Hide();
            SRT.Hide();
            developers1.Show();
        }

        private void developers1_Load_1(object sender, EventArgs e)
        {

        }

        private void aboutinfo1_Load(object sender, EventArgs e)
        {

        }

        private void firstcome_Click(object sender, EventArgs e)
        {
            
            aboutinfo1.Hide();
            developers1.Hide();
            sjf.Hide();
            RR.Hide();
            Prioritysch.Hide();
            SRT.Hide();
            fcfs.label1.Text = "First come first served";
            fcfs.Show();


        }

        private void shortest_Click(object sender, EventArgs e)
        {
            aboutinfo1.Hide();
            developers1.Hide();
            fcfs.Hide();
            RR.Hide();
            Prioritysch.Hide();
            SRT.Hide();
            sjf.label1.Text = "Shortest job first";
            sjf.Show();
            
        }

        private void cpualgo_Load(object sender, EventArgs e)
        {

        }

        private void sjf_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            aboutinfo1.Hide();
            developers1.Hide();
            fcfs.Hide();
            sjf.Hide();
            RR.Hide();
            SRT.Hide();
            Prioritysch.label1.Text = "Priority";
            Prioritysch.prioritylabel.Show();
            Prioritysch.label4.Text ="Process Burst Waiting TurnAround Prority";
            Prioritysch.Show();
        }

        private void Prioritysch_Load(object sender, EventArgs e)
        {

        }

        private void RR_Load(object sender, EventArgs e)
        {
           
        }

        private void RRBTN_Click(object sender, EventArgs e)
        {
            aboutinfo1.Hide();
            developers1.Hide();
            fcfs.Hide();
            sjf.Hide();
            Prioritysch.Hide();
            SRT.Hide();
            RR.label1.Text = "Round Robin";
            RR.label7.Show();
            RR.timeslice.Show();
            RR.label4.Text = "Process Waiting TurnAround";
            RR.Show();
        }

        private void SRTbtn_Click(object sender, EventArgs e)
        {
            fcfs.Hide();
            RR.Hide();
            developers1.Hide();
            sjf.Hide();
            Prioritysch.Hide();
            aboutinfo1.Hide();
            SRT.Show();
            SRT.label1.Text = "Shortest Remaining Time First";
            SRT.prioritylabel.Show();
        }
    }
}

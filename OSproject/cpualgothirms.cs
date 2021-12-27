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
    public partial class cpualgothirms : UserControl
    {
        TextBox[] pid;
        int totalid;
        TextBox[] bt;
        TextBox[] PRI;
        int[] btime;
        int[] wtime;
        int[] tatime;
        int[] p;
        int[] po;
        Label[] g = new Label[23];
        int avwt;
        int avtat;
        int time_quantum;
        public int option = 0;

        public cpualgothirms()
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
            bt = new TextBox[10];
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
            g[0] = g0;
            g[1] = g1;
            g[2] = g2;
            g[3] = g3;
            g[4] = g4;
            g[5] = g5;
            g[6] = g6;
            g[7] = g7;
            g[8] = g8;
            g[9] = g9;
            g[10] = g10;
            g[11] = g11;
            g[12] = g12;
            g[13] = g13;
            g[14] = g14;
            g[15] = g15;
            g[16] = g16;
            g[17] = g17;
            g[18] = g18;
            g[19] = g19;
            g[20] = g20;
            g[21] = g21;
            g[22] = g22;
            for (int i = 0; i < 10; i++)
            {
                pid[i].Hide();
                bt[i].Hide();
                
            }
            for(int i =0;i<23;i++)
            {
                g[i].Hide();
            }
            for (int i = 0; i < totalid; i++)
            {
                pid[i].Show();
                bt[i].Show();
            }
            if (label1.Text == "Priority")
            {
                for (int i = 0; i < 10; i++)
                {
                    PRI[i].Hide();
                }

                for (int i = 0; i < totalid; i++)
                {
                    PRI[i].Show();
                }
            }
        }
        private void total_TextChanged(object sender, EventArgs e)
        {


        }

        private void sub_Click(object sender, EventArgs e)
        {
            totalid = Convert.ToInt32(total.Text);
            label2.Show();
            button1.Show();
            if (label1.Text == "Priority")
            {
                PRI = new TextBox[10];
                PRI[0] = pri0;
                PRI[1] = pri1;
                PRI[2] = pri2;
                PRI[3] = pri3;
                PRI[4] = pri4;
                PRI[5] = pri5;
                PRI[6] = pri6;
                PRI[7] = pri7;
                PRI[8] = pri8;
                PRI[9] = pri9;
                for (int i = 0; i < totalid; i++)
                {
                    PRI[i].Show();
                }
            }

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

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void RoundRobin()
        {
            wtime = new int[10];
            tatime = new int[10];
            int[] pidp = new int[30];
            int[] btp = new int[30];
            int[] ttp = new int[30];
            int[] wtp = new int[30];
           
            int k, totaltime = 0;
            for (int i = 0; i < totalid; i++)
            {
                totaltime = totaltime + btime[i];
            }
            ttp[0] = 0;
            k = 1;
            for (int j = 0; j <= totaltime; j++)
            {
                for (int i = 0; i < totalid; i++)
                {
                    if (btime[i] != 0)
                    {
                        pidp[k] = i;
                        if (btime[i] - time_quantum < 0)
                        {
                            wtp[k] = ttp[k - 1];
                            btp[k] = btime[i];
                            ttp[k] = wtp[k] + btime[i];
                            btime[i] = 0;
                            k++;
                        }
                        else
                        {
                            wtp[k] = ttp[k - 1];
                            ttp[k] = wtp[k] + time_quantum;
                            btime[i] = btime[i] - time_quantum;
                            k++;
                        }
                    }
                }
            }
            label5.Text = "";
            for (int i = 1; i < k; i++)
            {
                label5.Text += "pid  " + pidp[i] + "   " + "   " + wtp[i] +"     "+"    "+ttp[i]+ "\n";
                avwt += wtp[i];
                avtat += ttp[i];
            }
            avwt /= totalid;
            avtat /= totalid;
            label6.Show();
            label6.Text = "average waiting time: " + avwt + "\nAverage turn around time " + avtat;
  
            for (int i = 1; i < k; i++)
            {
                g[i].Show();
                g[i].Text = wtp[i] + "";
                for (int j = 0; j < btp[i]/ 2; j++)
                {
                    g[i].Text += " ";
                }
                g[i].Text += " p" + pidp[i];
                for (int j = 0; j < btp[i] / 2; j++)
                {
                    g[i].Text += " ";
                }

            }


        }
        public void Priorityscheduling()
        {
            wtime = new int[10];
            tatime = new int[10];
            wtime = new int[10];
            int temp, pos;
            for (int i = 0; i < totalid; i++)
            {
                pos = i;
                for (int j = i + 1; j < totalid; j++)
                {
                    if (po[j] > po[pos])
                        pos = j;
                }
                temp = po[i];
                po[i] = po[pos];
                po[pos] = temp;

                temp = btime[i];
                btime[i] = btime[pos];
                btime[pos] = temp;

                temp = p[i];
                p[i] = p[pos];
                p[pos] = temp;
            }
            wtime[0] = 0;
            for (int i = 1; i < totalid; i++)
            {
                wtime[i] = 0;
                for (int j = 0; j < i; j++)
                    wtime[i] += btime[j];
            }
            label5.Text = "";
            for (int i = 0; i < totalid; i++)
            {
                tatime[i] = btime[i] + wtime[i];
                avwt += wtime[i];
                avtat += tatime[i];       //Process Burst Time Waiting TurnAround Time
                label5.Text += "pid  " + p[i] + "   " + btime[i] + "        " + wtime[i] + "        " + tatime[i] + "            "+po[i]+"\n";
            }
            avwt /= totalid;
            avtat /= totalid;
            label6.Show();
            label6.Text = "average waiting time: " + avwt + "\nAverage turn around time " + avtat;
            for (int i = 0; i < totalid; i++)
            {
                g[i].Show();
                g[i].Text = wtime[i] + "";
                for (int j = 0; j < btime[i] / 2; j++)
                {
                    g[i].Text += " ";
                }
                g[i].Text += " p" + p[i];
                for (int j = 0; j < btime[i] / 2; j++)
                {
                    g[i].Text += " ";
                }
                
            }
            g[totalid].Show();
            g[totalid].Text = " " + tatime[totalid - 1];
            /*for (int i = 0; i < totalid; i++)
            {
                g[i].Show();
                g[i].Text = "p" + p[i];
                for (int j = 0; j < btime[i]; j++)
                {
                    g[i].Text += "  ";
                }
                g[i].Text += wtime[i];
            } */

        }
        public void shortestjob()
        {
            
            wtime = new int[10];
            tatime = new int[10];
            wtime = new int[10];
            int temp,pos;
            for (int i = 0; i < totalid; i++)
            {
                pos = i;
                for (int j = i + 1; j < totalid; j++)
                {
                    if (btime[j] < btime[pos])
                        pos = j;
                }

                temp = btime[i];
                btime[i] = btime[pos];
                btime[pos] = temp;

                temp = p[i];
                p[i] = p[pos];
                p[pos] = temp;
            }
                wtime[0] = 0;
                for (int i = 1; i < totalid; i++)
                {
                    wtime[i] = 0;
                    for (int j = 0; j < i; j++)
                        wtime[i] += btime[j];
                }
            label5.Text = "";
                for (int i = 0; i < totalid; i++)
                {
                    tatime[i] = btime[i] + wtime[i];
                    avwt += wtime[i];
                    avtat += tatime[i];       //Process Burst Time Waiting TurnAround Time
                    label5.Text +="pid  " + p[i]+ "   " + btime[i] + "        " + wtime[i] + "        " + tatime[i] + " \n";
                }
                avwt /= totalid;
                avtat /= totalid;
                label6.Show();
                label6.Text = "average waiting time: " + avwt + "\nAverage turn around time " + avtat;
              for (int i = 0; i < totalid; i++)
               {
                g[i].Show();
                g[i].Text = wtime[i]+"";
                for (int j = 0; j < btime[i]/2; j++)
                {
                    g[i].Text += " ";
                }
                    g[i].Text += " p" + p[i];
                for (int j = 0; j < btime[i] / 2; j++)
                {
                    g[i].Text += " ";
                }
               
              }
            g[totalid].Show();
            g[totalid].Text = " " + tatime[totalid - 1];


        }
        public void firstcomfirstser()
        {
            wtime = new int[10];
            tatime = new int[10];
            wtime = new int[10];
            wtime[0] = 0;
            for (int i = 1; i < totalid; i++)
            {
                wtime[i] = 0;
                for (int j = 0; j < i; j++)
                    wtime[i] += btime[j];
            }
            label5.Text = "";
            for (int i = 0; i < totalid; i++)
            {
                tatime[i] = btime[i] + wtime[i];
                avwt += wtime[i];
                avtat += tatime[i];       //Process Burst Time Waiting TurnAround Time
                label5.Text += "pid  " + pid[i].Text + "   " + btime[i] + "        " + wtime[i] + "        " + tatime[i] + " \n";
            }
            avwt /= totalid;
            avtat /= totalid;
            label6.Show();
            label6.Text = "average waiting time: " + avwt + "\nAverage turn around time " + avtat;
            for (int i = 0; i < totalid; i++)
            {
                g[i].Show();
                g[i].Text = wtime[i] + "";
                for (int j = 0; j < btime[i] / 2; j++)
                {
                    g[i].Text += " ";
                }
                g[i].Text += " p" + p[i];
                for (int j = 0; j < btime[i] / 2; j++)
                {
                    g[i].Text += " ";
                }
               
            }
            g[totalid].Show();
            g[totalid].Text = " " + tatime[totalid - 1];
            /*for (int i = 0; i < totalid; i++)
            {
                g[i].Show();
                g[i].Text = "p" + p[i];
                for (int j = 0; j < btime[i]; j++)
                {
                    g[i].Text+="  ";
                    
                }
                g[i].Text +=wtime[i];
            } */
        } 
        private void button1_Click(object sender, EventArgs e)
        {
             btime = new int[10];
             p = new int[10];
            po = new int[10];
             for(int i=0;i<totalid;i++)
            {
                btime[i] = Convert.ToInt32(bt[i].Text);
                p[i] = Convert.ToInt32(pid[i].Text);
            }
            if (label1.Text == "Priority")
            {
                for (int i = 0; i < totalid; i++)
                {
                    po[i] = Convert.ToInt32(PRI[i].Text);
                }
             }
            if(label1.Text== "Round Robin")
            {
                time_quantum = Convert.ToInt32(timeslice.Text);
            }

                label5.Text = "NIL";
            if (label1.Text == "First come first served")
                firstcomfirstser();
            else if (label1.Text == "Shortest job first")
                shortestjob();
            else if (label1.Text == "Priority")
                Priorityscheduling();
            else if (label1.Text == "Round Robin")
                RoundRobin();


           }

        private void burst1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Firstcomefirstserved_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void g3_Click(object sender, EventArgs e)
        {

        }

        private void g1_Click(object sender, EventArgs e)
        {

        }

        private void g0_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void prioritylabel_Click(object sender, EventArgs e)
        {

        }

        private void pri9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pri0_TextChanged(object sender, EventArgs e)
        {

        }

        private void pri7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pri8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pri5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pri1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pri2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pri3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pri4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pri6_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeslice_TextChanged(object sender, EventArgs e)
        {

        }

        private void g10_Click(object sender, EventArgs e)
        {

        }

        private void g14_Click(object sender, EventArgs e)
        {

        }
    }
}

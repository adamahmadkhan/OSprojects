
namespace OSproject
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.RRBTN = new System.Windows.Forms.Button();
            this.Priority = new System.Windows.Forms.Button();
            this.shortest = new System.Windows.Forms.Button();
            this.firstcome = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RR = new OSproject.cpualgothirms();
            this.Prioritysch = new OSproject.cpualgothirms();
            this.sjf = new OSproject.cpualgothirms();
            this.fcfs = new OSproject.cpualgothirms();
            this.aboutinfo2 = new OSproject.Aboutinfo();
            this.aboutinfo1 = new OSproject.Aboutinfo();
            this.developers1 = new OSproject.Developers();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.RRBTN);
            this.panel1.Controls.Add(this.Priority);
            this.panel1.Controls.Add(this.shortest);
            this.panel1.Controls.Add(this.firstcome);
            this.panel1.Controls.Add(this.About);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 538);
            this.panel1.TabIndex = 0;
            // 
            // RRBTN
            // 
            this.RRBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RRBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.RRBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RRBTN.ForeColor = System.Drawing.Color.White;
            this.RRBTN.Location = new System.Drawing.Point(7, 301);
            this.RRBTN.Name = "RRBTN";
            this.RRBTN.Size = new System.Drawing.Size(118, 28);
            this.RRBTN.TabIndex = 6;
            this.RRBTN.Text = "RoundRobin";
            this.RRBTN.UseVisualStyleBackColor = true;
            this.RRBTN.Click += new System.EventHandler(this.RRBTN_Click);
            // 
            // Priority
            // 
            this.Priority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Priority.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Priority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Priority.ForeColor = System.Drawing.Color.White;
            this.Priority.Location = new System.Drawing.Point(7, 266);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(118, 28);
            this.Priority.TabIndex = 5;
            this.Priority.Text = "Priority";
            this.Priority.UseVisualStyleBackColor = true;
            this.Priority.Click += new System.EventHandler(this.button2_Click);
            // 
            // shortest
            // 
            this.shortest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.shortest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.shortest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shortest.ForeColor = System.Drawing.Color.White;
            this.shortest.Location = new System.Drawing.Point(7, 232);
            this.shortest.Name = "shortest";
            this.shortest.Size = new System.Drawing.Size(118, 28);
            this.shortest.TabIndex = 4;
            this.shortest.Text = "SJF";
            this.shortest.UseVisualStyleBackColor = true;
            this.shortest.Click += new System.EventHandler(this.shortest_Click);
            // 
            // firstcome
            // 
            this.firstcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.firstcome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.firstcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstcome.ForeColor = System.Drawing.Color.White;
            this.firstcome.Location = new System.Drawing.Point(7, 198);
            this.firstcome.Name = "firstcome";
            this.firstcome.Size = new System.Drawing.Size(118, 28);
            this.firstcome.TabIndex = 3;
            this.firstcome.Text = "FCFS";
            this.firstcome.UseVisualStyleBackColor = true;
            this.firstcome.Click += new System.EventHandler(this.firstcome_Click);
            // 
            // About
            // 
            this.About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Location = new System.Drawing.Point(7, 164);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(118, 28);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "DashBoard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Developers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RR
            // 
            this.RR.Location = new System.Drawing.Point(149, 18);
            this.RR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RR.Name = "RR";
            this.RR.Size = new System.Drawing.Size(658, 424);
            this.RR.TabIndex = 7;
            this.RR.Visible = false;
            this.RR.Load += new System.EventHandler(this.RR_Load);
            // 
            // Prioritysch
            // 
            this.Prioritysch.Location = new System.Drawing.Point(149, 18);
            this.Prioritysch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prioritysch.Name = "Prioritysch";
            this.Prioritysch.Size = new System.Drawing.Size(658, 424);
            this.Prioritysch.TabIndex = 6;
            this.Prioritysch.Visible = false;
            this.Prioritysch.Load += new System.EventHandler(this.Prioritysch_Load);
            // 
            // sjf
            // 
            this.sjf.BackColor = System.Drawing.SystemColors.Control;
            this.sjf.Location = new System.Drawing.Point(149, 18);
            this.sjf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sjf.Name = "sjf";
            this.sjf.Size = new System.Drawing.Size(658, 424);
            this.sjf.TabIndex = 5;
            this.sjf.Visible = false;
            this.sjf.Load += new System.EventHandler(this.sjf_Load);
            // 
            // fcfs
            // 
            this.fcfs.Location = new System.Drawing.Point(149, 18);
            this.fcfs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fcfs.Name = "fcfs";
            this.fcfs.Size = new System.Drawing.Size(658, 424);
            this.fcfs.TabIndex = 4;
            this.fcfs.Visible = false;
            this.fcfs.Load += new System.EventHandler(this.cpualgo_Load);
            // 
            // aboutinfo2
            // 
            this.aboutinfo2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aboutinfo2.Location = new System.Drawing.Point(149, 18);
            this.aboutinfo2.Name = "aboutinfo2";
            this.aboutinfo2.Size = new System.Drawing.Size(653, 477);
            this.aboutinfo2.TabIndex = 3;
            this.aboutinfo2.Visible = false;
            // 
            // aboutinfo1
            // 
            this.aboutinfo1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aboutinfo1.Location = new System.Drawing.Point(143, 11);
            this.aboutinfo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboutinfo1.Name = "aboutinfo1";
            this.aboutinfo1.Size = new System.Drawing.Size(669, 527);
            this.aboutinfo1.TabIndex = 2;
            this.aboutinfo1.Visible = false;
            this.aboutinfo1.Load += new System.EventHandler(this.aboutinfo1_Load);
            // 
            // developers1
            // 
            this.developers1.Location = new System.Drawing.Point(143, 11);
            this.developers1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.developers1.Name = "developers1";
            this.developers1.Size = new System.Drawing.Size(666, 527);
            this.developers1.TabIndex = 1;
            this.developers1.Visible = false;
            this.developers1.Load += new System.EventHandler(this.developers1_Load_1);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(7, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "SRT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 538);
            this.Controls.Add(this.RR);
            this.Controls.Add(this.Prioritysch);
            this.Controls.Add(this.sjf);
            this.Controls.Add(this.fcfs);
            this.Controls.Add(this.aboutinfo2);
            this.Controls.Add(this.aboutinfo1);
            this.Controls.Add(this.developers1);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button About;
        private Developers developers1;
        private Aboutinfo aboutinfo1;
        private Aboutinfo aboutinfo2;
        private System.Windows.Forms.Button firstcome;
        public cpualgothirms fcfs;
        private System.Windows.Forms.Button shortest;
        private cpualgothirms sjf;
        private System.Windows.Forms.Button Priority;
        private cpualgothirms Prioritysch;
        private cpualgothirms RR;
        private System.Windows.Forms.Button RRBTN;
        private System.Windows.Forms.Button button2;
    }
}
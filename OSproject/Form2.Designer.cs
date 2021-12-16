﻿
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
            this.About = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstcome = new System.Windows.Forms.Button();
            this.aboutinfo2 = new OSproject.Aboutinfo();
            this.aboutinfo1 = new OSproject.Aboutinfo();
            this.developers1 = new OSproject.Developers();
            this.firstcomefirstserved1 = new OSproject.Firstcomefirstserved();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.firstcome);
            this.panel1.Controls.Add(this.About);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 662);
            this.panel1.TabIndex = 0;
            // 
            // About
            // 
            this.About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Location = new System.Drawing.Point(9, 252);
            this.About.Margin = new System.Windows.Forms.Padding(4);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(157, 34);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
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
            this.button1.Location = new System.Drawing.Point(9, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Developers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstcome
            // 
            this.firstcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.firstcome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.firstcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstcome.ForeColor = System.Drawing.Color.White;
            this.firstcome.Location = new System.Drawing.Point(9, 314);
            this.firstcome.Margin = new System.Windows.Forms.Padding(4);
            this.firstcome.Name = "firstcome";
            this.firstcome.Size = new System.Drawing.Size(157, 34);
            this.firstcome.TabIndex = 3;
            this.firstcome.Text = "FCFS";
            this.firstcome.UseVisualStyleBackColor = true;
            this.firstcome.Click += new System.EventHandler(this.firstcome_Click);
            // 
            // aboutinfo2
            // 
            this.aboutinfo2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aboutinfo2.Location = new System.Drawing.Point(199, 22);
            this.aboutinfo2.Margin = new System.Windows.Forms.Padding(4);
            this.aboutinfo2.Name = "aboutinfo2";
            this.aboutinfo2.Size = new System.Drawing.Size(871, 587);
            this.aboutinfo2.TabIndex = 3;
            // 
            // aboutinfo1
            // 
            this.aboutinfo1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aboutinfo1.Location = new System.Drawing.Point(191, 14);
            this.aboutinfo1.Margin = new System.Windows.Forms.Padding(5);
            this.aboutinfo1.Name = "aboutinfo1";
            this.aboutinfo1.Size = new System.Drawing.Size(892, 649);
            this.aboutinfo1.TabIndex = 2;
            this.aboutinfo1.Visible = false;
            this.aboutinfo1.Load += new System.EventHandler(this.aboutinfo1_Load);
            // 
            // developers1
            // 
            this.developers1.Location = new System.Drawing.Point(191, 14);
            this.developers1.Margin = new System.Windows.Forms.Padding(5);
            this.developers1.Name = "developers1";
            this.developers1.Size = new System.Drawing.Size(888, 649);
            this.developers1.TabIndex = 1;
            this.developers1.Visible = false;
            this.developers1.Load += new System.EventHandler(this.developers1_Load_1);
            // 
            // firstcomefirstserved1
            // 
            this.firstcomefirstserved1.Location = new System.Drawing.Point(241, 106);
            this.firstcomefirstserved1.Name = "firstcomefirstserved1";
            this.firstcomefirstserved1.Size = new System.Drawing.Size(757, 385);
            this.firstcomefirstserved1.TabIndex = 4;
            this.firstcomefirstserved1.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 662);
            this.Controls.Add(this.firstcomefirstserved1);
            this.Controls.Add(this.aboutinfo2);
            this.Controls.Add(this.aboutinfo1);
            this.Controls.Add(this.developers1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        public Firstcomefirstserved firstcomefirstserved1;
    }
}

namespace OSproject
{
    partial class Aboutinfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.next = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.page1 = new System.Windows.Forms.Label();
            this.page3 = new System.Windows.Forms.Label();
            this.page2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Lime;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.ForeColor = System.Drawing.Color.White;
            this.next.Location = new System.Drawing.Point(711, 549);
            this.next.Margin = new System.Windows.Forms.Padding(4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(157, 34);
            this.next.TabIndex = 2;
            this.next.Text = "Next Page";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // last
            // 
            this.last.BackColor = System.Drawing.Color.Lime;
            this.last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.last.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.last.ForeColor = System.Drawing.Color.White;
            this.last.Location = new System.Drawing.Point(3, 549);
            this.last.Margin = new System.Windows.Forms.Padding(4);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(157, 34);
            this.last.TabIndex = 3;
            this.last.Text = "last Page";
            this.last.UseVisualStyleBackColor = false;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "page0";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // page1
            // 
            this.page1.AutoSize = true;
            this.page1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page1.Location = new System.Drawing.Point(126, 248);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(95, 29);
            this.page1.TabIndex = 0;
            this.page1.Text = "pagee1";
            this.page1.Visible = false;
            this.page1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // page3
            // 
            this.page3.AutoSize = true;
            this.page3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page3.Location = new System.Drawing.Point(126, 248);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(81, 29);
            this.page3.TabIndex = 0;
            this.page3.Text = "page3";
            this.page3.Visible = false;
            this.page3.Click += new System.EventHandler(this.page3_Click);
            // 
            // page2
            // 
            this.page2.AutoSize = true;
            this.page2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page2.Location = new System.Drawing.Point(140, 248);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(81, 29);
            this.page2.TabIndex = 0;
            this.page2.Text = "page2";
            this.page2.Visible = false;
            // 
            // Aboutinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.page1);
            this.Controls.Add(this.page3);
            this.Controls.Add(this.page2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.last);
            this.Controls.Add(this.next);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Aboutinfo";
            this.Size = new System.Drawing.Size(871, 587);
            this.Load += new System.EventHandler(this.Aboutinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label page1;
        private System.Windows.Forms.Label page3;
        private System.Windows.Forms.Label page2;
    }
}


namespace OSproject
{
    partial class Firstcomefirstserved
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.TextBox();
            this.id5 = new System.Windows.Forms.TextBox();
            this.id4 = new System.Windows.Forms.TextBox();
            this.id3 = new System.Windows.Forms.TextBox();
            this.id2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIRST COME FIRST SERVE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(385, 16);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(131, 22);
            this.total.TabIndex = 1;
            this.total.Text = "Total process";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(95, 88);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(100, 22);
            this.id1.TabIndex = 4;
            this.id1.TextChanged += new System.EventHandler(this.id1_TextChanged);
            // 
            // id5
            // 
            this.id5.Location = new System.Drawing.Point(95, 200);
            this.id5.Name = "id5";
            this.id5.Size = new System.Drawing.Size(100, 22);
            this.id5.TabIndex = 5;
            // 
            // id4
            // 
            this.id4.Location = new System.Drawing.Point(95, 172);
            this.id4.Name = "id4";
            this.id4.Size = new System.Drawing.Size(100, 22);
            this.id4.TabIndex = 6;
            // 
            // id3
            // 
            this.id3.Location = new System.Drawing.Point(95, 144);
            this.id3.Name = "id3";
            this.id3.Size = new System.Drawing.Size(100, 22);
            this.id3.TabIndex = 7;
            // 
            // id2
            // 
            this.id2.Location = new System.Drawing.Point(95, 116);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(100, 22);
            this.id2.TabIndex = 8;
            // 
            // Firstcomefirstserved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.id2);
            this.Controls.Add(this.id3);
            this.Controls.Add(this.id4);
            this.Controls.Add(this.id5);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label1);
            this.Name = "Firstcomefirstserved";
            this.Size = new System.Drawing.Size(757, 385);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox total;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox id1;
        public System.Windows.Forms.TextBox id5;
        public System.Windows.Forms.TextBox id4;
        public System.Windows.Forms.TextBox id3;
        public System.Windows.Forms.TextBox id2;
    }
}

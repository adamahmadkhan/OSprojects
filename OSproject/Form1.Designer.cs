
namespace OSproject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.name = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(204, 69);
            this.name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(321, 22);
            this.name.TabIndex = 0;
            this.name.Text = "Enter Username";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(204, 159);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(321, 22);
            this.pass.TabIndex = 1;
            this.pass.Text = "Enter Password";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.sub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(204, 268);
            this.sub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(177, 46);
            this.sub.TabIndex = 4;
            this.sub.Text = "Submit";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sub);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Location = new System.Drawing.Point(517, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 402);
            this.panel1.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Panel panel1;
    }
}


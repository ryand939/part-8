﻿namespace part_8
{
    partial class Form1
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
			this.lblGameTitle = new System.Windows.Forms.Label();
			this.txtUserEntry = new System.Windows.Forms.TextBox();
			this.listUsedChar = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblGameTitle
			// 
			this.lblGameTitle.AutoSize = true;
			this.lblGameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lblGameTitle.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
			this.lblGameTitle.ForeColor = System.Drawing.Color.Black;
			this.lblGameTitle.Location = new System.Drawing.Point(230, 14);
			this.lblGameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblGameTitle.Name = "lblGameTitle";
			this.lblGameTitle.Size = new System.Drawing.Size(245, 27);
			this.lblGameTitle.TabIndex = 2;
			this.lblGameTitle.Text = "Part 8 ICS4U: Hangman";
			this.lblGameTitle.UseCompatibleTextRendering = true;
			this.lblGameTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.lblGameTitle_Paint);
			this.lblGameTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			// 
			// txtUserEntry
			// 
			this.txtUserEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtUserEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUserEntry.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserEntry.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.txtUserEntry.Location = new System.Drawing.Point(232, 181);
			this.txtUserEntry.Margin = new System.Windows.Forms.Padding(2);
			this.txtUserEntry.MaxLength = 1;
			this.txtUserEntry.Name = "txtUserEntry";
			this.txtUserEntry.Size = new System.Drawing.Size(25, 30);
			this.txtUserEntry.TabIndex = 3;
			this.txtUserEntry.MouseEnter += new System.EventHandler(this.txtUserEntry_MouseEnter);
			this.txtUserEntry.MouseLeave += new System.EventHandler(this.txtUserEntry_MouseLeave);
			// 
			// listUsedChar
			// 
			this.listUsedChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.listUsedChar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listUsedChar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listUsedChar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.listUsedChar.FormattingEnabled = true;
			this.listUsedChar.ItemHeight = 14;
			this.listUsedChar.Location = new System.Drawing.Point(234, 49);
			this.listUsedChar.Margin = new System.Windows.Forms.Padding(2);
			this.listUsedChar.Name = "listUsedChar";
			this.listUsedChar.Size = new System.Drawing.Size(132, 126);
			this.listUsedChar.TabIndex = 4;
			this.listUsedChar.SelectedIndexChanged += new System.EventHandler(this.listUsedChar_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(232, 47);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(136, 130);
			this.panel1.TabIndex = 5;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(232, 222);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(287, 59);
			this.panel2.TabIndex = 2;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(1, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hidden Word";
			this.label1.UseCompatibleTextRendering = true;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(244, 212);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(88, 20);
			this.panel3.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label2);
			this.panel4.Location = new System.Drawing.Point(389, 37);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(85, 21);
			this.panel4.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(1, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Game Status";
			this.label2.UseCompatibleTextRendering = true;
			this.label2.Paint += new System.Windows.Forms.PaintEventHandler(this.label2_Paint);
			// 
			// panel5
			// 
			this.panel5.Location = new System.Drawing.Point(376, 47);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(143, 164);
			this.panel5.TabIndex = 4;
			this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::part_8.Properties.Resources.gradient;
			this.pictureBox2.Location = new System.Drawing.Point(3, 4);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(526, 3);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.DimGray;
			this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmit.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnSubmit.Image = global::part_8.Properties.Resources.chrome_eQbkOh3eCb;
			this.btnSubmit.Location = new System.Drawing.Point(261, 181);
			this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(107, 30);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			this.btnSubmit.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSubmit_Paint);
			this.btnSubmit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSubmit_MouseDown);
			this.btnSubmit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSubmit_MouseUp);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::part_8.Properties.Resources.first;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(211, 269);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.DimGray;
			this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnExit.Image = global::part_8.Properties.Resources.chrome_eQbkOh3eCb;
			this.btnExit.Location = new System.Drawing.Point(472, 12);
			this.btnExit.Margin = new System.Windows.Forms.Padding(2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(50, 23);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.button1_Click);
			this.btnExit.Paint += new System.Windows.Forms.PaintEventHandler(this.btnExit_Paint);
			this.btnExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseDown);
			this.btnExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseUp);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(533, 292);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtUserEntry);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.listUsedChar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblGameTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Part 8: Hangman";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.TextBox txtUserEntry;
        private System.Windows.Forms.ListBox listUsedChar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel5;
	}
}


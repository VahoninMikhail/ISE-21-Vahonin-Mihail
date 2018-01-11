using System;

namespace WindowsFormsApplication4
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBoxLevels = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.buttonSetPlane = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(875, 582);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(6, 119);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(215, 196);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(83, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Забрать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(68, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Место:";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(125, 67);
			this.maskedTextBox1.Mask = "00";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(18, 20);
			this.maskedTextBox1.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.maskedTextBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(912, 332);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(227, 258);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Забрать машину";
			// 
			// listBoxLevels
			// 
			this.listBoxLevels.FormattingEnabled = true;
			this.listBoxLevels.Location = new System.Drawing.Point(918, 13);
			this.listBoxLevels.Name = "listBoxLevels";
			this.listBoxLevels.Size = new System.Drawing.Size(215, 134);
			this.listBoxLevels.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(894, 161);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 99);
			this.button2.TabIndex = 9;
			this.button2.Text = "down";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(1023, 161);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(110, 97);
			this.button4.TabIndex = 10;
			this.button4.Text = "up";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// buttonSetPlane
			// 
			this.buttonSetPlane.Location = new System.Drawing.Point(912, 267);
			this.buttonSetPlane.Name = "buttonSetPlane";
			this.buttonSetPlane.Size = new System.Drawing.Size(221, 59);
			this.buttonSetPlane.TabIndex = 11;
			this.buttonSetPlane.Text = "Set";
			this.buttonSetPlane.UseVisualStyleBackColor = true;
			this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1151, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// загрузитьToolStripMenuItem
			// 
			this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
			this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.загрузитьToolStripMenuItem.Text = "Загрузить";
			this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "txt file | *.txt";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "txt file | *.txt";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1151, 671);
			this.Controls.Add(this.buttonSetPlane);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listBoxLevels);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.HelpButton = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBoxLevels;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button buttonSetPlane;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}


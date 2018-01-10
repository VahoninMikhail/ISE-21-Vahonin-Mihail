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
            this.Transport = new System.Windows.Forms.Button();
            this.ButtonSetBombardir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMaxCountBomb = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonUpMove = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ButtonBomb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 394);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Transport
            // 
            this.Transport.Location = new System.Drawing.Point(447, 439);
            this.Transport.Name = "Transport";
            this.Transport.Size = new System.Drawing.Size(127, 23);
            this.Transport.TabIndex = 1;
            this.Transport.Text = "Задать Самолет";
            this.Transport.UseVisualStyleBackColor = true;
            this.Transport.Click += new System.EventHandler(this.Transport_Click);
            // 
            // ButtonSetBombardir
            // 
            this.ButtonSetBombardir.Location = new System.Drawing.Point(602, 439);
            this.ButtonSetBombardir.Name = "ButtonSetBombardir";
            this.ButtonSetBombardir.Size = new System.Drawing.Size(151, 23);
            this.ButtonSetBombardir.TabIndex = 2;
            this.ButtonSetBombardir.Text = "Задать бомбардировщик";
            this.ButtonSetBombardir.UseVisualStyleBackColor = true;
            this.ButtonSetBombardir.Click += new System.EventHandler(this.ButtonSetBombardir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Speed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max Count Bomb:";
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(111, 399);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(50, 20);
            this.textBoxMaxSpeed.TabIndex = 5;
            this.textBoxMaxSpeed.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxMaxCountBomb
            // 
            this.textBoxMaxCountBomb.Location = new System.Drawing.Point(111, 425);
            this.textBoxMaxCountBomb.Name = "textBoxMaxCountBomb";
            this.textBoxMaxCountBomb.Size = new System.Drawing.Size(50, 20);
            this.textBoxMaxCountBomb.TabIndex = 6;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(256, 401);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(59, 20);
            this.textBoxWeight.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Weight:";
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(447, 402);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 9;
            this.buttonMove.Text = "Движение";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click_Click);
            // 
            // buttonUpMove
            // 
            this.buttonUpMove.Location = new System.Drawing.Point(540, 402);
            this.buttonUpMove.Name = "buttonUpMove";
            this.buttonUpMove.Size = new System.Drawing.Size(86, 23);
            this.buttonUpMove.TabIndex = 10;
            this.buttonUpMove.Text = "Взлет";
            this.buttonUpMove.UseVisualStyleBackColor = true;
            this.buttonUpMove.Click += new System.EventHandler(this.buttonUpMove_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(198, 428);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Левый";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(284, 428);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Правый";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ButtonBomb
            // 
            this.ButtonBomb.Enabled = false;
            this.ButtonBomb.Location = new System.Drawing.Point(651, 402);
            this.ButtonBomb.Name = "ButtonBomb";
            this.ButtonBomb.Size = new System.Drawing.Size(102, 23);
            this.ButtonBomb.TabIndex = 13;
            this.ButtonBomb.Text = "Сбросить бомбу";
            this.ButtonBomb.UseVisualStyleBackColor = true;
            this.ButtonBomb.Click += new System.EventHandler(this.ButtonBomb_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(351, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(351, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonBomb);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonUpMove);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxMaxCountBomb);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSetBombardir);
            this.Controls.Add(this.Transport);
            this.Controls.Add(this.pictureBox1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Transport;
        private System.Windows.Forms.Button ButtonSetBombardir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.TextBox textBoxMaxCountBomb;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonUpMove;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button ButtonBomb;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


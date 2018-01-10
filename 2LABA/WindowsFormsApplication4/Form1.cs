using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
	public partial class Form1 : Form
	{
		Color color;
        Color dopColor;
		int maxSpeed;
        int maxCountPass;
        int weight;

        private ITechnique inter;

        public Form1()
		{
            InitializeComponent();
			color = Color.Black;
            dopColor = Color.Black;
			maxSpeed = 150;
            maxCountPass = 4;
            weight = 1500;
            button1.BackColor = color;
            button2.BackColor = dopColor;
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
		{

		}

        private void Transport_Click(object sender, EventArgs e)
        {
                inter = new Plane(maxSpeed, maxCountPass, weight, color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawBombardir(gr);
                pictureBox1.Image = bmp;
            ButtonBomb.Enabled = false;
        }

        private void buttonMove_Click_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveBombardir(gr);
                pictureBox1.Image = bmp;
            }

        }

        private void buttonUpMove_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveUpBombardir(gr);
                pictureBox1.Image = bmp;
            }
        }

        private bool checkFields()
        {
            if (!int.TryParse(textBoxMaxSpeed.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBoxMaxCountBomb.Text, out maxCountPass))
            {
                return false;
            }
            if (!int.TryParse(textBoxWeight.Text, out weight))
            {
                return false;
            }
            return true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonBomb_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Bombardir(maxSpeed, maxCountPass, weight, color, checkBox1.Checked, checkBox2.Checked, dopColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.giveBomb(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void ButtonSetBombardir_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Bombardir(maxSpeed, maxCountPass, weight, color, checkBox1.Checked, checkBox2.Checked, dopColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawBombardir(gr);
                pictureBox1.Image = bmp;
                ButtonBomb.Enabled = true;
            }
        }

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                button1.BackColor = color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                button2.BackColor = dopColor;
            }
        }
    }
}


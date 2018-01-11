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
		Parking parking;

		FormSelectCar form;

        public Form1()
		{
            InitializeComponent();
			parking = new Parking(5);
			for (int i = 1; i < 6; i++)
			{
				listBoxLevels.Items.Add("Уровень " + i);
			}
			listBoxLevels.SelectedIndex = parking.getCurrentLevel;
			Draw();
        }

		private void Draw()
		{
			if (listBoxLevels.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
				Graphics gr = Graphics.FromImage(bmp);
				parking.Draw(gr);
				pictureBox1.Image = bmp;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				var plane = new Plane(100, 4, 1000, dialog.Color);
				int place = parking.PutPlaneInParking(plane);
				Draw();
				MessageBox.Show("Вашеместо: " + place);
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					var plane = new Bombardir(100, 4, 1000, dialog.Color, true, true, true, dialogDop.Color);
					int place = parking.PutPlaneInParking(plane);
					Draw();
					MessageBox.Show("Вашеместо: " + place);
				}
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			if (maskedTextBox1.Text != "")
			{
				var plane = parking.GetPlaneInParking(Convert.ToInt32(maskedTextBox1.Text));

				Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
				Graphics gr = Graphics.FromImage(bmp);
				plane.setPosition(0, 0);
				plane.drawBombardir(gr);
				pictureBox2.Image = bmp;
				Draw();
			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			parking.LevelDown();
			listBoxLevels.SelectedIndex = parking.getCurrentLevel;
			Draw();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			parking.LevelUp();
			listBoxLevels.SelectedIndex = parking.getCurrentLevel;
			Draw();
		}

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            form = new FormSelectCar();
            form.AddEvent(AddPlane);
            form.Show();
        }

        private void AddPlane(ITechnique plane)
        {
            if (plane != null)
            {
                int place = parking.PutPlaneInParking(plane);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                else
                {
                    MessageBox.Show("Технику не удалось поставить");
                }
            }
        }

		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				if (parking.SaveData(saveFileDialog1.FileName))
				{
					MessageBox.Show("Сохранение прошло успешно", "",
						 MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Не сохранилось", "",
						 MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			{
				if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					if (parking.LoadData(openFileDialog1.FileName))
					{
						MessageBox.Show("Загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{

						MessageBox.Show("Не загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					Draw();
				}
			}
		}
	}
}



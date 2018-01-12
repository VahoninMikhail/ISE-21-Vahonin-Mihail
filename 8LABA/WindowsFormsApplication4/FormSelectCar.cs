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
	public partial class FormSelectCar : Form
	{
		public FormSelectCar()
		{
			InitializeComponent();
			panel2.MouseDown += panelColor_MouseDown;
			panel3.MouseDown += panelColor_MouseDown;
			panel4.MouseDown += panelColor_MouseDown;
			panel5.MouseDown += panelColor_MouseDown;
			panel6.MouseDown += panelColor_MouseDown;
			panel7.MouseDown += panelColor_MouseDown;
			panel8.MouseDown += panelColor_MouseDown;
			panel9.MouseDown += panelColor_MouseDown;

			buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
		}

		ITechnique plane = null;

		public ITechnique getPlane { get { return plane; } }

		private void DrawPlane()
		{
			if (plane != null)
			{
				Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
				Graphics gr = Graphics.FromImage(bmp);
				plane.setPosition(5, 5);
				plane.drawBombardir(gr);
				pictureBox1.Image = bmp;
			}
		}

		private event myDel eventAddPlane;

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			label1.DoDragDrop(label1.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void labelBombardir_MouseDown(object sender, MouseEventArgs e)
		{
			labelBombardir.DoDragDrop(labelBombardir.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}


		private void panel1_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Plane":
					plane = new Plane(100, 4, 500, Color.White);
					break;
				case "Bombardir":
					plane = new Bombardir(100, 4, 500, Color.White, true, true, true, Color.Black);
					break;
			}
			DrawPlane();
		}

		private void panel1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}


        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
		{
			if (plane != null)
			{
				plane.setMainColor((Color)e.Data.GetData(typeof(Color)));
				DrawPlane();
			}
		}

		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			(sender as Control).DoDragDrop((sender as Control).BackColor,
			  DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			if (plane != null)
			{
				if (plane is Bombardir)
				{
					(plane as Bombardir).setDopColor((Color)e.Data.GetData(typeof(Color)));
					DrawPlane();
				}
			}
		}

		public void AddEvent(myDel ev)
		{
			if (eventAddPlane == null)
			{
				eventAddPlane = new myDel(ev);
			}
			else
			{
				eventAddPlane += ev;
			}
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if(eventAddPlane != null)
			{
				eventAddPlane(plane);
			}
			Close();
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAAAAAAAAAAAAAAAAAAA
{
    public partial class Form1 : Form
    {
        private Salt salt;

        private WaterTap waterTap;

        private Knife knife;

        private Pan pan;

        private Oven stove;
        
        private Chicken[] chicken;
        private Apple[] apple;
        private Oil oil;
        public Form1()
        {
            InitializeComponent();
            waterTap = new WaterTap();
            knife = new Knife();
            pan = new Pan();
            stove = new Oven();
            waterTap = new WaterTap();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ker_Click(object sender, EventArgs e)
        {

        }
        
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                waterTap.State = true;
            }
        }
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                waterTap.State = false;
            }

        }


        private void numericUpDownPOP_ValueChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (apple == null)
            {
                MessageBox.Show("Добавьте яблоки", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (apple.Length == 0)
            {
                MessageBox.Show("Добавьте яблоки", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
      
            for (int i = 0; i < apple.Length; ++i)
            {
                knife.Clean_onion(apple[i]);
            }
            button11.Enabled = true;
            MessageBox.Show("Яблоки почищены", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (chicken == null)
            {
                MessageBox.Show("Добавьте курицу", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chicken.Length == 0)
            {
                MessageBox.Show("Добавьте курицу", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < chicken.Length; i++)
            {
                if (chicken[i].Dirty == true)
                {
                    MessageBox.Show("Помойте курицу", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < chicken.Length; i++)
            {
                knife.Clean_potato(chicken[i]);
            }
            //button9.Enabled = true;
            MessageBox.Show("Курица почищена", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (chicken == null)
            {
                MessageBox.Show("Добавьте курицу", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chicken.Length == 0)
            {
                MessageBox.Show("Добавьте курицу", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < chicken.Length; ++i)
            {

                if (chicken[i].Have_scin)
                {
                    MessageBox.Show("Картошка не почищена", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            pan.AddChicken(chicken);
            MessageBox.Show("Курица добавлена", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (apple == null)
            {
                MessageBox.Show("Добавьте яблоки", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (apple.Length == 0)
            {
                MessageBox.Show("Добавьте яблоки", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < apple.Length; ++i)
            {

                if (apple[i].Have_scin)
                {
                    MessageBox.Show("Яблоки не почищены", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            pan.AddApple(apple);
            MessageBox.Show("Яблоки добавлены", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (oil == null)
            {
                MessageBox.Show("Добавьте масло", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Масло добавлено", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pan.AddOil(oil);

        }
        private void button13_Click(object sender, EventArgs e)
        {
            salt = new Salt();
            salt.Count = Convert.ToInt32(numericUpDown3.Value);
            if (salt.Count > 0)
            {
                pan.AddSalt(salt);
                MessageBox.Show("Соль добавлена", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Добавьте соль", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            stove.Pan = pan;
            button7.Enabled = true;
            MessageBox.Show("Противень в духовке", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!stove.pan1())
            {
                MessageBox.Show("К приготовлению готово", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!stove.State)
            {
                MessageBox.Show("Духовка выключена", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stove.Cook();
            if (!stove.Pan.Isready())
            {
                radioButton3.Checked = false;
                MessageBox.Show("Готово", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = radioButton3.Checked;
        }
        private void button15_Click(object sender, EventArgs e)
        {

            chicken = new Chicken[3];
            for (int i = 0; i < chicken.Length; i++)
            {
                chicken[i] = new Chicken();

            }
            apple = new Apple[2];
            for (int i = 0; i < apple.Length; i++)
            {
                apple[i] = new Apple();
            }
            oil = new Oil();
            MessageBox.Show("Начинаем", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (chicken == null)
            {
                MessageBox.Show("Нет курицы", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    for (int i = 0; i < chicken.Length; ++i)
                    {
                        chicken[i].Dirty = false;
                    }

                    for (int i = 0; i < chicken.Length; i++)
                    {
                        if (chicken[i].Dirty == false && chicken[i] != null)
                        {
                            MessageBox.Show("Курицу помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Курицы нет", "Ошибкалогики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            
            
        }

        
    }
}

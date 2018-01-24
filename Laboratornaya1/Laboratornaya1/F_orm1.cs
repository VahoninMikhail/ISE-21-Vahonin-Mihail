using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratornaya1
{
    public partial class F_orm1 : Form
    {
        private S_alt salt;

        private W_aterTap waterTap;

        private K_nife knife;

        private P_an pan;

        private O_ven stove;

        private C_hicken[] chicken;
        private A_pple[] apple;
        private O_il oil;
        public F_orm1()
        {
            InitializeComponent();
            waterTap = new W_aterTap();
            knife = new K_nife();
            pan = new P_an();
            stove = new O_ven();
            waterTap = new W_aterTap();
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
                knife.Clean_apple(apple[i]);
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
                knife.Clean_chicken(chicken[i]);
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
            salt = new S_alt();
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

            chicken = new C_hicken[3];
            for (int i = 0; i < chicken.Length; i++)
            {
                chicken[i] = new C_hicken();

            }
            apple = new A_pple[2];
            for (int i = 0; i < apple.Length; i++)
            {
                apple[i] = new A_pple();
            }
            oil = new O_il();
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

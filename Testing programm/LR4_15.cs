using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace Theory
{
    public partial class LR4_15 : Form
    {
        public LR4_15()
        {
            InitializeComponent();
        }


        private static string[] listBoxAnswers = new string[4]
        {
            "Личный счёт клиента в банке, открываемый банком.",
            "Дополнительный уровень безопасности для банковских карт.",
            "Наклейка, нанесенная при высокой температуре в поверхность карты.",
            "Нанесенный на карту непрозрачный защитный слой."
        };

        private void button2_Click(object sender, EventArgs e)
        {
            int numberItem = listBox1.SelectedIndex;

            listBox2.Items.Add(listBox1.Text);
            listBox2.Text = Convert.ToString(numberItem);
            listBox1.Items.RemoveAt(numberItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numberItem = listBox1.SelectedIndex;

            listBox3.Items.Add(listBox1.Text);
            listBox3.Text = Convert.ToString(numberItem);
            listBox1.Items.RemoveAt(numberItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numberItem = listBox1.SelectedIndex;

            listBox4.Items.Add(listBox1.Text);
            listBox4.Text = Convert.ToString(numberItem);
            listBox1.Items.RemoveAt(numberItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int numberItem = listBox1.SelectedIndex;

            listBox5.Items.Add(listBox1.Text);
            listBox5.Text = Convert.ToString(numberItem);
            listBox1.Items.RemoveAt(numberItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                listBox2.Text == "" &&
                listBox3.Text == "" &&
                listBox4.Text == "" &&
                listBox5.Text == ""
                )
            {
                Methods.OtvetNaVopros("15", "");
            }
            else if (
                Convert.ToString(listBox2.Items[0]) == listBoxAnswers[1] &&
                Convert.ToString(listBox3.Items[0]) == listBoxAnswers[3] &&
                Convert.ToString(listBox4.Items[0]) == listBoxAnswers[0] &&
                Convert.ToString(listBox5.Items[0]) == listBoxAnswers[2]
                )
            {
                Methods.OtvetNaVopros("15", "Верно");
                Form LR4_16 = new LR4_16();
                Methods.PerehodNaFormu(this, LR4_16);
            }
            else
            {
                Methods.OtvetNaVopros("15", "Неверно");
                Form LR4_16 = new LR4_16();
                Methods.PerehodNaFormu(this, LR4_16);
            }
        }
    }
}

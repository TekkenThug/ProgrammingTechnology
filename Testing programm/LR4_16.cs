using System;
using System.Windows.Forms;
using Test;

namespace Theory
{
    public partial class LR4_16 : Form
    {
        public LR4_16()
        {
            InitializeComponent();
        }


        private static string[] listBoxAnswers = new string[4]
        {
            "Выпуск золотой карточки.",
            "MasterCard стал первой картой оплаты в Китае.",
            "Первые онлайн-банкоматы.",
            "Первая в мире карта с бонусами Cash Back."
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
                Methods.OtvetNaVopros("16", "");
            }
            else if (
                Convert.ToString(listBox2.Items[0]) == listBoxAnswers[2] &&
                Convert.ToString(listBox3.Items[0]) == listBoxAnswers[3] &&
                Convert.ToString(listBox4.Items[0]) == listBoxAnswers[0] &&
                Convert.ToString(listBox5.Items[0]) == listBoxAnswers[1]
                )
            {
                Methods.OtvetNaVopros("16", "Верно");
                Form LR4_Result = new LR4_Result();
                Methods.PerehodNaFormu(this, LR4_Result);
            }
            else
            {
                Methods.OtvetNaVopros("16", "Неверно");
                Form LR4_Result = new LR4_Result();
                Methods.PerehodNaFormu(this, LR4_Result);
            }
        }
    }
}

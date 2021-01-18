using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theory
{
    public partial class LR1_Password : Form
    {
        public LR1_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "BST") && (textBox2.Text == "1902"))
            {
                this.timer1.Stop();
                MessageBox.Show("Добро пожаловать в программу", "Окно ввода пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LR1_Title f = new LR1_Title();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Введен неправильный пароль", "Окно ввода пароля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Время истекло", "Окно ввода пароля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();
        }

        private void LR1_Password_Tick(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Пароль не введен");
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Логин не введен");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

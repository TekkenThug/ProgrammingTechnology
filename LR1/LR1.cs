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
    public partial class LR1 : Form
    {
        public LR1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);

            try
            {
                double w = Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), 1 + (2 * Math.Pow(Math.Sin(y), 2))) * (1 + z + (Math.Pow(z, 2) / 2) + (Math.Pow(z, 3) / 3) + (Math.Pow(z, 4) / 4));
                textBox4.Text = w.ToString("n");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка в программе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!(e.KeyChar.ToString() == "," && textBox1.Text.IndexOf(",") == -1) && !(e.KeyChar.ToString() == "-"))
                    e.Handled = true;
            }
            if (e.KeyChar.Equals((char)13))
                textBox2.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!(e.KeyChar.ToString() == "," && textBox1.Text.IndexOf(",") == -1) && !(e.KeyChar.ToString() == "-"))
                    e.Handled = true;
            }
            if (e.KeyChar.Equals((char)13))
                textBox3.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти из программы?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
    }
}

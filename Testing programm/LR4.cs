using System;
using System.Windows.Forms;
using Test;

namespace Theory
{
    public partial class LR4 : Form
    {
        public LR4()
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
            richTextBox1.LoadFile(@"..\Конспект.rtf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Methods.NachaloTesta(16);
            LR4_1 f = new LR4_1();
            this.Hide();
            f.ShowDialog();
        }
    }
}


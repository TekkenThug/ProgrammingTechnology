using System;
using System.Windows.Forms;
using Test;

namespace Theory
{
    public partial class LR4_8 : Form
    {
        public LR4_8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                Methods.OtvetNaVopros("7", "");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Methods.OtvetNaVopros("8", "Верно");
                Form LR4_9 = new LR4_9();
                Methods.PerehodNaFormu(this, LR4_9);
            }
            else
            {
                Methods.OtvetNaVopros("8", "Неверно");
                Form LR4_9 = new LR4_9();
                Methods.PerehodNaFormu(this, LR4_9);
            }
        }
    }
}

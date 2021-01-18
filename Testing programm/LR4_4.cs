using System;
using System.Windows.Forms;
using Test;

namespace Theory
{
    public partial class LR4_4 : Form
    {
        public LR4_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = textBox2.Text;
            if (answer == "")
            {
                Methods.OtvetNaVopros("4", "");
            }
            else if (answer == "Овердрафт")
            {
                Methods.OtvetNaVopros("4", "Верно");
                Form LR4_5 = new LR4_5();
                Methods.PerehodNaFormu(this, LR4_5);
            }
            else
            {
                Methods.OtvetNaVopros("4", "Неверно");
                Form LR4_5 = new LR4_5();
                Methods.PerehodNaFormu(this, LR4_5);
            }
        }
    }
}

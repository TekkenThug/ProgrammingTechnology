using System;
using System.Windows.Forms;
using Test;

namespace Theory
{
    public partial class LR4_2 : Form
    {
        public LR4_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked))
            {
                Methods.OtvetNaVopros("2", "");
            }
            else if (radioButton4.Checked)
            {
                Methods.OtvetNaVopros("2", "Верно");
                Form LR4_3 = new LR4_3();
                Methods.PerehodNaFormu(this, LR4_3);
            }
            else
            {
                Methods.OtvetNaVopros("2", "Неверно");
                Form LR4_3 = new LR4_3();
                Methods.PerehodNaFormu(this, LR4_3);
            }
        }

        private void LR4_2_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }
    }
}

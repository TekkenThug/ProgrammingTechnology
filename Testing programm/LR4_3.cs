using System;
using System.Windows.Forms;
using Test;

namespace Theory
{
    public partial class LR4_3 : Form
    {
        public LR4_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked) && (!radioButton5.Checked))
            {
                Methods.OtvetNaVopros("3", "");
            }
            else if (radioButton5.Checked)
            {
                Methods.OtvetNaVopros("3", "Верно");
                Form LR4_4 = new LR4_4();
                Methods.PerehodNaFormu(this, LR4_4);
            }
            else
            {
                Methods.OtvetNaVopros("3", "Неверно");
                Form LR4_4 = new LR4_4();
                Methods.PerehodNaFormu(this, LR4_4);
            }
        }

        private void LR4_3_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }
    }
}

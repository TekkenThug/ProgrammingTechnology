using System;
using System.Windows.Forms;
using Test;

namespace Theory
{
    public partial class LR4_1 : Form
    {
        public LR4_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked)) {
                Methods.OtvetNaVopros("1", "");
            }
            else if ((checkBox1.Checked) && (!checkBox2.Checked) && (checkBox3.Checked) && (!checkBox4.Checked))
            {

                Methods.OtvetNaVopros("1", "Верно");
                Form LR4_2 = new LR4_2();
                Methods.PerehodNaFormu(this, LR4_2);
            } 
            else
            {

                Methods.OtvetNaVopros("1", "Неверно");
                Form LR4_2 = new LR4_2();
                Methods.PerehodNaFormu(this, LR4_2);
            }

        }
    }
}

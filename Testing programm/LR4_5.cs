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
    public partial class LR4_5 : Form
    {
        public LR4_5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked))
            {
                Methods.OtvetNaVopros("5", "");
            }
            else if ((!checkBox1.Checked) && (checkBox2.Checked) && (checkBox3.Checked) && (!checkBox4.Checked))
            {
                Methods.OtvetNaVopros("5", "Верно");
                Form LR4_6 = new LR4_6();
                Methods.PerehodNaFormu(this, LR4_6);
            }
            else
            {
                Methods.OtvetNaVopros("5", "Неверно");
                Form LR4_6 = new LR4_6();
                Methods.PerehodNaFormu(this, LR4_6);
            }
        }

        private void LR4_5_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }
    }
}
